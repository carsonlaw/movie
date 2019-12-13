using Volo.Abp.Modularity;

namespace Movie
{
    [DependsOn(
        typeof(MovieApplicationModule),
        typeof(MovieDomainTestModule)
        )]
    public class MovieApplicationTestModule : AbpModule
    {

    }
}
