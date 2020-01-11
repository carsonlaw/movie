using Movie.Categorys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Movie.Movies
{
    public class CreateUpdateMovieDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public string TitleSub { get; set; }
        public string TitleEn { get; set; }
        public string Code { get; set; }
        public string Tip { get; set; }
        public string TitleLetter { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string ImgBanner { get; set; }
        public string DatePub { get; set; }
        public CategoryDto CateGory { get; set; }
        public CountryDto? PropertyCountry { get; set; }
        public YearDto? PropertyYear { get; set; }
        public LanguageDto? PropertyLang { get; set; }
        public IEnumerable<PersonDto> Actors { get; set; }
        public IEnumerable<PersonDto> Directors { get; set; }
        public IEnumerable<PersonDto> Writers { get; set; }
        public IEnumerable<MovieTypeDto> PropertyTypes { get; set; }
        public IEnumerable<MoviePlayerDto> Players { get; set; }
        public IEnumerable<MovieDownerDto> Downers { get; set; }
    }
}