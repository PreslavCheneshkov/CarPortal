using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_RegionId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Offers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RegionId",
                table: "Offers",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");
        }
    }
}
