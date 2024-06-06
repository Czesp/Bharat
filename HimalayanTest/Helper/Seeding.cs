using HimalayanTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanTest.Helper
{
    public static class Seeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID=1, Fullname = "Kurosaki Ichigo", Email = "ksichigo1@gmail.com", ContactNo = "9768325172", FatherName = "Kurosaki Isshin", MotherName = "Kurosaki Masaki", ParentPhone = "9234156780" },
                new Student { StudentID=2, Fullname = "Monkey D Luffy", Email = "mkluffy1@gmail.com", ContactNo = "9318241526", FatherName = "Monkey D Dragon", MotherName = "Ikari Yui", ParentPhone = "9123554209" },
                new Student { StudentID=3, Fullname = "Uzumaki Naruto", Email = "uznaruto1@gmail.com", ContactNo = "9573218652", FatherName = "Minato Namikaze", MotherName = "Uzumaki Kushina", ParentPhone = "9123478541" },
                new Student { StudentID=4, Fullname = "Natsu Dragneel", Email = "nsdragneel@gmail.com", ContactNo = "9134829101", FatherName = "Igneel", MotherName = "Yuki Dragneel", ParentPhone = "9045782309" },
                new Student { StudentID=5, Fullname = "Son Goku", Email = "songoku1@gmail.com", ContactNo = "9589341842", FatherName = "Bardock", MotherName = "Gine", ParentPhone = "9876590123" }
                );
            modelBuilder.Entity<UserGroup>().HasData(
                new UserGroup { UserGroupId=1, UserGroupName="Sebastian Vettel", UserGroupCode="SA", IsActive=true},
                new UserGroup { UserGroupId=2, UserGroupName = "Fernando Alonso", UserGroupCode="Adm", IsActive=true},
                new UserGroup { UserGroupId=3, UserGroupName = "Carlos Sainz", UserGroupCode="Emp", IsActive=true}
                );
        }
    }
}
