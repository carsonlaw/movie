using Movie.Categorys;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Movie.Collections
{
    public class CollectionCategoryDto
    {
        public CategoryDto? Category { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
    }
}
