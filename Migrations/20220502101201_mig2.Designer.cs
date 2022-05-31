﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cbsStudents.Data;

#nullable disable

namespace cbsStudents.Migrations
{
    [DbContext(typeof(CbsStudentsContext))]
    [Migration("20220502101201_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IdentityUserClaim<string>");
                });

            modelBuilder.Entity("students.Models.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Likes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            Author = "Alek",
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5544),
                            Likes = 10,
                            PostId = 1,
                            Text = "This is post 1"
                        },
                        new
                        {
                            CommentId = 2,
                            Author = "M",
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5548),
                            Likes = 5,
                            PostId = 2,
                            Text = "This is post 2"
                        },
                        new
                        {
                            CommentId = 3,
                            Author = "Peter",
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5551),
                            Likes = 1,
                            PostId = 3,
                            Text = "This is post 3"
                        });
                });

            modelBuilder.Entity("students.Models.Entities.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GroupId");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "IT-Department"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Admin"
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Board of directors"
                        });
                });

            modelBuilder.Entity("students.Models.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MyProperty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5368),
                            MyProperty = 0,
                            Status = 0,
                            Text = "This is post 1",
                            Title = "Post 1"
                        },
                        new
                        {
                            PostId = 2,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5413),
                            MyProperty = 0,
                            Status = 0,
                            Text = "This is post 2",
                            Title = "Post 2"
                        },
                        new
                        {
                            PostId = 3,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5416),
                            MyProperty = 0,
                            Status = 0,
                            Text = "This is post 3",
                            Title = "Post 3"
                        });
                });

            modelBuilder.Entity("students.Models.Entities.Volunteer", b =>
                {
                    b.Property<int>("VolunteerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudyProgramme")
                        .HasColumnType("TEXT");

                    b.HasKey("VolunteerId");

                    b.HasIndex("GroupId");

                    b.ToTable("Volunteer");

                    b.HasData(
                        new
                        {
                            VolunteerId = 1,
                            Age = 23,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6563),
                            GroupId = 1,
                            Name = "Alexander",
                            Status = 2,
                            StudyProgramme = "Datamatiker"
                        },
                        new
                        {
                            VolunteerId = 2,
                            Age = 18,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6576),
                            GroupId = 3,
                            Name = "Anne",
                            Status = 0,
                            StudyProgramme = "Datalogi"
                        },
                        new
                        {
                            VolunteerId = 3,
                            Age = 70,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6578),
                            GroupId = 2,
                            Name = "Kjeld",
                            Status = 1,
                            StudyProgramme = "Software-Engineer"
                        },
                        new
                        {
                            VolunteerId = 4,
                            Age = 45,
                            CreatedDate = new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6580),
                            GroupId = 1,
                            Name = "Hanne",
                            Status = 2,
                            StudyProgramme = "Datamatiker"
                        });
                });

            modelBuilder.Entity("students.Models.Entities.Comment", b =>
                {
                    b.HasOne("students.Models.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("students.Models.Entities.Post", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("students.Models.Entities.Volunteer", b =>
                {
                    b.HasOne("students.Models.Entities.Group", "Group")
                        .WithMany("Volunteers")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("students.Models.Entities.Group", b =>
                {
                    b.Navigation("Volunteers");
                });

            modelBuilder.Entity("students.Models.Entities.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
