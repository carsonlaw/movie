using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace UCenter.EntityFrameworkCore
{
    public class UCenterModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UCenterModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}