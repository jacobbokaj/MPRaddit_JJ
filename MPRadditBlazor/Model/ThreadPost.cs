using System.ComponentModel.DataAnnotations;

namespace MiniProjectRaddit.Model
{
    public class ThreadPost 
    {
        public long ThreadPost_Id { get; set; }

        public int User_Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        /// <summary>
        /// Could be used in the future.
        /// </summary>
        public string URL { get; set; }

        public DateTime PostDateTime { get; set; }
        public int Vote { get; set; }

        public ThreadPost(int user_Id, string title,DateTime postDateTime, string text, string uRL)
        {
            User_Id = user_Id;
            Title = title; 
            PostDateTime = postDateTime;
            Text = text;
            URL = uRL;
            //ThreadPost's vote will always start at 0.
            Vote = 0;
        }
    }
}
