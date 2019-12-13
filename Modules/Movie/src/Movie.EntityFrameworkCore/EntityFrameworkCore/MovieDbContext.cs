using Microsoft.EntityFrameworkCore;
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