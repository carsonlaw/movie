using Microsoft.Extensions.DependencyInjection;
using Movie.MongoDB.Repositorys;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB
{
    [DependsOn(
        typeof(MovieDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class MovieMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<MovieMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
                 //todo:没有起作用不能替换
                //options.AddRepository<Category, MongoCategroyRepository>();
                options.AddDefaultRepositories();
            });
        }
    }
}
