using Localization.Resources.AbpUi;
using Movie.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Movie
{
    [DependsOn(
        typeof(MovieApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class MovieHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(MovieHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<MovieResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
