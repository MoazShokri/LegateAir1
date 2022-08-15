using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegateAirLine.Migrations
{
    public partial class modifydb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Travelers_TravelerCode",
                table: "Bags");

            migrationBuilder.RenameColumn(
                name: "TravelerCode",
                table: "Bags",
                newName: "TravelerId");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_TravelerCode",
                table: "Bags",
                newName: "IX_Bags_TravelerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Travelers_TravelerId",
                table: "Bags",
                column: "TravelerId",
                principalTable: "Travelers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Travelers_TravelerId",
                table: "Bags");

            migrationBuilder.RenameColumn(
                name: "TravelerId",
                table: "Bags",
                newName: "TravelerCode");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_TravelerId",
                table: "Bags",
                newName: "IX_Bags_TravelerCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Travelers_TravelerCode",
                table: "Bags",
                column: "TravelerCode",
                principalTable: "Travelers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
