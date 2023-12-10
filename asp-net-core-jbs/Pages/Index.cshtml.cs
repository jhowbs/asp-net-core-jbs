using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_jbs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public IndexModel ( ILogger<IndexModel> logger, IConfiguration configuration   I)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet ()
        {
            ViewData["Greetings"] = _configuration["Greetings"];
        }
    }
}
