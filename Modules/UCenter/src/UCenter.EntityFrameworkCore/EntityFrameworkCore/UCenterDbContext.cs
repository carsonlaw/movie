using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace UCenter.EntityFrameworkCore
{
    [ConnectionStringName(UCenterDbProperties.ConnectionStringName)]
    public class UCenterDbContext : AbpDbContext<UCenterDbContext>, IUCenterDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public UCenterDbContext(DbContextOptions<UCenterDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUCenter();
        }
    }
}