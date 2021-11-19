/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Manager.Extend;

/// <summary>
/// The different modal actions available in the manager.
/// </summary>
public sealed class ModalActions
{
    /// <summary>
    /// Gets the available actions for the media preview modal.
    /// </summary>
    public ActionList<ModalAction> MediaPreview { get; private set; } = new();

    /// <summary>
    /// Default constructor.
    /// </summary>
    internal ModalActions() { }
}
