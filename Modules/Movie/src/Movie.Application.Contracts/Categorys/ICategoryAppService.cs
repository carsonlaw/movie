using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Movie.Categorys
{
    public interface ICategoryAppService : ICrudAppService<CategoryDto, Guid>
    {
    }
}
