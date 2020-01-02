using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Movie.Collections
{
    public interface ICollectionAppService : ICrudAppService<CollectionDto,Guid>
    {
        Task<IEnumerable<CollectionCategoryDto>> GetCategorys(Guid id);
    }
}
