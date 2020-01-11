using Movie.Movies;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Movie.Collections
{
    /// <summary>
    /// 采集服务
    /// </summary>
    public class CollectionBaseAppService : ApplicationService, ICollectionBaseAppService
    {

        public async Task<PagedResultDto<MovieDto>> CollectionMovieList(CollectionJobArgsDto arg)
        {
            var ret = new PagedResultDto<MovieDto>();
            var html = await HttpGet(arg.Collection.BaseUrl);
            return ret;

        }
        public async Task<PagedResultDto<MovieDto>> CollectionMovieDetail(CollectionJobArgsDto arg)
        {
            var ret = new PagedResultDto<MovieDto>();
            var page = arg.SkipCount / arg.MaxResultCount + 1;
            var url = arg.Collection.BaseUrl + "?ac=detail&pg=" + page + "&h=" + arg.Hours;
            var html = await HttpGet(url);
            JObject j = JsonConvert.DeserializeObject<JObject>(html);
            ret.TotalCount = j.GetValue("total").Value<int>();
            var items = j.GetValue("list").Select(f => new MovieDto()
            {
                Actors = f.Value<string>("vod_actor").Split(',').Select(a => new PersonDto() { Name = a }),
                CateGory = new Categorys.CategoryDto() { Code = f.Value<int>("type_id").ToString() },
                Code = f.Value<string>("vod_en"),
                //Day = 
                Description = f.Value<string>("vod_content"),
                //Director = f.Value<string>("vod_director").Split(',').Select(a => new PersonDto() { Name = a }),
                Img = f.Value<string>("vod_pic"),
                ImgBanner = f.Value<string>("vod_pic_slide"),
                //Month = 
                PropertyCountry = new CountryDto() { Name = f.Value<string>("vod_area") },
                PropertyLang = new LanguageDto() { Name = f.Value<string>("vod_lang") },
                PropertyTypes = f.Value<string>("vod_class").Split(',').Select(a => new MovieTypeDto() { Name = a }),
                DatePub = f.Value<string>("vod_pubdate"),
                PropertyYear = new YearDto() { Name = f.Value<string>("vod_year") },
                Tip = f.Value<string>("vod_remarks"),
                Rating = f.Value<decimal>("vod_score_all"),
                Title = f.Value<string>("vod_name"),
                TitleSub = f.Value<string>("vod_sub"),
                TitleEn = "",
                TitleLetter = f.Value<string>("vod_letter"),
                Directors = f.Value<string>("vod_director").Split(',').Select(a => new PersonDto() { Name = a }),
                Writers = f.Value<string>("vod_writer").Split(',').Select(a => new PersonDto() { Name = a }),
                Downers = f.Value<string>("vod_play_from").Split(new string[] { "$$$" },System.StringSplitOptions.None).Select((a,i) => new MovieDownerDto()
                {
                    From = a,
                    Name = f.Value<string>("vod_play_url").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i].Split('$')[0],
                    Note = f.Value<string>("vod_play_note").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i],
                    Server = f.Value<string>("vod_play_server").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i],
                    Url = f.Value<string>("vod_play_url").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i].Split('$')[1]
                }),
                Players = f.Value<string>("vod_down_from").Split(new string[] { "$$$" }, System.StringSplitOptions.None).Select((a, i) => new MoviePlayerDto()
                {
                    From = a,
                    Name = f.Value<string>("vod_down_url").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i].Split('$')[0],
                    Note = f.Value<string>("vod_down_note").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i],
                    Server = f.Value<string>("vod_down_server").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i],
                    Url = f.Value<string>("vod_down_url").Split(new string[] { "$$$" }, System.StringSplitOptions.None)[i].Split('$')[1]
                })

                #region okzy json示例 
                /*
                 "vod_id":44707,
"type_id":6,
"type_id_1":1,
"group_id":0,
"vod_name":"六颗子弹",
"vod_sub":"",
"vod_en":"liukezidan",
"vod_status":1,
"vod_letter":"L",
"vod_color":"",
"vod_tag":"",
"vod_class":"动作片",
"vod_pic":"http:\/\/images.cnblogsc.com\/pic\/upload\/vod\/2020-01\/1578375839.jpg",
"vod_pic_thumb":"",
"vod_pic_slide":"",
"vod_actor":"尚格·云顿,乔·弗拉尼甘,Bianca,Van,Varenberg,Anna-Louise,Plowman",
"vod_director":"厄尼·巴巴拉什",
"vod_writer":"",
"vod_behind":"",
"vod_blurb":"查姆逊（尚格·云顿 Jean-Claude Van Damme 饰）是经验丰富的美国老兵，特别擅长解救被拐儿童。一次行动中发生的意外让他的心陷入了无尽的自责之中，此间，费登（乔·弗拉尼甘 Joe Fl",
"vod_remarks":"HD",
"vod_pubdate":"",
"vod_total":0,
"vod_serial":"0",
"vod_tv":"",
"vod_weekday":"",
"vod_area":"美国",
"vod_lang":"英语",
"vod_year":"2012",
"vod_version":"",
"vod_state":"",
"vod_author":"",
"vod_jumpurl":"",
"vod_tpl":"",
"vod_tpl_play":"",
"vod_tpl_down":"",
"vod_isend":1,
"vod_lock":0,
"vod_level":0,
"vod_copyright":0,
"vod_points":0,
"vod_points_play":0,
"vod_points_down":0,
"vod_hits":0,
"vod_hits_day":0,
"vod_hits_week":0,
"vod_hits_month":0,
"vod_duration":"",
"vod_up":0,
"vod_down":0,
"vod_score":"0.0",
"vod_score_all":0,
"vod_score_num":0,
"vod_time":"2020-01-07 15:33:26",
"vod_time_add":1578375903,
"vod_time_hits":0,
"vod_time_make":0,
"vod_trysee":0,
"vod_douban_id":0,
"vod_douban_score":"0.0",
"vod_reurl":"",
"vod_rel_vod":"",
"vod_rel_art":"",
"vod_pwd":"",
"vod_pwd_url":"",
"vod_pwd_play":"",
"vod_pwd_play_url":"",
"vod_pwd_down":"",
"vod_pwd_down_url":"",
"vod_content":"查姆逊（尚格·云顿 Jean-Claude Van Damme 饰）是经验丰富的美国老兵，特别擅长解救被拐儿童。一次行动中发生的意外让他的心陷入了无尽的自责之中，此间，费登（乔·弗拉尼甘 Joe Flanigan 饰）的女儿贝姬（Charlotte Beaumont 饰）无故失踪，通过重重的关系，费登找到了查姆逊，希望他能够帮助自己找回爱女，没想到，依然身处阴云之中的查姆逊拒绝了他。无奈之下，爱女心切的费登决定亲自出马，但很快，他便陷入了危险境地，索性得到了查姆逊相救，不然小命恐怕难保。查姆逊被费登的勇敢感动，决定帮助他，追踪着重重的线索，一个名为斯戴路（Louis Dempsey 饰）的黑帮分子浮出了水面，正如费登和查姆逊所想的那样，贝姬就在他的手中。",
"vod_play_from":"kuyun$$$ckm3u8",
"vod_play_server":"no$$$no",
"vod_play_note":"$$$",
"vod_play_url":"HD中字$https:\/\/youku.cdn10-okzy.com\/share\/43413ceafd2ea8d4a5e17d21c4840d9e$$$HD中字$https:\/\/youku.cdn10-okzy.com\/20200107\/12151_49215b54\/index.m3u8",
"vod_down_from":"xunlei",
"vod_down_server":"no",
"vod_down_note":"",
"vod_down_url":"HD中字$http:\/\/okzy.xzokzyzy.com\/20200107\/12151_49215b54\/六颗子弹.mp4",
"type_name":"动作片"
                 */
                #endregion
            });

            ret.Items = items.ToList();
            return ret;
        }


        /// <summary>
        /// 获取采集中心分类
        /// </summary>
        /// <param name="collection">采集配置</param>
        /// <returns></returns>
        public async Task<IEnumerable<CollectionCategoryDto>> collectionCategroy(string url)
        {
            var html = await HttpGet(url);
            JObject j = JsonConvert.DeserializeObject<JObject>(html);
            var cates = j.GetValue("class");
            //if (!cates.HasValues)
            //    return null;
            var ret = cates.Select(f => new CollectionCategoryDto
            {
                CategoryCode = f.Value<string>("type_id"),
                CategoryName = f.Value<string>("type_name")
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
