using Movie.Categorys;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Movie.Collections
{
    public class CollectionAppService : CrudAppService<Collection, CollectionDto, Guid>, ICollectionAppService
    {
        public CollectionAppService(IRepository<Collection, Guid> repository) : base(repository)
        {
        }

        public async Task<IEnumerable<CollectionCategoryDto>> GetCategorys(Guid Id)
        {
            var collection = await base.GetAsync(Id);
            var cCategroys = await collectionCategroy(collection.BaseUrl);

            cCategroys = from c in cCategroys
                         join o in collection.CollectionCategorys on c.CategoryCode equals o.CategoryCode into o
                         from cate in o.DefaultIfEmpty()
                         select new CollectionCategoryDto()
                         {
                             Category = cate?.Category,
                             CategoryCode = c.CategoryCode,
                             CategoryName = c.CategoryName
                         };
            return cCategroys;

        }

        private async Task<IEnumerable<CollectionCategoryDto>> collectionCategroy(string baseUrl)
        {
            HttpClient client = new HttpClient();
            var html = await client.GetAsync(baseUrl);
            JObject j = JsonConvert.DeserializeObject<JObject>(await html.Content.ReadAsStringAsync());
            var cates = j.GetValue("class");
            if (!cates.HasValues)
                return null;
            var ret = cates.Select(f => new CollectionCategoryDto
            {
                 CategoryCode = f.Value<string>("type_id"),
                 CategoryName = f.Value<string>("type_name")
            });
            return ret;
        }
    }
}
