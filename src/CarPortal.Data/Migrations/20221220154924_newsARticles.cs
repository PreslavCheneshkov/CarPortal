using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class newsARticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "NewsArticles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "NewsArticleComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f882c707-786f-452d-8eb9-a9ec091d8ead", "AQAAAAEAACcQAAAAEM49NSsUhu+E7q0yqSR1V6FltehVx2Fr/wIVlyKm/jAjeHGnEHIMjhxrJtmvi817bg==", "e1a7950d-03fd-4c7b-94f6-bcbbd84cf605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34931a24-3dbf-4e63-a5e1-536ab030d2f0", "AQAAAAEAACcQAAAAENLi2fCaCkGFfIHV6leOF3VqLsFCRRwmplKvduQzpkQUyoz8clCyJjvatJyUM+0/gQ==", "1812136b-a3a1-46d8-856b-2a4449db7863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96d6566e-5e68-43fe-a360-0f8f5dcb9f61", "AQAAAAEAACcQAAAAEB1Y4TP05TE3Ms5bvSaHLc7X6sntDUwxsxkcEdEKzDpqE3DgJj1BgBnnJFLz5tN8SA==", "1f731248-9a2c-4da0-b28e-84d492f8c46f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "113b50fc-9f3a-403f-8db5-5a5ed8064d83", "AQAAAAEAACcQAAAAED1wM8MD/mYTwbjYR9vy0ppJUKvLKpxA5BMgq4OFgV3M8SOmjb717OV7T9T6XXArzA==", "76c9f7ee-cff5-4269-bc52-b5aebfe3b854" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3985.0, 204, 12, 20091, 45, 3, 1, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2595.0, 3, 281, 16, 34603, 62, 4, 4, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1101.0, 2, 263, 4, 168105, 13, 5, 3, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3637.0, 5, 436, 4, 252101, 14, 1, 2, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3820.0, 5, 445, 6, 250722, 22, 3, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2078.0, 480, 6, 112579, 21, 6, 3, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2417.0, 5, 235, 8, 408799, 29, 6, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2014.0, 2, 165, 12, 324700, 47, 1, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 3987.0, 1, 187, 4, 347880, 13, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2153.0, 1, 162, 11, 424318, 43, 3, 4, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2374.0, 6, 450, 4, 463197, 13, 6, 3, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1834.0, 6, 377, 17, 226529, 66, 3, 3, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3247.0, 4, 425, 5, 497029, 17, 6, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3210.0, 4, 331, 1, 488183, 1, 5, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 7, 2441.0, 5, 302, 13, 439436, 49, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 5, 3327.0, 5, 145, 5, 253807, 17, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1996.0, 6, 486, 15, 495669, 58, 3, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2988.0, 264, 11, 356877, 43, 4, 3, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1263.0, 166, 19, 264846, 73, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1114.0, 4, 172, 404802, 25, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 3, 2888.0, 6, 450, 14, 396098, 54, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2252.0, 3, 388, 4, 97761, 13, 3, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2190.0, 474, 16, 22201, 62, 5, 2, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1640.0, 3, 68, 1, 497161, 3, 6, 5, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3023.0, 290, 7, 431952, 27, 6, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 1571.0, 6, 409, 12, 176924, 46, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1724.0, 2, 361, 2, 274808, 6, 6, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 7, 1431.0, 6, 415, 14, 107546, 55, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2730.0, 365, 10, 490426, 37, 3, 3, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3400.0, 3, 257, 5, 35846, 17, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1577.0, 6, 254, 4, 217224, 13, 4, 6, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3067.0, 120, 12, 74414, 45, 6, 3, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2207.0, 3, 178, 18, 169431, 70, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 1, 2021.0, 6, 454, 8, 489303, 29, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1050.0, 3, 91, 3, 330407, 10, 3, 5, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2576.0, 4, 132, 10, 187319, 39, 3, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3636.0, 222, 45337, 43, 2, 1, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 2430.0, 4, 96, 8, 131243, 31, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1746.0, 5, 378, 3, 311506, 11, 6, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3706.0, 1, 176, 14, 398319, 54, 3, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2668.0, 120, 10, 325491, 39, 5, 5, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1428.0, 4, 442, 11, 136537, 41, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2328.0, 3, 130, 18, 422506, 71, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1411.0, 6, 334, 7, 228855, 27, 1, 3, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3635.0, 5, 337, 61436, 65, 3, 3, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3278.0, 5, 195, 5, 128402, 18, 6, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 2034.0, 1, 334, 430566, 21, 1, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1433.0, 2, 308, 16, 81938, 62, 1, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId" },
                values: new object[] { 2, 3121.0, 2, 350, 14, 355728, 53, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3748.0, 5, 480, 6, 177677, 23, 1, 2, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2235.0, 5, 180, 7, 375186, 26, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2581.0, 4, 84, 5, 339503, 19, 2, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3028.0, 2, 129, 14, 401704, 55, 3, 1, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 3138.0, 2, 460, 15, 477845, 57, 1, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3356.0, 3, 151, 10, 148213, 38, 4, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1888.0, 4, 157, 2, 150067, 7, 5, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3186.0, 5, 60, 19, 243579, 74, 5, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2960.0, 453, 8, 417189, 31, 6, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2808.0, 2, 75, 4, 470265, 15, 1, 2, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2433.0, 4, 115, 11, 232637, 41, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3447.0, 1, 299, 7, 256961, 25, 5, 5, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3998.0, 3, 443, 12, 41497, 45, 6, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3335.0, 2, 400, 3, 232745, 11, 6, 4, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1075.0, 5, 176, 19, 71869, 74, 5, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 2657.0, 5, 136, 13, 230263, 49, 5, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3803.0, 243, 5, 463238, 19, 3, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2329.0, 3, 113, 12, 79751, 47, 5, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3311.0, 361, 4, 93260, 13, 3, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3174.0, 1, 396, 29760, 57, 3, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2661.0, 151, 156491, 5, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3658.0, 1, 92, 4, 359241, 15, 4, 1, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1424.0, 5, 496, 18, 251007, 69, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 3, 3396.0, 5, 284, 12, 341377, 45, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1342.0, 6, 336, 5, 497957, 19, 6, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 2, 2706.0, 1, 440, 5, 33102, 18, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1342.0, 6, 165, 7, 109262, 25, 2, 2, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1463.0, 4, 114, 1, 394459, 2, 4, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3153.0, 6, 454, 2, 166014, 5, 4, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1306.0, 4, 69, 14, 219737, 55, 6, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3312.0, 3, 224, 17, 367178, 65, 1, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2577.0, 5, 482, 18, 277265, 71, 6, 1, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1387.0, 95, 17, 263831, 66, 5, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 1531.0, 3, 110, 13, 173559, 50, 2, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3943.0, 2, 478, 7, 46607, 26, 1, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2703.0, 1, 94, 17, 126683, 67, 4, 3, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3603.0, 4, 367, 16, 329026, 63, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1064.0, 1, 340, 6, 165417, 22, 4, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId" },
                values: new object[] { 7, 2501.0, 1, 19, 327485, 75, 4 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2050.0, 1, 488, 18, 437858, 70, 4, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3341.0, 4, 280, 15, 324543, 57, 5, 4, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2696.0, 2, 354, 5, 482876, 17, 4, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2860.0, 3, 264, 5, 92005, 17, 5, 6, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3331.0, 1, 132, 10, 121139, 38, 6, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2477.0, 2, 201, 17, 268671, 67, 1, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3816.0, 5, 279, 8, 273769, 30, 6, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3588.0, 1, 382, 1, 248976, 3, 6, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3220.0, 5, 240, 19, 219779, 75, 2, 5, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2324.0, 457, 2, 160203, 5, 5, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3223.0, 4, 329, 10, 289451, 39, 4, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2494.0, 2, 207, 19, 309052, 75, 3, 3, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3830.0, 147, 339410, 1, 3, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1751.0, 6, 294, 14, 469351, 53, 4, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1104.0, 82, 17, 276635, 67, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1947.0, 2, 423, 1, 138553, 3, 4, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3047.0, 330, 14, 242599, 53, 2, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1741.0, 4, 205, 6, 450814, 22, 1, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2718.0, 2, 286, 13, 269967, 50, 4, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1388.0, 2, 380, 9, 498667, 33, 1, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3860.0, 491, 14, 401276, 54, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3112.0, 1, 239, 15, 499956, 58, 2, 5, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2952.0, 3, 399, 6, 423733, 21, 5, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2518.0, 1, 111, 7, 166241, 25, 4, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3747.0, 416, 1, 443619, 1, 4, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2625.0, 5, 374, 13, 465185, 49, 3, 6, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2915.0, 3, 315, 1, 37211, 1, 2, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2947.0, 1, 181, 7, 166459, 27, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2869.0, 1, 464, 9, 145722, 33, 3, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3070.0, 6, 446, 2, 388023, 6, 6, 5, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2340.0, 5, 364, 11, 168812, 41, 5, 6, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3175.0, 4, 149, 12, 295900, 45, 5, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 5, 3711.0, 4, 498, 3, 254966, 11, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1919.0, 3, 66, 4, 235728, 14, 2, 5, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2862.0, 223, 16, 455223, 63, 3, 2, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1025.0, 5, 379, 3, 246676, 10, 1, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1363.0, 1, 262, 5, 230245, 17, 5, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2837.0, 367, 6, 443074, 23, 3, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3301.0, 5, 297, 17, 304633, 66, 3, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3210.0, 2, 238, 2, 105723, 6, 3, 4, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2442.0, 3, 171, 8, 86586, 29, 4, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 1, 2641.0, 3, 203, 7, 69231, 26, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1766.0, 6, 297, 7, 495574, 27, 4, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 1727.0, 4, 202, 16, 252761, 61, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2294.0, 5, 425, 7, 41254, 27, 5, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1880.0, 193, 12, 239838, 46, 5, 6, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2785.0, 127, 8, 139637, 29, 6, 2, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2231.0, 424, 10, 31449, 38, 2, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1458.0, 3, 64, 8, 472582, 30, 3, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2137.0, 328, 1, 296920, 1, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2234.0, 4, 455, 17, 394668, 67, 6, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1097.0, 205, 19, 426358, 75, 2, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3276.0, 1, 285, 11, 113041, 42, 1, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2421.0, 6, 407, 3, 282525, 10, 3, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2521.0, 453, 16, 188143, 62, 6, 2, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1605.0, 405, 18, 225068, 70, 1, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3336.0, 5, 95, 16, 276274, 61, 3, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3884.0, 4, 159, 19, 414178, 74, 6, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1957.0, 335, 18, 156529, 69, 6, 2, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1954.0, 3, 451, 8, 180536, 29, 6, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3855.0, 2, 154, 6, 86021, 22, 3, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2520.0, 6, 227, 11, 465675, 43, 1, 1, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3715.0, 1, 431, 5, 164436, 19, 3, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1440.0, 4, 197, 15, 110151, 58, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 1161.0, 466, 15, 456625, 57, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3977.0, 1, 436, 1, 398615, 3, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3032.0, 2, 164, 17, 164212, 67, 2, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1886.0, 2, 255, 12, 61296, 47, 3, 4, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1376.0, 4, 118, 19, 201503, 73, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2830.0, 5, 409, 19, 286095, 74, 3, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1751.0, 2, 387, 3, 221450, 9, 6, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2539.0, 4, 200, 17, 127882, 67, 3, 3, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3251.0, 6, 457, 7, 38129, 26, 2, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2054.0, 2, 189, 11, 115693, 43, 4, 5, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2054.0, 4, 418, 377598, 74, 2, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2391.0, 2, 448, 12, 95111, 46, 2, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3162.0, 6, 259, 11, 186080, 41, 4, 2, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1929.0, 3, 271, 6, 360635, 23, 6, 3, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 1223.0, 3, 289, 14, 418233, 54, 3, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3716.0, 6, 445, 6, 488995, 22, 4, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2609.0, 5, 149, 3, 354762, 9, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1430.0, 2, 364, 14, 319661, 55, 1, 4, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1400.0, 2, 330, 1, 280251, 1, 5, 2, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2418.0, 2, 102, 13, 248130, 49, 6, 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1395.0, 5, 466, 17, 72655, 65, 1, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "Year" },
                values: new object[] { 7, 2749.0, 440, 404666, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3482.0, 269, 16, 198884, 63, 2, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2453.0, 2, 91, 19, 62865, 75, 3, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1704.0, 335, 18, 90952, 71, 6, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2496.0, 5, 279, 9, 275202, 33, 4, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2165.0, 4, 288, 3, 459721, 10, 3, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2124.0, 4, 312, 16, 191839, 61, 4, 4, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2008.0, 1, 96, 1, 205538, 2, 4, 4, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1889.0, 3, 286, 11, 35539, 43, 5, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1363.0, 6, 429, 16, 193071, 61, 2, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1449.0, 5, 358, 16, 398346, 62, 4, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 3223.0, 3, 360, 4, 324130, 14, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3978.0, 5, 465, 13, 60177, 50, 5, 6, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3470.0, 3, 456, 10, 284347, 39, 2, 3, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2086.0, 1, 355, 7, 287312, 25, 4, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2046.0, 3, 68, 1, 250926, 3, 1, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1257.0, 1, 225, 9, 177251, 33, 4, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2332.0, 5, 397, 8, 322350, 31, 2, 6, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3310.0, 6, 442, 17, 413463, 67, 2, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3831.0, 6, 84, 5, 387348, 18, 2, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1086.0, 189, 3, 354568, 10, 1, 5, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1229.0, 6, 241, 10, 354793, 38, 1, 5, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3590.0, 2, 158, 1, 107578, 2, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2495.0, 2, 415, 1, 177548, 3, 3, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2099.0, 1, 126, 14, 200151, 54, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1160.0, 3, 211, 8, 43655, 29, 1, 2, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1191.0, 1, 239, 8, 278971, 31, 1, 6, 2002 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(130), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(131), 22995m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(139), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(140), 14729m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(142), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(142), 4738m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(144), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(145), 1965m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(147), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(147), 3576m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(150), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(151), 16486m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(152), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(152), 1761m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(182), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(182), 14640m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(184), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(185), 25326m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(187), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(187), 20721m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(189), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(189), 21463m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(191), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(191), 4748m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(193), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(193), 33291m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(195), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(195), 38250m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(197), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(197), 36237m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(199), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(200), 28874m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(201), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(202), 25787m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(204), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(204), 29545m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(206), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(206), 15095m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(208), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(208), 31345m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(210), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(210), 25474m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(212), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(212), 30354m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(213), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(214), 21646m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(215), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(216), 16342m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(217), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(217), 1444m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(219), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(219), 32207m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(221), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(221), 2603m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(223), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(223), 26389m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(225), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(225), 26871m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(227), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(227), 32408m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(229), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(229), 39957m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(231), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(231), 12194m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(233), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(233), 11579m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(259), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(260), 6437m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(261), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(262), 38772m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(263), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(264), 2497m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(265), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(266), 11593m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(267), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(268), 39160m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(269), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(269), 38160m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(271), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(272), 36455m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(273), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(274), 31441m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(275), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(276), 38526m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(277), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(278), 10378m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(279), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(279), 19567m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(281), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(281), 35529m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(283), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(283), 9503m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(284), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(285), 38975m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(287), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(287), 3274m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(289), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(289), 25351m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(291), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(291), 5655m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(293), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(293), 4530m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(294), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(295), 13732m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(297), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(297), 38923m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(299), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(299), 24308m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(301), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(301), 4000m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(303), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(303), 25125m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(305), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(305), 24897m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(307), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(307), 26471m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(308), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(309), 18138m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(310), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(311), 13280m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(313), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(313), 1175m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(314), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(315), 1670m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(340), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(341), 22851m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(342), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(343), 38070m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(344), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(345), 6675m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(348), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(348), 4560m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(350), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(350), 35400m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(352), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(352), 16500m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(354), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(355), 7874m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(356), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(356), 8034m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(358), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(358), 17653m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(360), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(360), 36565m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(362), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(363), 32702m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(364), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(365), 23804m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(366), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(366), 13006m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(368), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(368), 30299m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(370), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(370), 29117m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(372), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(372), 10296m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(374), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(374), 5237m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(376), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(376), 33063m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(378), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(378), 23607m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(380), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(380), 29732m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(382), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(382), 6782m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(384), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(384), 31559m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(386), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(386), 21089m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(387), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(388), 4779m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(389), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(390), 3665m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(436), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(436), 38565m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(438), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(438), 10281m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(441), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(441), 15693m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(443), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(443), 5333m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(445), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(445), 9258m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(447), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(448), 14571m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(449), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(450), 28533m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(451), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(451), 16599m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(453), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(453), 6412m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(455), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(455), 32252m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(456), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(457), 6263m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(458), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(459), 25445m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(460), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(461), 30773m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(462), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(463), 10858m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(464), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(464), 38192m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(466), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(466), 10634m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(468), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(468), 3039m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(470), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(470), 31747m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(472), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(472), 37231m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(474), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(474), 34178m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(476), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(476), 6131m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(477), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(478), 11309m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(480), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(480), 2622m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(482), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(482), 1848m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(483), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(484), 10163m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(485), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(485), 7612m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(487), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(487), 35001m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(489), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(489), 1622m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(490), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(491), 11100m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(516), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(516), 5914m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(518), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(518), 19899m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(520), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(520), 28740m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(522), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(522), 34213m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(524), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(524), 17857m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(525), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(526), 33725m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(527), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(528), 39135m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(529), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(530), 8200m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(531), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(531), 12234m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(533), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(533), 36092m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(535), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(535), 17836m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(537), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(537), 34986m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(538), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(539), 26128m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(542), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(542), 9968m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(544), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(544), 13138m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(546), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(546), 7416m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(548), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(548), 4234m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(550), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(550), 27997m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(551), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(552), 39383m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(553), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(553), 28789m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(555), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(555), 36548m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(580), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(580), 3966m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(582), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(582), 7198m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(584), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(584), 8570m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(585), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(586), 12144m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(587), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(588), 2113m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(589), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(589), 14505m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(591), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(591), 7218m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(593), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(593), 1059m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(594), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(595), 917m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(596), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(597), 32433m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(598), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(599), 11950m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(600), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(600), 8604m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(602), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(602), 29124m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(604), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(604), 8955m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(606), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(606), 34658m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(608), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(608), 9466m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(610), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(610), 18647m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(612), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(612), 7126m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(613), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(614), 39785m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(615), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(615), 25974m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(617), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(617), 3736m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(618), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(619), 38010m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(620), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(621), 646m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(622), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(623), 35784m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(624), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(625), 35387m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(626), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(626), 32857m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(629), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(629), 12415m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(631), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(631), 16533m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(657), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(657), 5532m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(659), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(660), 13846m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(661), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(662), 9080m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(663), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(664), 5490m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(665), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(666), 4067m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(667), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(667), 24400m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(669), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(669), 17734m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(671), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(671), 20389m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(673), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(673), 11625m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(675), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(675), 38969m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(677), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(677), 34702m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(679), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(679), 9510m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(681), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(681), 2446m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(683), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(683), 8018m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(685), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(685), 10324m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(686), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(687), 36155m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(688), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(689), 17636m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(690), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(691), 19388m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(692), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(692), 31754m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(694), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(694), 33752m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(696), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(696), 19377m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(698), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(698), 36686m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(700), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(700), 34219m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(702), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(702), 28491m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(703), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(704), 25231m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(705), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(706), 29466m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(707), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(707), 8029m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(709), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(709), 32255m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(711), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(712), 17353m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(737), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(737), 24525m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(739), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(739), 19666m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(741), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(741), 1862m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(742), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(743), 3859m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(744), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(744), 18700m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(746), new DateTime(2022, 12, 20, 15, 49, 23, 702, DateTimeKind.Utc).AddTicks(746), 24872m });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 49, 23, 699, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 49, 23, 699, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 49, 23, 699, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 49, 23, 699, DateTimeKind.Utc).AddTicks(9243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "NewsArticles");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "NewsArticleComments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac293375-5c89-42d5-ab5a-d0ac337805fb", "AQAAAAEAACcQAAAAEM01/OI0M5HMkRV/YRz5sPp9x8YXc6ksrcu527JeXsTpjtM7h0NYgtxxlb8I13QN/A==", "550f99dc-373a-4f2c-b797-24e80ea1663c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82e014d6-14b1-413d-96ee-4091cf56f02e", "AQAAAAEAACcQAAAAENSTpijXDSoMzjfEW7M1RePrSXQ2rI4siL/P7EegByAr6FF/dy+9XpeImLBz47jdlA==", "ec7b7d41-403a-4aea-976b-14b549806889" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e4e2a48-0eb3-49f1-9bd8-96962812adb4", "AQAAAAEAACcQAAAAEGEygw7vvYikXs2Y6Y+fVRsfIg2H4loe9TRjZvq0mReLpKkwcVFULQEJURS81OpOUA==", "64976d79-2329-4be6-aa08-f417570b7431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd98c6e-0ceb-4255-8467-14a4d49c8bdd", "AQAAAAEAACcQAAAAEH+Zo9L1qEh76YMSqNJJaL13ITfW7bMVVwwtliS0ehSKfNMhh8RTmXE1j+Lfhag++w==", "6cc8685f-6d78-4275-b10b-226c92260235" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3319.0, 456, 5, 158835, 18, 2, 2, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3338.0, 5, 367, 3, 201184, 9, 2, 5, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2489.0, 6, 437, 17, 485756, 65, 3, 1, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3926.0, 3, 457, 19, 402875, 75, 2, 3, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1286.0, 3, 201, 4, 392937, 13, 6, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1887.0, 314, 11, 276946, 42, 5, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2033.0, 2, 406, 18, 254860, 69, 5, 1, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1583.0, 6, 495, 16, 218659, 63, 2, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 3321.0, 2, 413, 10, 343097, 37, 4, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1070.0, 4, 296, 8, 322774, 31, 1, 5, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3598.0, 4, 390, 6, 324706, 22, 3, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3506.0, 3, 230, 16, 465892, 63, 5, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1575.0, 1, 192, 3, 249355, 9, 2, 4, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1940.0, 2, 157, 18, 370089, 71, 2, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 5, 3763.0, 6, 450, 12, 204096, 46, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 7, 3921.0, 1, 188, 14, 242771, 55, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2236.0, 2, 228, 2, 228824, 6, 4, 1, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1045.0, 270, 3, 386799, 9, 3, 6, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1287.0, 291, 5, 350210, 18, 1, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1294.0, 6, 445, 249594, 27, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 5, 1617.0, 3, 403, 10, 484675, 37, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2017.0, 6, 142, 5, 112411, 17, 4, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3259.0, 344, 6, 113429, 23, 3, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2726.0, 1, 231, 10, 278071, 39, 2, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3572.0, 410, 1, 130552, 1, 1, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2325.0, 5, 210, 6, 180799, 23, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 3573.0, 1, 147, 8, 213197, 31, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 8, 1253.0, 5, 267, 13, 336074, 49, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3251.0, 201, 17, 58774, 67, 1, 4, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 1115.0, 5, 264, 19, 45726, 73, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1586.0, 5, 79, 1, 404447, 1, 5, 1, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2034.0, 63, 11, 227111, 43, 5, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1806.0, 5, 161, 4, 263961, 14, 6, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 2, 2312.0, 2, 254, 1, 204705, 1, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1070.0, 2, 464, 12, 170942, 45, 6, 1, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2563.0, 6, 145, 14, 183299, 53, 6, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1545.0, 172, 371360, 41, 6, 2, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 3893.0, 5, 440, 6, 22700, 21, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2559.0, 4, 245, 11, 265676, 43, 5, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3537.0, 6, 138, 12, 166537, 45, 6, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3310.0, 454, 5, 469878, 19, 4, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 1240.0, 3, 491, 9, 378121, 35, 4, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3904.0, 1, 460, 3, 72686, 11, 5, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2536.0, 2, 379, 9, 294425, 33, 6, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2549.0, 2, 273, 154484, 66, 1, 4, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1280.0, 4, 437, 2, 126522, 6, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 1563.0, 4, 220, 416480, 23, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2648.0, 4, 162, 8, 349841, 29, 3, 4, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId" },
                values: new object[] { 8, 1837.0, 6, 212, 13, 433903, 51, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1306.0, 1, 257, 12, 57003, 46, 6, 6, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1049.0, 3, 62, 8, 422628, 29, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 3358.0, 6, 165, 10, 473271, 37, 6, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1565.0, 5, 333, 6, 415460, 23, 6, 4, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 3354.0, 5, 150, 12, 103909, 47, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2522.0, 5, 387, 18, 176831, 71, 3, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3427.0, 2, 385, 3, 219806, 11, 6, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2125.0, 3, 173, 11, 499968, 43, 3, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1342.0, 435, 5, 326376, 18, 3, 2, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2015.0, 3, 91, 18, 103967, 71, 3, 6, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1386.0, 6, 175, 14, 119834, 54, 6, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2735.0, 6, 289, 1, 275221, 3, 4, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2655.0, 6, 250, 14, 278328, 54, 5, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2038.0, 5, 249, 8, 325464, 30, 4, 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1088.0, 2, 447, 5, 302866, 18, 2, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2130.0, 3, 460, 4, 160624, 14, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3076.0, 267, 19, 393522, 73, 6, 3, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1235.0, 1, 225, 3, 443422, 9, 1, 6, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2267.0, 235, 19, 229727, 75, 4, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2499.0, 3, 101, 199237, 58, 4, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1590.0, 496, 85451, 6, 1, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2251.0, 2, 128, 5, 196047, 18, 2, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2429.0, 2, 147, 10, 481536, 39, 1, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 5, 2957.0, 2, 492, 2, 358953, 7, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1666.0, 2, 212, 19, 181938, 75, 1, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 1, 1821.0, 4, 395, 2, 209697, 5, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3490.0, 4, 286, 9, 191901, 33, 5, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1336.0, 1, 214, 10, 305990, 39, 1, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2461.0, 3, 390, 10, 82470, 39, 5, 4, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2178.0, 5, 131, 9, 453044, 33, 2, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3412.0, 2, 251, 8, 204186, 30, 5, 6, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1111.0, 1, 153, 10, 103305, 39, 5, 6, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1535.0, 286, 1, 341027, 3, 3, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3464.0, 6, 344, 9, 176412, 33, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2504.0, 3, 291, 4, 337660, 14, 2, 3, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2343.0, 5, 330, 19, 61160, 74, 1, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3106.0, 5, 283, 10, 481151, 39, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3145.0, 4, 491, 15, 494022, 57, 6, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId" },
                values: new object[] { 4, 2837.0, 6, 12, 234760, 47, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2824.0, 3, 448, 16, 219280, 62, 1, 5, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3159.0, 3, 244, 4, 72067, 15, 3, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2880.0, 3, 226, 8, 271768, 31, 1, 3, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1246.0, 1, 450, 7, 189407, 25, 2, 1, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1759.0, 5, 306, 15, 157611, 58, 3, 4, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3109.0, 4, 437, 7, 150540, 25, 2, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3152.0, 1, 129, 17, 254945, 66, 5, 1, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3707.0, 5, 459, 18, 321775, 69, 4, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2805.0, 3, 227, 4, 264848, 14, 5, 3, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3673.0, 146, 9, 445449, 33, 4, 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3791.0, 3, 184, 12, 55068, 45, 3, 5, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3342.0, 3, 319, 12, 265576, 47, 4, 1, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3084.0, 469, 205271, 4, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1904.0, 5, 437, 2, 398267, 7, 5, 4, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3608.0, 385, 19, 351568, 74, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1637.0, 4, 271, 2, 233988, 5, 6, 6, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1776.0, 115, 19, 123787, 73, 4, 6, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1680.0, 1, 389, 12, 402099, 46, 2, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2688.0, 1, 495, 4, 320570, 15, 3, 2, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 2608.0, 6, 336, 10, 122000, 38, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2112.0, 473, 5, 398813, 19, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3584.0, 6, 269, 5, 177061, 17, 1, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2126.0, 6, 179, 12, 225405, 45, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2591.0, 2, 245, 19, 195306, 75, 2, 6, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2205.0, 401, 4, 444921, 13, 3, 5, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1219.0, 4, 471, 12, 409161, 45, 6, 4, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2456.0, 1, 161, 6, 164883, 22, 6, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1164.0, 4, 167, 17, 405323, 66, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1152.0, 5, 271, 16, 457408, 62, 2, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3437.0, 4, 222, 6, 181947, 23, 1, 6, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1693.0, 4, 447, 19, 444871, 73, 6, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1462.0, 3, 484, 4, 103391, 14, 4, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 2, 1978.0, 3, 466, 14, 416957, 54, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2099.0, 5, 255, 18, 366452, 70, 4, 6, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1275.0, 169, 1, 263439, 3, 5, 3, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1858.0, 1, 336, 5, 485389, 17, 6, 5, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1444.0, 5, 309, 18, 329515, 69, 2, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3233.0, 454, 4, 421771, 14, 4, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2250.0, 3, 258, 12, 291222, 46, 4, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2902.0, 5, 309, 19, 299903, 73, 4, 6, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2662.0, 2, 364, 10, 263355, 39, 1, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 2, 2986.0, 4, 97, 13, 192166, 51, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1514.0, 2, 126, 5, 394166, 19, 6, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 1730.0, 2, 470, 2, 462054, 6, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1371.0, 4, 171, 9, 363896, 34, 4, 3, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1034.0, 114, 9, 59436, 34, 4, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3889.0, 360, 13, 207098, 51, 3, 5, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1676.0, 121, 7, 178307, 26, 3, 1, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1006.0, 6, 279, 12, 313324, 47, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1264.0, 490, 3, 217606, 11, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2202.0, 6, 397, 19, 166158, 75, 4, 2, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3657.0, 241, 15, 176865, 58, 3, 1, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1077.0, 3, 387, 19, 467931, 74, 6, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2606.0, 3, 293, 8, 485819, 29, 5, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1429.0, 94, 4, 281632, 14, 3, 6, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3833.0, 491, 9, 491607, 34, 2, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3781.0, 3, 452, 19, 132951, 74, 5, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1648.0, 3, 355, 9, 158967, 34, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2252.0, 303, 5, 351190, 19, 4, 5, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2865.0, 4, 189, 10, 96555, 37, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3619.0, 6, 228, 8, 215718, 31, 2, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1703.0, 2, 279, 14, 483661, 54, 3, 3, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3755.0, 3, 178, 7, 233821, 25, 6, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3550.0, 6, 104, 5, 219614, 17, 3, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 3805.0, 332, 6, 163438, 21, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 1804.0, 2, 410, 2, 398431, 5, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1090.0, 3, 404, 1, 399656, 3, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1446.0, 5, 237, 19, 305277, 73, 1, 5, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1704.0, 2, 317, 17, 282935, 65, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2039.0, 2, 499, 10, 156474, 38, 2, 1, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3163.0, 5, 371, 19, 40553, 74, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2132.0, 6, 205, 7, 265063, 26, 1, 2, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1613.0, 4, 448, 12, 93371, 46, 6, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3975.0, 6, 230, 8, 57704, 31, 2, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3026.0, 5, 140, 449422, 75, 1, 3, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 1346.0, 4, 353, 10, 361818, 39, 5, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3027.0, 1, 308, 8, 481016, 30, 1, 5, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3667.0, 2, 195, 17, 254927, 66, 2, 6, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 2778.0, 6, 364, 5, 319503, 18, 2, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3817.0, 4, 304, 15, 24800, 59, 3, 1, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1314.0, 1, 487, 11, 218730, 43, 4, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2427.0, 6, 121, 8, 437540, 30, 3, 5, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2467.0, 6, 289, 4, 80898, 13, 1, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1050.0, 6, 205, 16, 262021, 63, 5, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3481.0, 2, 198, 4, 74256, 13, 5, 3, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "Year" },
                values: new object[] { 4, 3101.0, 136, 175523, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2119.0, 260, 15, 90896, 58, 3, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1004.0, 5, 145, 2, 499942, 5, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1308.0, 113, 6, 338021, 23, 1, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3475.0, 2, 234, 7, 133745, 25, 1, 2, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2256.0, 1, 304, 18, 107500, 71, 4, 5, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1858.0, 6, 428, 15, 54381, 59, 6, 5, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2433.0, 6, 165, 12, 149601, 45, 3, 6, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1113.0, 5, 345, 10, 302691, 38, 4, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2166.0, 4, 149, 17, 322515, 65, 4, 3, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3116.0, 1, 168, 14, 65973, 53, 2, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 3205.0, 1, 367, 11, 262230, 41, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1866.0, 6, 104, 17, 43270, 66, 2, 2, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2679.0, 2, 421, 13, 349092, 50, 3, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2519.0, 4, 135, 4, 447925, 15, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3768.0, 5, 213, 4, 113149, 14, 2, 1, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2810.0, 4, 263, 6, 292975, 23, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3657.0, 6, 213, 6, 462994, 22, 5, 3, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1115.0, 1, 86, 7, 460920, 26, 1, 4, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2192.0, 5, 265, 1, 65288, 2, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2606.0, 429, 13, 252296, 49, 6, 2, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3481.0, 3, 247, 16, 415326, 63, 5, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2682.0, 6, 360, 19, 469993, 75, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1460.0, 5, 392, 6, 410858, 21, 5, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1596.0, 5, 434, 10, 123832, 39, 4, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2647.0, 1, 466, 2, 93997, 7, 2, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3778.0, 4, 311, 6, 249514, 21, 2, 5, 2018 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2389), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2390), 25842m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2400), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2400), 33228m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2403), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2404), 31087m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2406), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2406), 13267m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2408), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2409), 14624m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2412), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2412), 16033m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2414), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2414), 5569m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2416), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2417), 37048m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2418), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2419), 5326m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2421), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2422), 20051m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2424), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2424), 19691m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2426), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2426), 31489m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2428), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2428), 15400m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2430), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2431), 1476m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2433), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2433), 18878m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2435), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2435), 31427m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2437), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2438), 25130m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2440), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2440), 19538m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2442), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2443), 23035m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2445), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2445), 25260m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2447), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2447), 30043m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2449), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2449), 24471m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2504), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2504), 4157m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2506), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2506), 36487m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2507), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2508), 30651m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2510), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2510), 21493m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2512), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2512), 3861m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2514), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2514), 3389m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2515), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2516), 36753m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2517), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2518), 36676m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2519), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2520), 15184m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2521), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2521), 22012m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2523), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2523), 38672m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2526), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2526), 6745m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2528), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2528), 18002m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2530), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2530), 10164m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2532), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2532), 32752m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2534), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2534), 28707m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2536), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2536), 1674m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2538), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2538), 29242m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2540), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2540), 1611m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2542), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2543), 33451m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2544), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2544), 8228m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2546), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2546), 21992m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2548), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2548), 5918m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2550), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2550), 31837m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2551), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2552), 25731m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2553), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2553), 2928m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2555), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2555), 16133m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2581), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2581), 8992m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2583), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2583), 8681m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2584), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2585), 17863m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2586), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2586), 31179m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2588), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2588), 1212m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2590), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2590), 5946m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2591), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2592), 28859m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2593), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2594), 3246m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2596), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2596), 1106m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2597), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2598), 21880m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2599), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2600), 3391m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2601), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2601), 9868m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2603), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2603), 9986m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2605), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2605), 6188m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2607), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2607), 1819m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2609), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2609), 20600m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2612), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2612), 19745m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2613), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2614), 3294m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2615), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2615), 3455m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2617), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2617), 35487m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2619), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2620), 3631m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2621), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2621), 31216m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2623), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2623), 1261m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2625), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2625), 27312m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2627), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2627), 27661m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2629), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2629), 6536m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2654), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2655), 736m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2656), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2657), 36980m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2658), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2659), 14414m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2661), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2661), 33758m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2662), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2663), 13680m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2664), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2665), 23361m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2666), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2667), 4090m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2668), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2669), 32100m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2671), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2671), 21862m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2673), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2673), 17153m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2675), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2675), 27170m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2676), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2677), 38347m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2678), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2678), 11657m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2680), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2680), 19007m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2682), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2682), 13538m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2684), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2684), 2275m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2686), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2686), 20643m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2688), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2688), 8979m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2690), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2690), 23925m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2692), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2692), 33971m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2694), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2694), 14641m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2696), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2696), 13520m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2697), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2698), 21576m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2699), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2700), 19665m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2702), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2702), 20358m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2704), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2704), 8584m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2706), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2706), 27275m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2708), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2708), 4560m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2709), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2710), 30677m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2735), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2735), 22723m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2737), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2737), 10960m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2739), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2739), 12078m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2741), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2741), 33440m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2743), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2743), 6306m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2745), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2745), 8318m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2747), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2747), 10830m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2749), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2749), 10948m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2751), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2751), 36714m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2753), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2753), 20525m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2755), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2755), 21983m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2757), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2757), 22061m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2759), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2759), 25800m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2760), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2761), 31232m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2762), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2762), 5955m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2764), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2764), 34219m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2766), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2766), 22254m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2768), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2768), 14555m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2770), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2771), 5005m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2772), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2773), 35458m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2774), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2775), 37439m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2776), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2776), 5463m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2778), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2778), 11602m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2780), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2780), 29751m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2782), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2782), 6546m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2810), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2810), 9422m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2812), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2813), 4381m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2814), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2814), 30906m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2816), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2817), 21093m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2818), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2818), 4478m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2820), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2820), 15500m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2822), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2822), 12043m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2824), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2824), 27382m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2826), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2826), 892m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2828), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2828), 5413m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2829), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2830), 3346m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2831), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2831), 33119m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2833), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2833), 15190m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2835), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2835), 12540m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2836), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2837), 32930m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2838), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2839), 18245m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2840), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2840), 4369m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2842), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2843), 26798m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2844), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2844), 15154m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2846), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2846), 22408m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2848), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2848), 24391m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2850), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2850), 14706m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2852), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2852), 1840m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2853), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2854), 3348m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2881), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2881), 13857m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2882), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2883), 3507m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2884), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2885), 22291m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2886), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2887), 32262m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2888), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2888), 19672m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2890), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2890), 13584m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2891), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2892), 26106m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2893), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2894), 9357m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2895), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2895), 31175m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2897), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2897), 11154m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2899), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2899), 2365m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2900), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2901), 20975m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2902), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2902), 18047m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2904), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2904), 36395m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2906), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2906), 34020m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2908), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2908), 37248m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2909), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2910), 30036m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2911), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2912), 27584m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2913), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2913), 33249m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2915), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2915), 5746m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2917), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2917), 37929m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2918), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2919), 6742m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2920), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2921), 29590m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2922), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2922), 31313m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2924), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2924), 883m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2925), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2926), 19554m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2927), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2928), 36006m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2929), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2929), 7798m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2955), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2956), 4000m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2957), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2958), 13985m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2959), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2960), 7491m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2961), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2961), 38049m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2963), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2963), 29102m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2965), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2965), 23029m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2967), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2967), 19985m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2969), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2969), 31949m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2971), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2971), 26699m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2973), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2973), 38389m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2975), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2975), 18965m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2977), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2977), 31968m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2978), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2979), 8009m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2980), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2980), 21860m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2982), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2982), 38397m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2984), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2984), 1013m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2985), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2986), 33953m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2987), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2988), 1653m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2989), new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2989), 1921m });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2274));
        }
    }
}
