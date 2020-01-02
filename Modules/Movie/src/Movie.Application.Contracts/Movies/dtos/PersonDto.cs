using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Movie.Movies
{
    public class PersonDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Img { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public CountryDto Country { get; set; }
        public bool IsActor { get; set; }
        public bool IsDirector { get; set; }
    }
}
