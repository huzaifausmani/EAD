using System;
using Microsoft.EntityFrameworkCore;     //add this for DBContext

namespace fullAuditModel
{
    public class FullAuditContext: DbContext
    {
        public FullAuditContext()
        {
        }

        public FullAuditContext(DbContextOptions<FullAuditContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        
        // The following configures EF to create a SqlServer database file in the special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=FullAuditDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        
        /*
        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                System.Console.WriteLine($"{entry.Entity} has state {entry.State}");
            }
            return base.SaveChanges();
        }
        */

        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity.ToString() == "fullAuditModel.User")
                {
                    System.Console.WriteLine($"{entry.Entity} has state {entry.State}");
                    var referenceEntity = entry.Entity as User;
                    switch (entry.State)
                    {
                    case EntityState.Added:
                        referenceEntity.CreatedDate = DateTime.Now;
                        referenceEntity.CreatedByUserId = "1";//hard coded user id
                    break;
                    case EntityState.Deleted:
                    case EntityState.Modified:
                        referenceEntity.LastModifiedDate = DateTime.Now;
                        referenceEntity.LastModifiedUserId = "1";//hard coded user id
                    break;
                    default:
                    break;
                    }
                }
                else if (entry.Entity.ToString() == "fullAuditModel.Product")
                {
                    System.Console.WriteLine($"{entry.Entity} has state {entry.State}");
                    var referenceEntity = entry.Entity as Product;
                    switch (entry.State)
                    {
                    case EntityState.Added:
                        referenceEntity.CreatedDate = DateTime.Now;
                        referenceEntity.CreatedByUserId = "1";//hard coded user id
                    break;
                    case EntityState.Deleted:
                    case EntityState.Modified:
                        referenceEntity.LastModifiedDate = DateTime.Now;
                        referenceEntity.LastModifiedUserId = "1";//hard coded user id
                    break;
                    default:
                    break;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
