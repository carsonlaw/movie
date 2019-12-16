using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace UCenter
{
    [Dependency(ReplaceServices = true)]
    public class UCenterBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UCenter";
    }
}
