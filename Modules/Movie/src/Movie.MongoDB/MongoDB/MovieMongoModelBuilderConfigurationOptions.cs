using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB
{
    public class MovieMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public MovieMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}