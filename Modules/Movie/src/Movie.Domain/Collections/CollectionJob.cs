using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.BackgroundJobs;

namespace Movie.Collections
{
    public class CollectionJob : BackgroundJob<CollectionArgs>
    {
        public override void Execute(CollectionArgs collection)
        {
            throw new NotImplementedException();
        }
    }
}
