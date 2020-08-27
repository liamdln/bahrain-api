using Microsoft.EntityFrameworkCore.Migrations;

namespace bahrain_api.Migrations
{
    public partial class AddedPositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "approvedPositions",
                table: "ATControllers",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "approvedPositions",
                table: "ATControllers");
        }
    }
}
