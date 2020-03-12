using Microsoft.EntityFrameworkCore;
using Movie.Collections;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Movie.EntityFrameworkCore
{
    [ConnectionStringName(MovieDbProperties.ConnectionStringName)]
    public class MovieDbContext : AbpDbContext<MovieDbContext>, IMovieDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMovie();
        }
    }
}