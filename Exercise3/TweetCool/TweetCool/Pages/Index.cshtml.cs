using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TweetCool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(
        [FromForm(Name = "username")] string username,
        [FromForm(Name = "message")] string message)
        {

            List<Message> messages;

            if (FeedModel.Messages.ContainsKey(username))
            {
                messages = FeedModel.Messages[username];
            }
            else
            {
                messages = new List<Message>();
                FeedModel.Messages[username] = messages;
            }
            messages.Add(new Message(username, message));
        }
    }
}
