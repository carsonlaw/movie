using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Movie.Movies
{
    public interface IMovieAppService : ICrudAppService<MovieDto, Guid,QueryMovieDto,CreateUpdateMovieDto>
    {
        
    }
}
