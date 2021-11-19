/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha.core
 *
 */

using System.ComponentModel.DataAnnotations;

namespace Piranha.Manager.LocalAuth.Models;

/// <summary>
/// Model for form data.
/// </summary>
public sealed class LoginInputModel
{
    /// <summary>
    /// Gets/sets the user name.
    /// </summary>
    [Required]
    public string Username { get; set; }

    /// <summary>
    /// Gets/sets the password.
    /// </summary>
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
