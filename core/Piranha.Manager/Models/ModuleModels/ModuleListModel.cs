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

namespace Piranha.Manager.Models.ModuleModels;

/// <summary>
/// Modules model.
/// </summary>
public sealed class ModuleListModel
{
    /// <summary>
    /// Gets/set the available items.
    /// </summary>
    public IList<ModuleListItem> Items { get; set; } = new List<ModuleListItem>();
}
