using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Movie.Collections
{
    public class Collection : AuditedAggregateRoot<Guid>
    {
        public string BaseUrl { get; set; }
        public IEnumerable<CollectionCategory> CollectionCategorys { get; set; }


    }
}
