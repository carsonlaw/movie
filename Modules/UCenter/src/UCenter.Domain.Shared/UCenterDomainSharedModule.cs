using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using UCenter.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.VirtualFileSystem;

namespace UCenter
{
    [DependsOn(
        typeof(AbpLocalizationModule)
    )]
    public class UCenterDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<UCenterDomainSharedModule>("UCenter");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<UCenterResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/UCenter");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("UCenter", typeof(UCenterResource));
            });
        }
    }
}
