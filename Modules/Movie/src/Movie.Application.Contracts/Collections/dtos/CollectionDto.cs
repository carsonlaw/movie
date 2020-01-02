using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Movie.Collections
{
    public class CollectionDto : EntityDto<Guid>
    {
        public string BaseUrl { get; set; }
        public IEnumerable<CollectionCategoryDto> CollectionCategorys { get; set; }
    }
}
