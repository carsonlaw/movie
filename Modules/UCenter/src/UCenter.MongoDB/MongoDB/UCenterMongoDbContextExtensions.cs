using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace UCenter.MongoDB
{
    public static class UCenterMongoDbContextExtensions
    {
        public static void ConfigureUCenter(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UCenterMongoModelBuilderConfigurationOptions(
                UCenterDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}