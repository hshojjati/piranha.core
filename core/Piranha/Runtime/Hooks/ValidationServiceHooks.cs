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

public class ValidationServiceHooks<T> : ServiceHooks<T>
{
    /// <summary>
    /// Registers a new hook to be executed after the OnBeforeSave
    /// hook as been executed but before the model is saved to the
    /// database. This hook should be used to extend default model
    /// validation.
    /// </summary>
    /// <param name="hook">The hook</param>
    public void RegisterOnValidate(HookManager.ModelDelegate<T> hook)
    {
        App.Hooks.RegisterOnValidate<T>(hook);
    }
}
