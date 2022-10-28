using MiniProjectRaddit.Model;
using System.ComponentModel.DataAnnotations;

namespace MiniProjectRaddit.EditFormModel
{
    public class CommentModel
    {
        /// <summary>
        /// User_Id instead of User, because InputSelect "does not support the type User"
        /// </summary>
        public int User_Id { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
