/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha.core
 *
 */

using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Piranha.Manager.LocalAuth.Models;

namespace Piranha.Manager.LocalAuth.Areas.Manager.Pages
{
    /// <summary>
    /// View model for the login page.
    /// </summary>
    public class LoginModel : PageModel
    {
        private readonly ISecurity _service;
        private readonly ManagerLocalizer _localizer;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="service">The current security service</param>
        /// <param name="localizer">The manager localizer</param>
        public LoginModel(ISecurity service, ManagerLocalizer localizer)
        {
            _service = service;
            _localizer = localizer;
        }

        /// <summary>
        /// Gets/sets the model for binding form data.
        /// </summary>
        /// <value></value>
        [BindProperty]
        public LoginInputModel Input { get; set; }

        /// <summary>
        /// Gets/sets the optional return url after successful
        /// authorization.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets/sets the possible error message to be returned
        /// after failed authorization.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets the login page.
        /// </summary>
        /// <param name="returnUrl">The optional return url</param>
        [SuppressMessage("Microsoft.Design", "CA1054", Justification = "Public API")]
        public void OnGet(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            ReturnUrl = returnUrl;
        }

        /// <summary>
        /// Handles authorization after a post.
        /// </summary>
        /// <param name="returnUrl">The optional return url</param>
        [SuppressMessage("Microsoft.Design", "CA1054", Justification = "Public API")]
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            await _service.SignOut(HttpContext);

            if (!ModelState.IsValid || !await _service.SignIn(HttpContext, Input.Username, Input.Password))
            {
                ModelState.Clear();
                ModelState.AddModelError(string.Empty, _localizer.General["Username and/or password are incorrect."].Value);
                return Page();
            }

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect($"~/manager/login/auth?returnUrl={ returnUrl }");
            }
            return LocalRedirect("~/manager/login/auth");
        }
    }
}