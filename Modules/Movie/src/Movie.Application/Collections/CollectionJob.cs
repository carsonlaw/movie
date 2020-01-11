using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Movie.Movies;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.BackgroundJobs;
using AutoMapper;

namespace Movie.Collections
{
    public class CollectionJob : BackgroundJob<CollectionJobArgsDto>
    {
        IMovieAppService _movieService;
        IList<ICollectionBaseAppService> _collServices;
        IMapper _Mapper;
        public CollectionJob(IList<ICollectionBaseAppService> collService,IMovieAppService movieService,IMapper mapper)
        {
            _movieService = movieService;
            _collServices = collService;
            _Mapper = mapper;
        }
        public override void Execute(CollectionJobArgsDto collection)
        {
            var list = _collServices.FirstOrDefault().CollectionMovieDetail(collection).Result;
            foreach(var mv in list.Items)
            {
                _movieService.CreateAsync(_Mapper.Map<CreateUpdateMovieDto>(mv));
            }
            if (list.TotalCount > collection.SkipCount + collection.MaxResultCount)
            {
                collection.SkipCount += collection.MaxResultCount;
                Execute(collection);
            }
        }
    }
}
