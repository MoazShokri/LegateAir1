using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegateAirLine.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bag_Travelers_TravelerId",
                table: "Bag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bag",
                table: "Bag");

            migrationBuilder.RenameTable(
                name: "Bag",
                newName: "Bags");

            migrationBuilder.RenameIndex(
                name: "IX_Bag_TravelerId",
                table: "Bags",
                newName: "IX_Bags_TravelerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bags",
                table: "Bags",
                column: "BagId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bags",
                table: "Bags");

            migrationBuilder.RenameTable(
                name: "Bags",
                newName: "Bag");

            migrationBuilder.RenameIndex(
                name: "IX_Bags_TravelerId",
                table: "Bag",
                newName: "IX_Bag_TravelerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bag",
                table: "Bag",
                column: "BagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_Travelers_TravelerId",
                table: "Bag",
                column: "TravelerId",
                principalTable: "Travelers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
