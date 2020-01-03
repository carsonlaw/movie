using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.BackgroundJobs;

namespace Movie.Collections
{
    public class CollectionArgs
    {
        public Collection Collection { get; set; }
    }
}
