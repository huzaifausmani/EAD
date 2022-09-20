using Microsoft.EntityFrameworkCore;
using System;

public class ApplicationDbContext : DbContext {

    public DbSet<Item> Items {get;set;}
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryDetail> CategoryDetails { get; set; }
    public DbSet<Company> Companies { get; set; }

    public ApplicationDbContext()
    {
        
    }
    public ApplicationDbContext(DbContextOptions options):base(options)
    {
        //intentionally empty
    }

    // The following configures EF to create a SqlServer database file in the special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=relationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

  /*  public override int SaveChanges()
    {
        var tracker = ChangeTracker;
        foreach (var entry in tracker.Entries())
        {
            System.Console.WriteLine($"{entry.Entity} has state {entry.State}");
        }
        return base.SaveChanges();
    }*/

    public override int SaveChanges()
    {
        var tracker = ChangeTracker;
        foreach (var entry in tracker.Entries())
        {
            if (entry.Entity is FullAuditModel)
            {
                var referenceEntity = entry.Entity as Item;
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