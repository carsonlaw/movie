using Movie.Movies;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Movie.Collections
{
    public interface ICollectionBaseAppService : IApplicationService
    {
        /// <summary>
        /// 获取远程采集中心分类情况
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <returns></returns>
        Task<IEnumerable<CollectionCategoryDto>> collectionCategroy(string url);

        /// <summary>
        /// 获取远程采集中心影视列表
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        Task<PagedResultDto<MovieDto>> CollectionMovieList(CollectionJobArgsDto arg);
        Task<PagedResultDto<MovieDto>> CollectionMovieDetail(CollectionJobArgsDto arg);
    }
}