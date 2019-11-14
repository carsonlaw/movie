using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UCenter.Pages
{
    public abstract class UCenterPageModel : AbpPageModel
    {
        protected UCenterPageModel()
        {
            LocalizationResourceType = typeof(UCenterResource);
        }
    }
}