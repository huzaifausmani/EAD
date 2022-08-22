using System;
using Microsoft.EntityFrameworkCore;     //add this for DBContext

namespace codefirstapproach
{
    public class ShoppingContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ShoppingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
    }
}
