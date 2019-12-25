using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Movie.Movies
{
    public class MovieAppService : CrudAppService<Movie, MovieDto, Guid, QueryMovieDto, CreateUpdateMovieDto>, IMovieAppService
    {
        public MovieAppService(IRepository<Movie, Guid> repository)
            : base(repository)
        {
        }
        protected override IQueryable<Movie> CreateFilteredQuery(QueryMovieDto input)
        {
            return base.CreateFilteredQuery(input)
                .WhereIf(!string.IsNullOrEmpty(input.Title),f => f.Title.Contains(input.Title));
        }

    }
}