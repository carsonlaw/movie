using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB
{
    [ConnectionStringName(MovieDbProperties.ConnectionStringName)]
    public interface IMovieMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
