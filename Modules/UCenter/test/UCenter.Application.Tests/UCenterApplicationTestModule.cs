using Volo.Abp.Modularity;

namespace UCenter
{
    [DependsOn(
        typeof(UCenterApplicationModule),
        typeof(UCenterDomainTestModule)
        )]
    public class UCenterApplicationTestModule : AbpModule
    {

    }
}
