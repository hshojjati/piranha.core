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

namespace Piranha.Models;

/// <summary>
/// An translation status item.
/// </summary>
[Serializable]
public class TranslationStatusItem
{
    /// <summary>
    /// Gets/sets the languge id.
    /// </summary>
    public Guid LanguageId { get; set; }

    /// <summary>
    /// Gets/sets the language title.
    /// </summary>
    public string LanguageTitle { get; set; }

    /// <summary>
    /// Gets/sets if the language is up to date with the
    /// default master language.
    /// </summary>
    public bool IsUpToDate { get; set; }
}