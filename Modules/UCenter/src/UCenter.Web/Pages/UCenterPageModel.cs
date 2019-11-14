using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UCenter.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UCenterPageModel : AbpPageModel
    {
        protected UCenterPageModel()
        {
            LocalizationResourceType = typeof(UCenterResource);
        }
    }
}