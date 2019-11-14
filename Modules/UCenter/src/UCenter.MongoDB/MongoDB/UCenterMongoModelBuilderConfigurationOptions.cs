using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace UCenter.MongoDB
{
    public class UCenterMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UCenterMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}