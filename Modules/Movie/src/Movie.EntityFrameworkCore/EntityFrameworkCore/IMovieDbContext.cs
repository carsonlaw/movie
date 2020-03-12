using Microsoft.EntityFrameworkCore;
using Movie.Collections;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Movie.EntityFrameworkCore
{
    [ConnectionStringName(MovieDbProperties.ConnectionStringName)]
    public interface IMovieDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Category> Categorys { get; }
        DbSet<Movie> Movies { get; }
        DbSet<Person> Persons { get; }
        DbSet<Collection> Collections { get; }
    }
}