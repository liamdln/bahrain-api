using Microsoft.EntityFrameworkCore.Migrations;

namespace bahrain_api.Migrations
{
    public partial class AddedVisitorStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "homeVACC",
                table: "ATControllers",
                nullable: false);

            migrationBuilder.AddColumn<bool>(
                name: "visitor",
                table: "ATControllers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "homeVACC",
                table: "ATControllers");

            migrationBuilder.DropColumn(
                name: "visitor",
                table: "ATControllers");
        }
    }
}
