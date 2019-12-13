using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Movie.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.VirtualFileSystem;

namespace Movie
{
    [DependsOn(
        typeof(AbpLocalizationModule)
    )]
    public class MovieDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<MovieDomainSharedModule>("Movie");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<MovieResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Movie");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Movie", typeof(MovieResource));
            });
        }
    }
}
