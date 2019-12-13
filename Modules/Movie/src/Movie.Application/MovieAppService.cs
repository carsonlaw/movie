using Movie.Localization;
using Volo.Abp.Application.Services;

namespace Movie
{
    public abstract class MovieAppService : ApplicationService
    {
        protected MovieAppService()
        {
            LocalizationResource = typeof(MovieResource);
        }
    }
}
