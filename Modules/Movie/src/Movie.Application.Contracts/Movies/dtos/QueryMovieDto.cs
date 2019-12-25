using System;
using Volo.Abp.Application.Dtos;

namespace Movie.Movies
{
    public class QueryMovieDto : PagedAndSortedResultRequestDto
    {
        public string Title { get; set; }
    }
}