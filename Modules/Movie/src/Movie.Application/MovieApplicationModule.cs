using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Movie
{
    [DependsOn(
        typeof(MovieDomainModule),
        typeof(MovieApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        //typeof(AbpBackgroundJobsDomainModule)
        )]
    public class MovieApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<MovieApplicationModule>(validate: false);
            });
        }
    }
}
