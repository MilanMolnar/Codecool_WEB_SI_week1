using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GameShop.Pages
{
    public class IndexModel : PageModel
    {
        private ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var email = HttpContext.Request.Query["email"];
            Console.WriteLine($"A user just subscribed email:{email}");
            
        }
    }
}
