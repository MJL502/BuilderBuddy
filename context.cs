using Microsoft.EntityFrameworkCore;
using BuilderBuddy.Models;

public class Context : DbContext
{
    public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=ProjectData.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>().HasData(
            new Project { ProjectID = 1, ProjectName = "Lincoln's Cabin", ProjectDate = DateTime.Now }
        );
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Wall>().HasData(
           new Wall { WallID = 1, ProjectID = 1, Height = 8, Length = 24 },
           new Wall { WallID = 2, ProjectID = 1, Height = 8, Length = 16 },
           new Wall { WallID = 3, ProjectID = 1, Height = 8, Length = 24 },
           new Wall { WallID = 4, ProjectID = 1, Height = 8, Length = 16 }
       );
        base.OnModelCreating(modelBuilder);
    }

   public DbSet<Project>? Project {get;set;}
   public DbSet<Wall>? Wall { get; set; }

}