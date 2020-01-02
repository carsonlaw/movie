using Movie.Categorys;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Movie.Movies
{
    public class MovieDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Code { get; set; }
        public string Tip { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string ImgBanner { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public CategoryDto CateGory { get; set; }
        public PersonDto? Director { get; set; }
        public CountryDto? PropertyCountry { get; set; }
        public YearDto? PropertyYear { get; set; }
        public IEnumerable<PersonDto> Actors { get; set; }
        public IEnumerable<MovieTypeDto> PropertyType { get; set; }
    }
}