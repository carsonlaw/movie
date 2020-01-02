using Microsoft.AspNetCore.Mvc;
using Movie.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Movie.Collections
{
    [RemoteService]
    [Route("api/v1/Collection")]
    public class CollectionController : Movie.MovieController ,ICollectionAppService
    {
        private readonly ICollectionAppService _AppService;

        public CollectionController(ICollectionAppService AppService)
        {
            _AppService = AppService;
        }
        [HttpPost]
        [Route("create")]
        public Task<CollectionDto> CreateAsync(CollectionDto input)
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
        public Task<CollectionDto> GetAsync(Guid id)
        {
            return _AppService.GetAsync(id);
        }
        [HttpPost]
        [Route("categorys")]
        public Task<IEnumerable<CollectionCategoryDto>> GetCategorys(Guid id)
        {
            return _AppService.GetCategorys(id);
        }

        [HttpPost]
        [Route("list")]
        public Task<PagedResultDto<CollectionDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _AppService.GetListAsync(input);
        }
        [HttpPost]
        [Route("update")]
        public Task<CollectionDto> UpdateAsync(Guid id, CollectionDto input)
        {
            return _AppService.UpdateAsync(id,input);
        }
    }
}
