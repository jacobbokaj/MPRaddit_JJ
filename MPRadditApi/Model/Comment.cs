using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiniProjectRaddit.Model
{
    public class Comment 
    {
        [Key]
        public long Comment_Id { get; set; }

        /// <summary>
        /// The user who has this comment.
        /// </summary>
        public int User_Id { get; set; }

        /// <summary>
        /// What Thread this comment is on.
        /// </summary>
        public int ThreadPost_Id { get; set; }
        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime PostDateTime { get; set; }
        public int Vote { get; set; }

        public Comment(int user_Id,int threadPost_Id, string text,string uRL,DateTime postDateTime)
        {
            User_Id = user_Id;
            ThreadPost_Id = threadPost_Id;
            Text = text;
            URL = uRL;
            PostDateTime = postDateTime;
            //Comment's vote will always start at 0.
            Vote = 0;
            
        }

    }
}
