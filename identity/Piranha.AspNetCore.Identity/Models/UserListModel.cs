/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Piranha.AspNetCore.Identity.Models;

public class UserListModel
{
    public IList<UserListItem> Users { get; set; } = new List<UserListItem>();

    public static UserListModel Get(IDb db)
    {
        var model = new UserListModel
        {
            Users = db.Users
                .OrderBy(u => u.UserName)
                .Select(u => new UserListItem
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                    GravatarUrl = !string.IsNullOrWhiteSpace(u.Email) ? Utils.GetGravatarUrl(u.Email, 25) : null
                }).ToList()
        };

        var roles = db.Roles
            .ToList();

        foreach (var user in model.Users)
        {
            var userRoles = db.UserRoles
                .Where(r => r.UserId == user.Id)
                .ToList();

            foreach (var userRole in userRoles)
            {
                var role = roles.FirstOrDefault(r => r.Id == userRole.RoleId);
                if (role != null)
                {
                    user.Roles.Add(role.Name);
                }
            }
        }

        return model;
    }
}
