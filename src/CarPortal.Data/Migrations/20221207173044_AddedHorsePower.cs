using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class AddedHorsePower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_CarPortalUserId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CarPortalUserId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CarPortalUserId",
                table: "Offers");

            migrationBuilder.AddColumn<int>(
                name: "HorsePower",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "HorsePower",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "CarPortalUserId",
                table: "Offers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CarPortalUserId",
                table: "Offers",
                column: "CarPortalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_CarPortalUserId",
                table: "Offers",
                column: "CarPortalUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
