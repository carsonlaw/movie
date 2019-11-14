using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace UCenter.EntityFrameworkCore
{
    [ConnectionStringName(UCenterDbProperties.ConnectionStringName)]
    public interface IUCenterDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}