using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Cities_CityId",
                table: "Offers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
