using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using students.Models.Entities;

namespace cbsStudents.Data
{
    public class CbsStudentsContext : DbContext
    {

        public CbsStudentsContext (DbContextOptions<CbsStudentsContext> options)
            : base(options)
        {
        }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments{get; set;}
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
            .HasOne(p => p.Post)
            .WithMany(b => b.Comments);
            this.SeedPosts(modelBuilder);
            this.SeedComments(modelBuilder);
        }

        
        
        //Methods for seeding our database with testdata
        private void SeedPosts(ModelBuilder builder){
            builder.Entity<Post>().HasData(
                new Post() {PostId=1, CreatedDate=DateTime.Now,Text="This is post 1", Title="Post 1", Status= PostStatus.DRAFT},
                new Post() {PostId=2, CreatedDate=DateTime.Now,Text="This is post 2", Title="Post 2", Status= PostStatus.DRAFT},
                new Post() {PostId=3, CreatedDate=DateTime.Now,Text="This is post 3", Title="Post 3", Status= PostStatus.DRAFT}
            );
        }

        private void SeedComments(ModelBuilder builder){
            builder.Entity<Comment>().HasData(
                new Comment() {CommentId=1, CreatedDate=DateTime.Now, Text="This is post 1", Author="Alek", Likes=10, PostId=1},
                new Comment() {CommentId=2, CreatedDate=DateTime.Now, Text="This is post 2", Author="M",Likes=5, PostId=2},
                new Comment() {CommentId=3, CreatedDate=DateTime.Now, Text="This is post 3", Author="Peter", Likes=1, PostId=3}
            );
        }
    }
}