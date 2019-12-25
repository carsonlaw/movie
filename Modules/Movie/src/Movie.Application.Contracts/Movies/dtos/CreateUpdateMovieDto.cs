using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Movie.Movies
{
    public class CreateUpdateMovieDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [StringLength(128)]
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