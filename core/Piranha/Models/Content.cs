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
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Piranha.Models;

/// <summary>
/// Base class for generic content.
/// </summary>
/// <typeparam name="T">The content type</typeparam>
[Serializable]
public abstract class Content<T> : GenericContent where T : Content<T>
{
    /// <summary>
    /// Creates a new page model using the given page type id.
    /// </summary>
    /// <param name="api">The current api</param>
    /// <param name="typeId">The unique page type id</param>
    /// <returns>The new model</returns>
    [SuppressMessage("Design", "CA1000", Justification = "Public API")]
    public static Task<T> CreateAsync(IApi api, string typeId = null)
    {
        return api.Content.CreateAsync<T>(typeId);
    }
}
