using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TweetCool.Pages
{
    public class FeedModel : PageModel
    {
        public void OnGet()
        {

        }
        public static Dictionary<string, List<Message>> Messages = new Dictionary<string, List<Message>>();

        public Dictionary<string, List<Message>> messages { get; set; }
    }
}