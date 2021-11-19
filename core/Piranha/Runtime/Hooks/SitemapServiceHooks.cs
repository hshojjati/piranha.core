/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using Piranha.Models;

namespace Piranha.Runtime.Hooks;

public class SitemapServiceHooks
{
    /// <summary>
    /// Registers a new hook to be executed after the sitemap
    /// has been loaded but BEFORE it has been added into
    /// the cache.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnLoad(HookManager.ModelDelegate<Sitemap> hook)
    {
        App.Hooks.RegisterOnLoad(hook);
    }

    /// <summary>
    /// Registers a new hook to be executed when the sitemap
    /// is invalidated due to a change in the site structure.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnInvalidate(HookManager.ModelDelegate<Sitemap> hook)
    {
        App.Hooks.RegisterOnBeforeDelete(hook);
    }
}
