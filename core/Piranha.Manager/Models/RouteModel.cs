/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Manager.Models;

public sealed class RouteModel
{
    /// <summary>
    /// Gets/sets the route title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets/sets the route.
    /// </summary>
    public string Route { get; set; }
}
