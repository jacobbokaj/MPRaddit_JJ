using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MiniProjectRaddit.Model
{
    public class User
    {
        [Key]
        public long User_Id { get; set; }

        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

    }
}
