using Microsoft.EntityFrameworkCore.Migrations;

namespace HimalayanTest.Migrations
{
    public partial class UserGroupId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserGroupID",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserGroupID",
                table: "Users");
        }
    }
}
