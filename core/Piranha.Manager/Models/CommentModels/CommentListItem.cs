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

public sealed class CommentListItem
{
    public Guid Id { get; set; }
    public string Author { get; set; }
    public string AuthorImage { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
    public string ArticleTitle { get; set; }
    public string ArticleUrl { get; set; }
    public bool IsApproved { get; set; }
    public string Created { get; set; }
    internal DateTime CreatedDate { get; set; }
}
