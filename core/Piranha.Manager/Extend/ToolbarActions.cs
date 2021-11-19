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
/// The different toolbar actions available in the manager.
/// </summary>
public sealed class ToolbarActions
{
    /// <summary>
    /// Gets the available actions for the alias view.
    /// </summary>
    public ActionList<ToolbarAction> AliasEdit { get; private set; } = new()
        {
            new()
            {
                InternalId = "Add",
                ActionView = "Partial/Actions/_AliasAdd"
            }
        };

    /// <summary>
    /// Gets the available actions for the comments view.
    /// </summary>
    public ActionList<ToolbarAction> CommentList { get; private set; } = new();

    /// <summary>
    /// Gets the available actions for the config view.
    /// </summary>
    public ActionList<ToolbarAction> ConfigEdit { get; private set; } = new()
        {
            new()
            {
                InternalId = "Save",
                ActionView = "Partial/Actions/_ConfigSave"
            }
        };

    /// <summary>
    /// Gets the available actions for the content list view.
    /// </summary>
    public ActionList<ToolbarAction> ContentList { get; private set; } = new();

    /// <summary>
    /// Gets the available actions for the content edit view.
    /// </summary>
    public ActionList<ToolbarAction> ContentEdit { get; private set; } = new()
        {
            new()
            {
                InternalId = "Languages",
                ActionView = "Partial/Actions/_ContentLangPicker"
            },
            new()
            {
                InternalId = "Settings",
                ActionView = "Partial/Actions/_ContentSettings"
            },
            new()
            {
                InternalId = "Save",
                ActionView = "Partial/Actions/_ContentSave"
            },
            new()
            {
                InternalId = "Delete",
                ActionView = "Partial/Actions/_ContentDelete"
            }
        };

    /// <summary>
    /// Gets the available actions for media list view.
    /// </summary>
    public ActionList<ToolbarAction> MediaList { get; private set; } = new();

    /// <summary>
    /// Gets the available actions for the module list view.
    /// </summary>
    /// <returns></returns>
    public ActionList<ToolbarAction> ModuleList { get; private set; } = new();

    /// <summary>
    /// Gets the available actions for the page edit view.
    /// </summary>
    public ActionList<ToolbarAction> PageEdit { get; private set; } = new()
        {
            new()
            {
                InternalId = "Settings",
                ActionView = "Partial/Actions/_PageSettings"
            },
            new()
            {
                InternalId = "Preview",
                ActionView = "Partial/Actions/_PagePreview"
            },
            new()
            {
                InternalId = "Save",
                ActionView = "Partial/Actions/_PageSave"
            },
            new()
            {
                InternalId = "Delete",
                ActionView = "Partial/Actions/_PageDelete"
            }
        };

    /// <summary>
    /// Gets the actions available for the page list view.
    /// </summary>
    public ActionList<ToolbarAction> PageList { get; private set; } = new()
        {
            new()
            {
                InternalId = "Expand",
                ActionView = "Partial/Actions/_PageListExpand"
            },
            new()
            {
                InternalId = "Collapse",
                ActionView = "Partial/Actions/_PageListCollapse"
            },
            new()
            {
                InternalId = "AddSite",
                ActionView = "Partial/Actions/_PageListAddSite"
            },
        };

    /// <summary>
    /// Gets the available actions for the page edit view.
    /// </summary>
    public ActionList<ToolbarAction> PostEdit { get; private set; } = new()
        {
            new()
            {
                InternalId = "Settings",
                ActionView = "Partial/Actions/_PostSettings"
            },
            new()
            {
                InternalId = "Preview",
                ActionView = "Partial/Actions/_PostPreview"
            },
            new()
            {
                InternalId = "Save",
                ActionView = "Partial/Actions/_PostSave"
            },
            new()
            {
                InternalId = "Delete",
                ActionView = "Partial/Actions/_PostDelete"
            }
        };

    /// <summary>
    /// Default constructor.
    /// </summary>
    internal ToolbarActions() { }
}
