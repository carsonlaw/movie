using UCenter.Localization;
using Volo.Abp.Application.Services;

namespace UCenter
{
    public abstract class UCenterAppService : ApplicationService
    {
        protected UCenterAppService()
        {
            LocalizationResource = typeof(UCenterResource);
        }
    }
}
