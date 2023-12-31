﻿using Microsoft.AspNetCore.Mvc;
using shop.ViewModels.Common;

namespace shop.CustomerApp.Controllers.Components
{
    public class PagerViewComponent:ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
