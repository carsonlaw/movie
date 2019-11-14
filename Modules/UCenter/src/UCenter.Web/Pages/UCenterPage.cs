using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UCenter.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits UCenter.Web.Pages.UCenterPage
     */
    public abstract class UCenterPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UCenterResource> L { get; set; }
    }
}
