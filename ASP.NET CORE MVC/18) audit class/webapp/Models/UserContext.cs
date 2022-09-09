using System;
using Microsoft.EntityFrameworkCore;     //add this for DBContext

namespace webapp.Models
{
    public class    UserContext: DbContext
    {
        public virtual DbSet<User> Users { get; set; } = null!;

        // The following configures EF to create a SqlServer database file in the special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=UserDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
    }
}
