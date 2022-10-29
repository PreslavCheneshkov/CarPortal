using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class newFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
