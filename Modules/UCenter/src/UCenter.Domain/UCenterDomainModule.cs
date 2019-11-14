using Volo.Abp.Modularity;

namespace UCenter
{
    [DependsOn(
        typeof(UCenterDomainSharedModule)
        )]
    public class UCenterDomainModule : AbpModule
    {

    }
}
