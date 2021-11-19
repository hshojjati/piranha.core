/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System.Collections.Generic;

namespace Piranha.Manager.Models;

public sealed class ClientPermissions
{
    public static readonly string Add = "add";
    public static readonly string AddFolder = "addFolder";
    public static readonly string Approve = "approve";
    public static readonly string Delete = "delete";
    public static readonly string DeleteFolder = "deleteFolder";
    public static readonly string Edit = "edit";
    public static readonly string Preview = "preview";
    public static readonly string Publish = "publish";
    public static readonly string Save = "save";

    public IDictionary<string, bool> Aliases { get; } = new Dictionary<string, bool>()
    {
        { Delete, false },
        { Edit , false }
    };
    public IDictionary<string, bool> Comments { get; } = new Dictionary<string, bool>()
    {
        { Approve, false },
        { Delete, false }
    };
    public IDictionary<string, bool> Media { get; } = new Dictionary<string, bool>()
    {
        { Add, false },
        { AddFolder, false },
        { Delete, false },
        { DeleteFolder, false },
        { Edit, false }
    };
    public IDictionary<string, bool> Pages { get; } = new Dictionary<string, bool>()
    {
        { Add, false },
        { Delete, false },
        { Edit, false },
        { Preview, false },
        { Publish, false },
        { Save, false }
    };
    public IDictionary<string, bool> Posts { get; } = new Dictionary<string, bool>()
    {
        { Add, false },
        { Delete, false },
        { Edit, false },
        { Preview, false },
        { Publish, false },
        { Save, false }
    };
    public IDictionary<string, bool> Sites { get; } = new Dictionary<string, bool>()
    {
        { Add, false },
        { Delete, false },
        { Edit, false },
        { Save, false }
    };
}
