using MongoDB.Driver;
using Movie.Collections;
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
        IMongoCollection<Category> Categorys { get; }
        IMongoCollection<Movie> Movies { get; }
        IMongoCollection<Person> Persons { get; }
        IMongoCollection<Collection> Collections { get; }
    }
}
