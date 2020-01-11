using AutoMapper;
using Movie.Movies;
using Movie.Categorys;
using Movie.Collections;

namespace Movie
{
    public class MovieApplicationAutoMapperProfile : Profile
    {
        public MovieApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Year, YearDto>();
            CreateMap<YearDto, Year>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Language, LanguageDto>();
            CreateMap<LanguageDto, Language>();
            CreateMap<MovieType, MovieTypeDto>();
            CreateMap<MovieTypeDto, MovieType>();
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
            CreateMap<MoviePlayer, MoviePlayerDto>();
            CreateMap<MoviePlayerDto, MoviePlayer>();
            CreateMap<MovieDowner, MovieDownerDto>();
            CreateMap<MovieDownerDto, MovieDowner>();

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
            CreateMap<CreateUpdateMovieDto, Movie>();
            CreateMap<CreateUpdateMovieDto, MovieDto>();

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Collection, CollectionDto>();
            CreateMap<CollectionDto, Collection>(); 
            CreateMap<CollectionCategory, CollectionCategoryDto>();
            CreateMap<CollectionCategoryDto, CollectionCategory>();

        }
    }
}