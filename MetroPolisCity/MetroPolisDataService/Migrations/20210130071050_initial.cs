using Microsoft.EntityFrameworkCore.Migrations;

namespace MetroPolisDataService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "IsSingleLane",
                table: "Users",
                newName: "IsAdmin");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "IsSingleLane");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
