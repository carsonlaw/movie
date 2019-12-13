using Movie.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Movie
{
    public abstract class MovieController : AbpController
    {
        protected MovieController()
        {
            LocalizationResource = typeof(MovieResource);
        }
    }
}
