using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class AddedProfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePictureAddress",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CarPortalProfileId",
                table: "Offers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarPortalProfileId1",
                table: "Offers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarPortalUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDealer = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePictureAdress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CarPortalProfileId",
                table: "Offers",
                column: "CarPortalProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CarPortalProfileId1",
                table: "Offers",
                column: "CarPortalProfileId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Profiles_CarPortalProfileId",
                table: "Offers",
                column: "CarPortalProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Profiles_CarPortalProfileId1",
                table: "Offers",
                column: "CarPortalProfileId1",
                principalTable: "Profiles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Profiles_CarPortalProfileId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Profiles_CarPortalProfileId1",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CarPortalProfileId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CarPortalProfileId1",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CarPortalProfileId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CarPortalProfileId1",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
