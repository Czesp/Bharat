using Microsoft.EntityFrameworkCore.Migrations;

namespace HimalayanTest.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "ContactNo", "Email", "FatherName", "Fullname", "MotherName", "ParentPhone" },
                values: new object[,]
                {
                    { 1, "9768325172", "ksichigo1@gmail.com", "Kurosaki Isshin", "Kurosaki Ichigo", "Kurosaki Masaki", "9234156780" },
                    { 2, "9318241526", "mkluffy1@gmail.com", "Monkey D Dragon", "Monkey D Luffy", "Ikari Yui", "9123554209" },
                    { 3, "9573218652", "uznaruto1@gmail.com", "Minato Namikaze", "Uzumaki Naruto", "Uzumaki Kushina", "9123478541" },
                    { 4, "9134829101", "nsdragneel@gmail.com", "Igneel", "Natsu Dragneel", "Yuki Dragneel", "9045782309" },
                    { 5, "9589341842", "songoku1@gmail.com", "Bardock", "Son Goku", "Gine", "9876590123" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "UserGroupId", "IsActive", "UserGroupCode", "UserGroupName" },
                values: new object[,]
                {
                    { 1, true, "SA", "Sebastian Vettel" },
                    { 2, true, "Adm", "Fernando Alonso" },
                    { 3, true, "Emp", "Carlos Sainz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "UserGroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "UserGroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "UserGroupId",
                keyValue: 3);
        }
    }
}
