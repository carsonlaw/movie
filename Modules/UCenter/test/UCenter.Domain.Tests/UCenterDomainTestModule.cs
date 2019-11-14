using UCenter.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace UCenter
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UCenterEntityFrameworkCoreTestModule)
        )]
    public class UCenterDomainTestModule : AbpModule
    {
        
    }
}
