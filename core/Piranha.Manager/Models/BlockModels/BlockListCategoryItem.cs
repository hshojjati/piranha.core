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

namespace Piranha.Manager.Models.BlockModels;

/// <summary>
/// A category item in the block list model.
/// </summary>
public sealed class BlockListCategoryItem
{
    /// <summary>
    /// Gets/sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets/sets the available block types for the category.
    /// </summary>
    public IList<BlockListItem> Items { get; set; } = new List<BlockListItem>();
}
