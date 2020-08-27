using Microsoft.EntityFrameworkCore.Migrations;

namespace bahrain_api.Migrations
{
    public partial class UpdatedParams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "ATControllers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "ATControllers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "hasSignOff",
                table: "ATControllers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "networkID",
                table: "ATControllers",
                nullable: false);

            migrationBuilder.AddColumn<bool>(
                name: "onSolo",
                table: "ATControllers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "comments",
                table: "ATControllers");

            migrationBuilder.DropColumn(
                name: "hasSignOff",
                table: "ATControllers");

            migrationBuilder.DropColumn(
                name: "networkID",
                table: "ATControllers");

            migrationBuilder.DropColumn(
                name: "onSolo",
                table: "ATControllers");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "ATControllers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
