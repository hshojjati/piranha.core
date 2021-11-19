/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Collections.Generic;

namespace Piranha.Manager.Models;

public sealed class StructureModel
{
    /// <summary>
    /// The id of the item to move.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the structure items.
    /// </summary>
    public IList<StructureItem> Items { get; set; } = new List<StructureItem>();
}
