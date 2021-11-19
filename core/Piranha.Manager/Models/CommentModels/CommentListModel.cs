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

namespace Piranha.Manager.Models.CommentModels;

public sealed class CommentListModel
{
    /// <summary>
    /// Gets/sets the optionally select content id.
    /// </summary>
    public Guid? ContentId { get; set; }

    /// <summary>
    /// Gets/sets the available comments.
    /// </summary>
    public IList<CommentListItem> Comments { get; set; } = new List<CommentListItem>();

    /// <summary>
    /// Gets/sets the optional status message from the last operation.
    /// </summary>
    public StatusMessage Status { get; set; }
}
