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

namespace Piranha.Manager.Models.CommentModels;

/// <summary>
/// Model for approving a comment.
/// </summary>
public sealed class CommentApprovalModel
{
    /// <summary>
    /// Gets/sets the comment id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the optional parent id of the comment.
    /// </summary>
    public Guid? ParentId { get; set; }
}
