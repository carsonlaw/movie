using Localization.Resources.AbpUi;
using UCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace UCenter
{
    [DependsOn(
        typeof(UCenterApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UCenterHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(UCenterHttpApiModule).Assembly);
            });
        }

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
