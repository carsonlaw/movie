using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Services;

namespace Movie.Collections
{
    public class CollectionBaseService : DomainService
    {

        public async IEnumerable<Movie> CollectionMovie(CollectionArgs arg)
        {
            var html = await HttpGet(arg.Collection.BaseUrl);

        }


        /// <summary>
        /// 获取采集中心分类
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <returns></returns>
        public async Task<IEnumerable<CollectionCategory>> collectionCategroy(string baseUrl)
        {
            var html = await HttpGet(baseUrl);
            JObject j = JsonConvert.DeserializeObject<JObject>(await html.Content.ReadAsStringAsync());
            var cates = j.GetValue("class");
            if (!cates.HasValues)
                return null;
            var ret = cates.Select(f => new CollectionCategory
            {
                CategoryCode = f.Value<string>("type_id"),
                Category = new Category()
                {
                    Name = f.Value<string>("type_name")
                }
            });
            return ret;
        }

        private static async Task<string> HttpGet(string url)
        {
            var html = "";
            using (HttpClient client = new HttpClient())
            {
                using (var msg = await client.GetAsync(url))
                { 
                    html = await msg.Content.ReadAsStringAsync();
                }
            }
            return html;
        }

    }
}
