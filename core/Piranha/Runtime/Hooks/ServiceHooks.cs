/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Runtime.Hooks;

/// <summary>
/// The standard repository hooks for a data model.
/// </summary>
public class ServiceHooks<T>
{
    /// <summary>
    /// Registers a new hook to be executed after the model
    /// has been loaded but BEFORE it has been added into
    /// the cache.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnLoad(HookManager.ModelDelegate<T> hook)
    {
        App.Hooks.RegisterOnLoad(hook);
    }

    /// <summary>
    /// Registers a new hook to be executed before the model
    /// is saved to the database.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnBeforeSave(HookManager.ModelDelegate<T> hook)
    {
        App.Hooks.RegisterOnBeforeSave(hook);
    }

    /// <summary>
    /// Registers a new hook to be executed after the model
    /// is saved to the database.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnAfterSave(HookManager.ModelDelegate<T> hook)
    {
        App.Hooks.RegisterOnAfterSave(hook);
    }

    /// <summary>
    /// Registers a new hook to be executed before the model
    /// is deleted from the database.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnBeforeDelete(HookManager.ModelDelegate<T> hook)
    {
        App.Hooks.RegisterOnBeforeDelete(hook);
    }

    /// <summary>
    /// Registers a new hook to be executed after the model
    /// is deleted from the database.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnAfterDelete(HookManager.ModelDelegate<T> hook)
    {
        App.Hooks.RegisterOnAfterDelete(hook);
    }

    /// <summary>
    /// Removes all registered hooks.
    /// </summary>
    public void Clear()
    {
        App.Hooks.Clear<T>();
    }
}
