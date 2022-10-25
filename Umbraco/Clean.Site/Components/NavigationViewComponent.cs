using Clean.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Clean.Site.Components
{
   // [ViewComponent(Name ="Navigation")]
    public class NavigationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(IPublishedContent content)
        {
            var homePage = content.AncestorOrSelf<HomePage>();
            var navigationItems = homePage.MainNavigation;
            var model = new NavigationViewModel()
            {
                HomeUrl = homePage.Url(),
                NavigationItem = navigationItems,
            };
            return View(model);
        }
    }
}
