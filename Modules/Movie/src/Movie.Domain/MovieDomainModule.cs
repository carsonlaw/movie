using Volo.Abp.Modularity;

namespace Movie
{
    [DependsOn(
        typeof(MovieDomainSharedModule)
        )]
    public class MovieDomainModule : AbpModule
    {

    }
}
