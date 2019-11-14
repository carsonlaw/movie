using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace UCenter
{
    [DependsOn(
        typeof(UCenterApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UCenterHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "UCenter";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UCenterApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
