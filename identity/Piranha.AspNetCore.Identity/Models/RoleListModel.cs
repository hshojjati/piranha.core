/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System.Collections.Generic;
using System.Linq;

namespace Piranha.AspNetCore.Identity.Models;

public class RoleListModel
{
    public RoleListModel()
    {
        Roles = new List<RoleListItem>();
    }

    public IList<RoleListItem> Roles { get; set; }

    public static RoleListModel Get(IDb db)
    {
        var model = new RoleListModel
        {
            Roles = db.Roles
                .OrderBy(r => r.Name)
                .Select(r => new RoleListItem
                {
                    Id = r.Id,
                    Name = r.Name
                }).ToList()
        };

        foreach (var role in model.Roles)
        {
            role.UserCount = db.UserRoles
                .Count(r => r.RoleId == role.Id);
        }
        return model;
    }
}
