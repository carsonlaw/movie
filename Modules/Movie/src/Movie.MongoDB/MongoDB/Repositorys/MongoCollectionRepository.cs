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
        IMongoDbContextProvider<MovieMongoDbContext> _dbContextProvider;
        IMongoDbRepository<Category,Guid> _categoryRepository;
        public MongoCollectionRepository(IMongoDbContextProvider<MovieMongoDbContext> dbContextProvider, IMongoDbRepository<Category, Guid> CategoryRepository) : base(dbContextProvider)
        {
            _categoryRepository = CategoryRepository;
        }
       
        protected override IQueryable<Collection> GetQueryable()
        {

            return base.GetQueryable();
                   
        }
        
        public override IQueryable<Collection> WithDetails()
        {
            return base.WithDetails();
        }
    }
}
