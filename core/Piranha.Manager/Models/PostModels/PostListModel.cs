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

namespace Piranha.Manager.Models.PostModels;

public sealed class PostListModel
{
    public IList<PostListItem> Posts { get; set; } = new List<PostListItem>();
    public IList<PostListTypeItem> PostTypes { get; set; } = new List<PostListTypeItem>();
    public IList<PostListCategoryItem> Categories { get; set; } = new List<PostListCategoryItem>();
    public int TotalPosts { get; set; }
    public int TotalPages { get; set; }
    public int Index { get; set; }
}
