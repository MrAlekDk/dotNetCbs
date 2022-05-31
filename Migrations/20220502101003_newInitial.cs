using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class newInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserClaim<string>",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    VolunteerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    StudyProgramme = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.VolunteerId);
                    table.ForeignKey(
                        name: "FK_Volunteer_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Author = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Likes = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "Name" },
                values: new object[] { 1, "IT-Department" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "Name" },
                values: new object[] { 2, "Admin" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupId", "Name" },
                values: new object[] { 3, "Board of directors" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedDate", "MyProperty", "Status", "Text", "Title", "UserId" },
                values: new object[] { 1, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8308), 0, 0, "This is post 1", "Post 1", null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedDate", "MyProperty", "Status", "Text", "Title", "UserId" },
                values: new object[] { 2, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8347), 0, 0, "This is post 2", "Post 2", null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedDate", "MyProperty", "Status", "Text", "Title", "UserId" },
                values: new object[] { 3, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8351), 0, 0, "This is post 3", "Post 3", null });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "VolunteerId", "Age", "CreatedDate", "GroupId", "Name", "Status", "StudyProgramme" },
                values: new object[] { 1, 23, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9614), null, "Alexander", 2, "Datamatiker" });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "VolunteerId", "Age", "CreatedDate", "GroupId", "Name", "Status", "StudyProgramme" },
                values: new object[] { 2, 18, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9627), null, "Anne", 0, "Datalogi" });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "VolunteerId", "Age", "CreatedDate", "GroupId", "Name", "Status", "StudyProgramme" },
                values: new object[] { 3, 70, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9629), null, "Kjeld", 1, "Software-Engineer" });

            migrationBuilder.InsertData(
                table: "Volunteer",
                columns: new[] { "VolunteerId", "Age", "CreatedDate", "GroupId", "Name", "Status", "StudyProgramme" },
                values: new object[] { 4, 45, new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9631), null, "Hanne", 2, "Datamatiker" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Author", "CreatedDate", "Likes", "PostId", "Text" },
                values: new object[] { 1, "Alek", new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8477), 10, 1, "This is post 1" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Author", "CreatedDate", "Likes", "PostId", "Text" },
                values: new object[] { 2, "M", new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8482), 5, 2, "This is post 2" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Author", "CreatedDate", "Likes", "PostId", "Text" },
                values: new object[] { 3, "Peter", new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8484), 1, 3, "This is post 3" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_GroupId",
                table: "Volunteer",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "IdentityUserClaim<string>");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Volunteer");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
