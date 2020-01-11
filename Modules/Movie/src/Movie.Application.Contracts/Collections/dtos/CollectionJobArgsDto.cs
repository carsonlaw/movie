using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Movie.Collections
{
    public class CollectionJobArgsDto:PagedResultRequestDto
    {
        /// <summary>
        /// 采集几个小时前更新
        /// </summary>
        public int Hours { get; set; }
        public CollectionDto Collection { get; set; }
    }
}
