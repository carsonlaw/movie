using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UCenter.MongoDB
{
    [ConnectionStringName(UCenterDbProperties.ConnectionStringName)]
    public class UCenterMongoDbContext : AbpMongoDbContext, IUCenterMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUCenter();
        }
    }
}