using System;
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
    }
}