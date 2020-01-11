using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB.Repositorys
{
    public class MongoCategroyRepository : MongoDbRepository<MovieMongoDbContext, Category,Guid>
    {
        
        public MongoCategroyRepository(IMongoDbContextProvider<MovieMongoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        //public override Task<Category> InsertAsync(Category entity, bool autoSave = false, CancellationToken cancellationToken = default)
        //{
        //    if (entity.ParentCategory != null)
        //    {
        //        //if (entity.Id == Guid.Empty) entity.Id = Guid.NewGuid();
        //        var parent = base.GetQueryable().FirstOrDefault(f => f.Id == entity.ParentCategory.Id);
        //        parent.Categorys.Add(entity);
        //        base.Update(parent, true);
        //        return Task.FromResult(entity);
        //    }
        //    else
        //        return base.InsertAsync(entity, autoSave, cancellationToken);
        //}

    }
}
