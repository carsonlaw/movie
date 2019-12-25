using Movie.Localization;
using Volo.Abp.Application.Services;

namespace Movie
{
    public abstract class MovieBaseAppService : ApplicationService
    {
        protected MovieBaseAppService()
        {
            LocalizationResource = typeof(MovieResource);
        }
    }
}
