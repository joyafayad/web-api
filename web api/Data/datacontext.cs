using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Data
//{
    //public class DataContext : DbContext
  //  {
       // public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{
       // }

        //public DbSet<Project> Projects { get; set; }
       // public DbSet<ProjectVersion> ProjectVersions { get; set; }

      //  protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
           // modelBuilder.Entity<Project>(b =>
            //{
               // b.HasKey(e => e.Id);
            //});

           // modelBuilder.Entity<ProjectVersion>(b =>
           // {
                //b.HasKey(e => e.Id);
           
               // b.HasOne(pv => pv.ProjectVersion)     
                    //.WithMany(p => p.Versions) 
                    //.HasForeignKey(pv => pv.ProjectId); 
            //});
       // }


        //public override int SaveChanges()
       // {
           // return base.SaveChanges();
       // }
  //  }
//}


