using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace UCenter.Pages
{
    public class IndexModel : UCenterPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}