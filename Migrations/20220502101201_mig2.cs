using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6563), 1 });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6576), 3 });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6578), 2 });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 12, 1, 249, DateTimeKind.Local).AddTicks(6580), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9614), null });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9627), null });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9629), null });

            migrationBuilder.UpdateData(
                table: "Volunteer",
                keyColumn: "VolunteerId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "GroupId" },
                values: new object[] { new DateTime(2022, 5, 2, 12, 10, 3, 481, DateTimeKind.Local).AddTicks(9631), null });
        }
    }
}
