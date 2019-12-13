using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB
{
    [ConnectionStringName(MovieDbProperties.ConnectionStringName)]
    public class MovieMongoDbContext : AbpMongoDbContext, IMovieMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMovie();
        }
    }
}