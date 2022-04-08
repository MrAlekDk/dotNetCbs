﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cbsStudents.Data;

#nullable disable

namespace cbsStudents.Migrations
{
    [DbContext(typeof(CbsStudentsContext))]
    partial class CbsStudentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

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

                    b.ToTable("IdentityUser");
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
                            CreatedDate = new DateTime(2022, 3, 28, 11, 15, 33, 559, DateTimeKind.Local).AddTicks(7267),
                            Likes = 10,
                            PostId = 1,
                            Text = "This is post 1"
                        },
                        new
                        {
                            CommentId = 2,
                            Author = "M",
                            CreatedDate = new DateTime(2022, 3, 28, 11, 15, 33, 559, DateTimeKind.Local).AddTicks(7270),
                            Likes = 5,
                            PostId = 2,
                            Text = "This is post 2"
                        },
                        new
                        {
                            CommentId = 3,
                            Author = "Peter",
                            CreatedDate = new DateTime(2022, 3, 28, 11, 15, 33, 559, DateTimeKind.Local).AddTicks(7273),
                            Likes = 1,
                            PostId = 3,
                            Text = "This is post 3"
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
                            CreatedDate = new DateTime(2022, 3, 28, 11, 15, 33, 559, DateTimeKind.Local).AddTicks(7037),
                            MyProperty = 0,
                            Status = 0,
                            Text = "This is post 1",
                            Title = "Post 1"
                        },
                        new
                        {
                            PostId = 2,
                            CreatedDate = new DateTime(2022, 3, 28, 11, 15, 33, 559, DateTimeKind.Local).AddTicks(7084),
                            MyProperty = 0,
                            Status = 0,
                            Text = "This is post 2",
                            Title = "Post 2"
                        },
                        new
                        {
                            PostId = 3,
                            CreatedDate = new DateTime(2022, 3, 28, 11, 15, 33, 559, DateTimeKind.Local).AddTicks(7087),
                            MyProperty = 0,
                            Status = 0,
                            Text = "This is post 3",
                            Title = "Post 3"
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

            modelBuilder.Entity("students.Models.Entities.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
