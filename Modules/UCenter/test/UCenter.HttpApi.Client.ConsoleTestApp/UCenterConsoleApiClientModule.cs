using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace UCenter
{
    [DependsOn(
        typeof(UCenterHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UCenterConsoleApiClientModule : AbpModule
    {
        
    }
}
