using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_jbs.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel ( ILogger<PrivacyModel> logger )
        {
            _logger = logger;
        }

        public void OnGet ()
        {
        }
    }

}
