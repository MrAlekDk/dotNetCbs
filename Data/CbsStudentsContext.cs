using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using students.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace cbsStudents.Data
{
    public class CbsStudentsContext : IdentityDbContext
    {

        public CbsStudentsContext (DbContextOptions<CbsStudentsContext> options)
            : base(options)
        {
        }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments{get; set;}
        public DbSet<students.Models.Entities.Volunteer> Volunteer { get; set; }
        public DbSet<students.Models.Entities.Group> Group { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
            .HasOne(p => p.Post)
            .WithMany(b => b.Comments);
            this.SeedPosts(modelBuilder);
            this.SeedComments(modelBuilder);

            /*modelBuilder.Entity<Volunteer>()
            .HasOne(p => p.Group)
            .WithMany(b => b.Volunteers);
            this.SeedGroups(modelBuilder);
            this.SeedVolunteers(modelBuilder);
*/
            modelBuilder.Ignore <IdentityUserLogin<string>>();
            modelBuilder.Ignore <IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUser<string>>();
            modelBuilder.Entity<IdentityUserClaim<string>>().HasKey(p => new { p.Id });
        }

         public DbSet<IdentityUserClaim<string>> IdentityUserClaim { get; set; }  
        
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

        private void SeedGroups(ModelBuilder builder){
            builder.Entity<Group>().HasData(
                new Group() {GroupId=1, Name="IT-Department"},
                new Group() {GroupId=2, Name="Admin"},
                new Group() {GroupId=3, Name="Board of directors"}
            );
        }

        private void SeedVolunteers(ModelBuilder builder){
            builder.Entity<Volunteer>().HasData(
                new Volunteer() {VolunteerId=1, Name="Alexander", Age=23, StudyProgramme="Datamatiker", CreatedDate=DateTime.Now,Status=VolunteerStatus.ACCEPTED, GroupId=1 },
                new Volunteer() {VolunteerId=2, Name="Anne", Age=18, StudyProgramme="Datalogi", CreatedDate=DateTime.Now,Status= VolunteerStatus.PENDING, GroupId=3},
                new Volunteer() {VolunteerId=3, Name="Kjeld", Age=70, StudyProgramme="Software-Engineer", CreatedDate=DateTime.Now, Status=VolunteerStatus.DECLINED, GroupId=2 },
                new Volunteer() {VolunteerId=4, Name="Hanne", Age=45, StudyProgramme="Datamatiker", CreatedDate=DateTime.Now,Status=VolunteerStatus.ACCEPTED, GroupId=1 }
            );

        }

    
    }
}