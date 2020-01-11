using Movie.Categorys;
using Movie.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Movie.Collections
{
    /// <summary>
    /// 采集中心配置服务
    /// </summary>
    public class CollectionAppService : CrudAppService<Collection, CollectionDto, Guid>, ICollectionAppService
    {
        ICollectionBaseAppService _collService;
        public CollectionAppService(IRepository<Collection, Guid> repository,ICollectionBaseAppService collService) : base(repository)
        {
            _collService = collService;
        }

        /// <summary>
        /// 获取当前采集中心已配置分类及远程分类情况
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<CollectionCategoryDto>> GetCategorys(Guid Id)
        {
            var collection = await Repository.GetAsync(Id);
            var cCategroys = await _collService.collectionCategroy(collection.BaseUrl);

            var ret = from c in cCategroys
                         join o in collection.CollectionCategorys on c.CategoryCode equals o.CategoryCode into o
                         from cate in o.DefaultIfEmpty()
                         select new CollectionCategoryDto()
                         {
                             Category = cate==null?null: ObjectMapper.Map<Category,CategoryDto>(cate?.Category),
                             CategoryCode = c.CategoryCode,
                             CategoryName = c.CategoryName
                         };
            return ret;

        }

        public async Task<PagedResultDto<MovieDto>> GetCollectionMovieList(CollectionJobArgsDto arg)
        {
            return await _collService.CollectionMovieList(arg);
        }

        public async Task<PagedResultDto<MovieDto>> GetCollectionMovieDetail(CollectionJobArgsDto arg)
        {
            return await _collService.CollectionMovieDetail(arg);
        }

    }
}
