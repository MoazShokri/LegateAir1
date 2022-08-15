using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegateAirLine.Migrations
{
    public partial class modifytablebag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BagWeight",
                table: "Bags",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BagWeight",
                table: "Bags");
        }
    }
}
