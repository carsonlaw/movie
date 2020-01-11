using MongoDB.Driver;
using Movie.Collections;
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
        public IMongoCollection<Collection> Collections => Collection<Collection>();


        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureMovie();
        }
    }
}