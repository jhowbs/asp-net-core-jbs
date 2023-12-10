using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_jbs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel ( ILogger<IndexModel> logger )
        {
            _logger = logger;
        }

        public void OnGet ()
        {

        }
    }
}
