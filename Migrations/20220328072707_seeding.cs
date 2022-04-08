using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedDate", "MyProperty", "Status", "Text", "Title" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 9, 27, 7, 75, DateTimeKind.Local).AddTicks(192), 0, 0, "This is post 1", "Post 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedDate", "MyProperty", "Status", "Text", "Title" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 9, 27, 7, 75, DateTimeKind.Local).AddTicks(242), 0, 0, "This is post 2", "Post 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CreatedDate", "MyProperty", "Status", "Text", "Title" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 9, 27, 7, 75, DateTimeKind.Local).AddTicks(244), 0, 0, "This is post 3", "Post 3" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Author", "CreatedDate", "Likes", "PostId", "Text" },
                values: new object[] { 1, "Alek", new DateTime(2022, 3, 28, 9, 27, 7, 75, DateTimeKind.Local).AddTicks(377), 10, 1, "This is post 1" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Author", "CreatedDate", "Likes", "PostId", "Text" },
                values: new object[] { 2, "M", new DateTime(2022, 3, 28, 9, 27, 7, 75, DateTimeKind.Local).AddTicks(381), 5, 2, "This is post 2" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Author", "CreatedDate", "Likes", "PostId", "Text" },
                values: new object[] { 3, "Peter", new DateTime(2022, 3, 28, 9, 27, 7, 75, DateTimeKind.Local).AddTicks(384), 1, 3, "This is post 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);
        }
    }
}
