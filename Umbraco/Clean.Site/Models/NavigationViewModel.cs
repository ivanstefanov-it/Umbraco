using Umbraco.Cms.Web.Common.PublishedModels;

namespace Clean.Site.Models
{
    public class NavigationViewModel
    {
        public string HomeUrl { get; set; }
        public IEnumerable<NavigationItem> NavigationItem { get; set; }
    }
}
