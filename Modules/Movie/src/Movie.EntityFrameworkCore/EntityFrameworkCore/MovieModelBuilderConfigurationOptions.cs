using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Movie.EntityFrameworkCore
{
    public class MovieModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MovieModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}