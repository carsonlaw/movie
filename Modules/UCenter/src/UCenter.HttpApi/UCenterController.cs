using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace UCenter
{
    public abstract class UCenterController : AbpController
    {
        protected UCenterController()
        {
            LocalizationResource = typeof(UCenterResource);
        }
    }
}
