﻿// <auto-generated />
using System;
using HimalayanTest.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HimalayanTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HimalayanTest.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HimalayanTest.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            ContactNo = "9768325172",
                            Email = "ksichigo1@gmail.com",
                            FatherName = "Kurosaki Isshin",
                            Fullname = "Kurosaki Ichigo",
                            MotherName = "Kurosaki Masaki",
                            ParentPhone = "9234156780"
                        },
                        new
                        {
                            StudentID = 2,
                            ContactNo = "9318241526",
                            Email = "mkluffy1@gmail.com",
                            FatherName = "Monkey D Dragon",
                            Fullname = "Monkey D Luffy",
                            MotherName = "Ikari Yui",
                            ParentPhone = "9123554209"
                        },
                        new
                        {
                            StudentID = 3,
                            ContactNo = "9573218652",
                            Email = "uznaruto1@gmail.com",
                            FatherName = "Minato Namikaze",
                            Fullname = "Uzumaki Naruto",
                            MotherName = "Uzumaki Kushina",
                            ParentPhone = "9123478541"
                        },
                        new
                        {
                            StudentID = 4,
                            ContactNo = "9134829101",
                            Email = "nsdragneel@gmail.com",
                            FatherName = "Igneel",
                            Fullname = "Natsu Dragneel",
                            MotherName = "Yuki Dragneel",
                            ParentPhone = "9045782309"
                        },
                        new
                        {
                            StudentID = 5,
                            ContactNo = "9589341842",
                            Email = "songoku1@gmail.com",
                            FatherName = "Bardock",
                            Fullname = "Son Goku",
                            MotherName = "Gine",
                            ParentPhone = "9876590123"
                        });
                });

            modelBuilder.Entity("HimalayanTest.Models.UserGroup", b =>
                {
                    b.Property<int>("UserGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserGroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserGroupId");

                    b.ToTable("UserGroups");

                    b.HasData(
                        new
                        {
                            UserGroupId = 1,
                            IsActive = true,
                            UserGroupCode = "SA",
                            UserGroupName = "Sebastian Vettel"
                        },
                        new
                        {
                            UserGroupId = 2,
                            IsActive = true,
                            UserGroupCode = "Adm",
                            UserGroupName = "Fernando Alonso"
                        },
                        new
                        {
                            UserGroupId = 3,
                            IsActive = true,
                            UserGroupCode = "Emp",
                            UserGroupName = "Carlos Sainz"
                        });
                });

            modelBuilder.Entity("HimalayanTest.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserGroupID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HimalayanTest.Models.UserGroup", b =>
                {
                    b.Property<int>("UserGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserGroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserGroupID");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("HimalayanTest.Models.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserGroupID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("UsersID");

                    b.HasIndex("UserGroupID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HimalayanTest.Models.Users", b =>
                {
                    b.HasOne("HimalayanTest.Models.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
