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
/// Block list model.
/// </summary>
public sealed class BlockListModel
{
    /// <summary>
    /// Gets/sets the available block categories.
    /// </summary>
    public IList<BlockListCategoryItem> Categories { get; set; } = new List<BlockListCategoryItem>();

    /// <summary>
    /// Gets/sets the total number of block types.
    /// </summary>
    public int TypeCount { get; set; }
}
