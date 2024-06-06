using HimalayanTest.Helper;
using HimalayanTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HimalayanTest.DAO
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Users> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employee { get;set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Student>().HasData(
            //        new Student { Fullname="Kurosaki Ichigo", Email="ksichigo1@gmail.com",ContactNo="9768325172", FatherName="Kurosaki Isshin", MotherName="Kurosaki Isshin", ParentPhone="9234156780"}
            //    );

            modelBuilder.Seed();
        }
    }
}
