/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using Piranha.Manager.Extend;

namespace Piranha.Manager;

/// <summary>
/// Static class for defining the manager menu.
/// </summary>
public static class Actions
{
    /// <summary>
    /// Gets the available modal actions.
    /// </summary>
    public static ModalActions Modals { get; private set; } = new ModalActions();

    /// <summary>
    /// Gets/sets the available toolbar actions.
    /// </summary>
    public static ToolbarActions Toolbars { get; private set; } = new ToolbarActions();
}
