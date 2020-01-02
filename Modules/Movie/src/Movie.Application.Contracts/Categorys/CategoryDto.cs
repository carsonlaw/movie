using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Movie.Categorys
{
    public class CategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public CategoryDto? ParentCategory { get; set; }
        public IEnumerable<CategoryDto> Categorys { get; set; }
    }
}
