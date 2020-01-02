using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Movie.Categorys
{
    [RemoteService]
    [Route("api/v1/Category")]
    public class CategoryController : Movie.MovieController, ICategoryAppService
    {
        private readonly ICategoryAppService _AppService;

        public CategoryController(ICategoryAppService AppService)
        {
            _AppService = AppService;
        }
        [HttpPost]
        [Route("create")]
        public Task<CategoryDto> CreateAsync(CategoryDto input)
        {
            return _AppService.CreateAsync(input);
        }
        [HttpPost]
        [Route("delete")]
        public Task DeleteAsync(Guid id)
        {
            return _AppService.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public Task<CategoryDto> GetAsync(Guid id)
        {
            return _AppService.GetAsync(id);
        }
        [HttpPost]
        [Route("list")]
        public Task<PagedResultDto<CategoryDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _AppService.GetListAsync(input);
        }
        [HttpPost]
        [Route("update")]
        public Task<CategoryDto> UpdateAsync(Guid id, CategoryDto input)
        {
            return _AppService.UpdateAsync(id, input);
        }
    }
}
