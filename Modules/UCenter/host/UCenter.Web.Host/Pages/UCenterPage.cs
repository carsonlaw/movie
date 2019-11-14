using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UCenter.Pages
{
    public abstract class UCenterPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UCenterResource> L { get; set; }
    }
}
