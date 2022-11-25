﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class AddedCarExtraMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Cars_CarId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Extras_CarId",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Extras");

            migrationBuilder.CreateTable(
                name: "CarsExtras",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsExtras", x => new { x.CarId, x.ExtraId });
                    table.ForeignKey(
                        name: "FK_CarsExtras_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarsExtras_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarsExtras_ExtraId",
                table: "CarsExtras",
                column: "ExtraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsExtras");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Extras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Extras_CarId",
                table: "Extras",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Cars_CarId",
                table: "Extras",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
