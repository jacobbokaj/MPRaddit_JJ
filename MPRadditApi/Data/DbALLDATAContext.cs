using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MiniProjectRaddit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectRadditDatabase.Data
{
    public class DbALLDATAContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<ThreadPost> ThreadPosts => Set<ThreadPost>();
        public DbALLDATAContext(DbContextOptions<DbALLDATAContext> options)
            : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }
    }
}
