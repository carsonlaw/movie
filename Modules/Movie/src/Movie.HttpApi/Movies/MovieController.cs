using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Movie.Movies
{
    [RemoteService]
    [Route("api/v1/Movie")]
    public class MovieController : Movie.MovieController,IMovieAppService
    {
        private readonly IMovieAppService _sampleAppService;

        public MovieController(IMovieAppService sampleAppService)
        {
            _sampleAppService = sampleAppService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<MovieDto> CreateAsync(CreateUpdateMovieDto input)
        {
            return await _sampleAppService.CreateAsync(input);
        }
        [HttpPost]
        [Route("delete")]
        public async Task DeleteAsync(Guid id)
        {
            await _sampleAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<MovieDto> GetAsync(Guid id)
        {
            return await _sampleAppService.GetAsync(id);
        }


        [HttpPost]
        [Route("list")]
        public async Task<PagedResultDto<MovieDto>> GetListAsync(QueryMovieDto input)
        {
            return await _sampleAppService.GetListAsync(input);
        }

        [HttpPost]
        [Route("update")]
        public async Task<MovieDto> UpdateAsync(Guid id, CreateUpdateMovieDto input)
        {
            return await _sampleAppService.UpdateAsync(id,input);
        }
    }
}
