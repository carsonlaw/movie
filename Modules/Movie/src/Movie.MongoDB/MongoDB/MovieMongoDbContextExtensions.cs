using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Movie.MongoDB
{
    public static class MovieMongoDbContextExtensions
    {
        public static void ConfigureMovie(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new MovieMongoModelBuilderConfigurationOptions(
                MovieDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}