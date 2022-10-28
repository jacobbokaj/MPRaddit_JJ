using MiniProjectRaddit.Model;
using System.ComponentModel.DataAnnotations;

namespace MiniProjectRaddit.EditFormModel

{
    public class ThreadPostNewModel
    {
        [Required]
        public string Title { get; set; }
        

        public string Text { get; set; }
    }
}
