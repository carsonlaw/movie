using Volo.Abp.Modularity;
using Volo.Abp.BackgroundJobs;

namespace Movie
{
    [DependsOn(
        typeof(MovieDomainSharedModule)
        )]
    public class MovieDomainModule : AbpModule
    {

    }
}
