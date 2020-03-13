using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetCool
{
    public class Message
    {
        public string Username { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }


        public Message(string username, string text)
        {
            Username = username;
            Text = text;
            Time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Environment.NewLine}---Message:{Text}{Environment.NewLine}Time:{Time}{Environment.NewLine}----{Environment.NewLine}";
        }
    }

}
