using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Movie
{
    [DependsOn(
        typeof(MovieApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class MovieHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Movie";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(MovieApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
