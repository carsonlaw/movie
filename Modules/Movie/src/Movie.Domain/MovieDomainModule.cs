using Volo.Abp.Modularity;
using Volo.Abp.BackgroundJobs;

namespace Movie
{
    [DependsOn(
        typeof(MovieDomainSharedModule),
        typeof(AbpBackgroundJobsDomainModule)
        )]
    public class MovieDomainModule : AbpModule
    {

    }
}
