using Localization.Resources.AbpUi;
using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace UCenter
{
    [DependsOn(
        typeof(UCenterApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UCenterHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<UCenterResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
