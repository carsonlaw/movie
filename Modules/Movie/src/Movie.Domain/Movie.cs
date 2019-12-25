using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using System.Text;

namespace Movie
{
    public class Movie: AuditedAggregateRoot<Guid>
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
        public Category CateGory { get; set; }
#nullable enable
        public Person? Director { get; set; }
        public Country? PropertyCountry { get; set; }
        public Year? PropertyYear { get; set; }
#nullable disable
        public IEnumerable<Person> Actors { get; set; }
        public IEnumerable<MovieType> PropertyType { get; set; }

    }
}
