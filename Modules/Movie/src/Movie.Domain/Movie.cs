using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using System.Text;

namespace Movie
{
    public class Movie: AuditedAggregateRoot<int>
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Code { get; set; }
        public string Tip { get; set; }
        public decimal Ratate { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string ImgBanner { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public Person? Director { get; set; }
        public IEnumerable<Person> Actors { get; set; }
        public Country PropertyCountry { get; set; }
        public Year PropertyYear { get; set; }
        public IEnumerable<MovieType> PropertyType { get; set; }

    }
}
