using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Movie
{
    [DependsOn(
        typeof(MovieHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MovieConsoleApiClientModule : AbpModule
    {
        
    }
}
