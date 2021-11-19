/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Manager.Models.BlockModels;

/// <summary>
/// An item in the block list model.
/// </summary>
public sealed class BlockListItem
{
    /// <summary>
    /// Gets/sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets/sets the css icon.
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// Gets/sets the block type.
    /// </summary>
    public string Type { get; set; }
}
