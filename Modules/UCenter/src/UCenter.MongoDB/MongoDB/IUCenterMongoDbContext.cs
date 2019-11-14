using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UCenter.MongoDB
{
    [ConnectionStringName(UCenterDbProperties.ConnectionStringName)]
    public interface IUCenterMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
