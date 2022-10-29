using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class FixedRegionRelationAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
