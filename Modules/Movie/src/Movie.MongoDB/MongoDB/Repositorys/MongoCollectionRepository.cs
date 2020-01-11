using Movie.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB
{
    public class MongoCollectionRepository : MongoDbRepository<MovieMongoDbContext, Collection, Guid>
    {
        public MongoCollectionRepository(IMongoDbContextProvider<MovieMongoDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }
        public override Task<List<Collection>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            var ret = base.GetListAsync(includeDetails, cancellationToken);
            return ret;
        }

        public override IQueryable<Collection> WithDetails()
        {
            return base.WithDetails();
        }
    }
}
