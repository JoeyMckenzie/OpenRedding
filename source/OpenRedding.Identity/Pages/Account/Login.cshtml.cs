﻿namespace OpenRedding.Identity.Pages.Account
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.RazorPages;

#pragma warning disable SA1649 // File name should match first type name

    public class LoginModel : PageModel
#pragma warning restore SA1649 // File name should match first type name
    {
        public async Task OnGetAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
