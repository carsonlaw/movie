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
    }
}