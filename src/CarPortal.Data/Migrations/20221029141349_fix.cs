using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Regions_RegionId",
                table: "Offers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
