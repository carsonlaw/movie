using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using System.Text;

namespace Movie
{
    public class Movie: AuditedAggregateRoot<Guid>
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
        public Category CateGory { get; set; }
#nullable enable
        public Country? PropertyCountry { get; set; }
        public Year? PropertyYear { get; set; }
        public Language? PropertyLang { get; set; }
#nullable disable
        public IEnumerable<Person> Actors { get; set; }
        public IEnumerable<Person> Directors { get; set; }
        public IEnumerable<Person> Writers { get; set; }
        public IEnumerable<MovieType> PropertyTypes { get; set; }
        public IEnumerable<MoviePlayer> Players { get; set; }
        public IEnumerable<MovieDowner> Downers { get; set; }

    }
}
