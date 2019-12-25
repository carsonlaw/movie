using AutoMapper;
using Movie.Movies;
using Movie.Categorys;

namespace Movie
{
    public class MovieApplicationAutoMapperProfile : Profile
    {
        public MovieApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Movie, MovieDto>();
            CreateMap<CreateUpdateMovieDto, Movie>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

        }
    }
}