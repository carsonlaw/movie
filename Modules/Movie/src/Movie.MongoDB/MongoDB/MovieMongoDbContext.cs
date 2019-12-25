using MongoDB.Driver;
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
        public IMongoCollection<Category> Categorys => Collection<Category>();

        public IMongoCollection<Movie> Movies => Collection<Movie>();

        public IMongoCollection<Person> Persons => Collection<Person>();


        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMovie();
        }
    }
}