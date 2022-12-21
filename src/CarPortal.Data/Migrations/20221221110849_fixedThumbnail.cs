using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class fixedThumbnail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_OfferThumbnail_OfferThumbnailId",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0dbca0b-69ea-457b-96cf-c1268c78a119", "AQAAAAEAACcQAAAAEA/O5GzsrdlKOcCsi6Jw93fzJ+ZHj+Rr/96VPtJKC4Drhdnm0KgJ7tu+bs/IZ0lCDw==", "609c0158-8e3b-448f-8cf1-ad9d406220b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff48b2d3-70b4-43b7-8caf-40afb54a00c4", "AQAAAAEAACcQAAAAEIupUWYachSEPC2LZU4jwl7nyFsad7vIo3Y1wkwE3kN8j1XWYnj2NS4+c1Ic/zX8dQ==", "9902903a-b855-46a4-ae48-2f00ffec6d91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b30f207-9fb4-41e6-bf8f-1920fe45a612", "AQAAAAEAACcQAAAAEI1YE665Bb0NBf+iGqZjHAYQPbIQF/jsWayEUrO4D5ewDxLZO0YI/kiJJXcNZRBC/w==", "0f4205a3-d3e7-4729-b3c5-35006ea78dd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7db452-f884-4028-a497-13875f9fbece", "AQAAAAEAACcQAAAAEEVo0ygqWPEZ6XBGmM+00d4GmvnVdg+HbsvgIz+c2V7ALOGvX2WtMAiHKGkyf/mhUw==", "44e9617d-db9b-4cdb-9e8b-2b5249618d5a" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1654.0, 405, 17, 66136, 65, 2, 2, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1830.0, 5, 177, 3, 255492, 9, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2572.0, 5, 123, 4, 154182, 13, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2369.0, 6, 77, 8, 254758, 29, 4, 2, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1497.0, 6, 252, 7, 23567, 27, 4, 2, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2749.0, 5, 277, 7, 233145, 25, 3, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2265.0, 180, 8, 313488, 31, 5, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1535.0, 250, 16, 375182, 63, 1, 3, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2126.0, 4, 244, 9, 162506, 33, 2, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2540.0, 1, 412, 18, 32057, 70, 4, 3, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1183.0, 3, 203, 19, 268444, 73, 4, 1, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3557.0, 3, 151, 19, 160422, 75, 1, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 1, 2374.0, 5, 495, 10, 34139, 37, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3239.0, 406, 16, 143444, 63, 5, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3114.0, 6, 157, 17, 99865, 66, 3, 3, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2319.0, 79, 11, 363410, 42, 4, 1, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1842.0, 6, 345, 8, 343465, 29, 4, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2855.0, 1, 476, 7, 89549, 25, 6, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3953.0, 4, 203, 15, 148194, 58, 4, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2976.0, 3, 488, 404675, 5, 6, 4, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1678.0, 5, 394, 19, 203401, 73, 1, 3, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3287.0, 4, 227, 15, 393568, 59, 6, 4, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3705.0, 1, 179, 16, 61933, 63, 3, 2, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1986.0, 2, 478, 16, 360619, 62, 3, 2, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EngineDisplacement", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1463.0, 397, 381098, 1, 1, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3282.0, 6, 92, 18, 337626, 69, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1379.0, 3, 438, 1, 202802, 2, 2, 4, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2153.0, 5, 195, 9, 431605, 35, 6, 3, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2634.0, 329, 17, 469711, 67, 3, 4, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2072.0, 278, 11, 234397, 43, 2, 2, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1086.0, 452, 15, 109204, 57, 2, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2050.0, 73, 62565, 1, 3, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1655.0, 205, 19, 28794, 73, 4, 4, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3377.0, 2, 205, 11, 331979, 41, 5, 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3101.0, 4, 400, 67879, 43, 1, 5, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3317.0, 5, 408, 12, 120819, 46, 2, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2788.0, 1, 188, 14, 182937, 54, 6, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2936.0, 4, 296, 19, 123849, 75, 3, 3, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1660.0, 2, 84, 16, 33264, 63, 1, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3772.0, 2, 423, 6, 114196, 21, 5, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 3126.0, 4, 257, 10, 412838, 37, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2732.0, 2, 467, 6, 290515, 21, 3, 4, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2339.0, 5, 322, 16, 65786, 61, 2, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3717.0, 3, 180, 12, 40383, 45, 1, 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1830.0, 4, 111, 8, 123306, 31, 2, 6, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1732.0, 6, 281, 11, 222987, 42, 1, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1574.0, 311, 11, 142356, 41, 6, 3, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 6, 1468.0, 2, 248, 10, 474163, 39, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2272.0, 2, 173, 4, 120065, 13, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2620.0, 3, 428, 10, 193427, 37, 6, 6, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3217.0, 473, 8, 105210, 30, 3, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3694.0, 64, 15, 61098, 57, 3, 3, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2758.0, 2, 362, 17, 176985, 65, 5, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2707.0, 401, 7, 167509, 27, 6, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3284.0, 4, 471, 17, 313501, 67, 1, 5, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1401.0, 6, 410, 5, 162383, 17, 1, 4, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2314.0, 1, 376, 7, 36267, 26, 4, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3594.0, 5, 202, 19, 28129, 74, 4, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3550.0, 4, 60, 17, 354296, 65, 6, 5, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2348.0, 4, 378, 2, 97632, 5, 4, 1, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2589.0, 3, 337, 16, 431914, 63, 2, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 1, 1682.0, 2, 254, 6, 283869, 21, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1579.0, 5, 448, 1, 266608, 1, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3730.0, 2, 489, 12, 399323, 45, 2, 4, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2656.0, 1, 361, 17, 111646, 67, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3955.0, 3, 361, 15, 287183, 59, 4, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1911.0, 4, 479, 14, 267336, 55, 2, 6, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2619.0, 1, 376, 1, 164443, 2, 1, 4, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1421.0, 2, 254, 3, 437142, 11, 4, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2345.0, 4, 424, 4, 81272, 15, 4, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2682.0, 1, 484, 14, 130727, 53, 6, 3, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3199.0, 5, 400, 19, 326352, 75, 3, 3, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3848.0, 6, 83, 3, 343708, 11, 1, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3676.0, 445, 115989, 38, 2, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3474.0, 3, 296, 9, 244646, 33, 1, 5, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2268.0, 2, 233, 4, 399113, 15, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2928.0, 1, 352, 11, 72903, 43, 5, 4, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 1108.0, 3, 347, 8, 386295, 30, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2589.0, 4, 71, 6, 263149, 21, 3, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2125.0, 216, 3, 406371, 10, 1, 1, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3823.0, 4, 325, 15, 315152, 57, 3, 3, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2583.0, 2, 414, 15, 178338, 59, 1, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1850.0, 1, 153, 17, 227783, 66, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1831.0, 5, 158, 16, 410015, 62, 2, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2267.0, 2, 95, 7, 70401, 25, 2, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3959.0, 2, 220, 8, 408771, 30, 2, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2348.0, 3, 409, 9, 362361, 35, 6, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1249.0, 1, 478, 7, 49828, 25, 1, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1133.0, 1, 80, 1, 199452, 1, 6, 6, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3701.0, 4, 211, 11, 494552, 43, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 3049.0, 4, 62, 1, 117309, 1, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1717.0, 4, 188, 12, 89237, 47, 6, 1, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1471.0, 6, 295, 12, 441017, 46, 5, 1, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2666.0, 472, 17, 176564, 67, 2, 4, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3307.0, 1, 228, 10, 231993, 38, 1, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1162.0, 2, 68, 2, 180765, 7, 6, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3621.0, 1, 377, 11, 81182, 41, 6, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 4, 3659.0, 445, 16, 491570, 61, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1390.0, 3, 495, 15, 237451, 58, 4, 5, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 1936.0, 1, 293, 9, 86640, 35, 4, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 6, 3733.0, 2, 143, 8, 421466, 31, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3320.0, 2, 490, 4, 103854, 13, 5, 2, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2009.0, 119, 4, 322079, 13, 3, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2898.0, 1, 365, 8, 445305, 30, 5, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1261.0, 1, 464, 14, 402193, 53, 5, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1638.0, 5, 63, 2, 164497, 5, 5, 1, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3063.0, 2, 302, 17, 214825, 67, 1, 1, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1685.0, 4, 444, 10, 495906, 38, 1, 4, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1349.0, 6, 478, 6, 245505, 23, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1965.0, 5, 458, 8, 156357, 31, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3144.0, 1, 94, 346721, 73, 4, 5, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2984.0, 5, 189, 10, 366578, 38, 5, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3263.0, 2, 464, 19, 428723, 73, 4, 2, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3459.0, 4, 455, 1, 280076, 1, 6, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3137.0, 4, 175, 19, 208032, 73, 2, 6, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1842.0, 171, 7, 104796, 26, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2730.0, 2, 159, 5, 324047, 19, 2, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3398.0, 6, 443, 8, 388946, 29, 6, 2, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1376.0, 3, 439, 13, 33132, 51, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1184.0, 6, 441, 1, 485476, 2, 3, 5, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1075.0, 2, 351, 17, 192086, 67, 6, 2, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3515.0, 3, 304, 18, 289400, 70, 3, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3058.0, 64, 16, 30603, 62, 1, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2396.0, 95, 17, 32027, 65, 4, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3272.0, 2, 305, 7, 489187, 27, 2, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1926.0, 6, 240, 3, 310190, 11, 4, 4, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1264.0, 3, 73, 19, 93725, 74, 2, 5, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 1, 2264.0, 2, 179, 9, 170632, 35, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2803.0, 1, 423, 3, 384931, 9, 3, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2813.0, 4, 149, 10, 424544, 38, 2, 4, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3312.0, 365, 18, 476583, 71, 2, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2239.0, 4, 380, 12, 242803, 45, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3494.0, 5, 61, 2, 495701, 7, 2, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2679.0, 1, 444, 3, 157096, 9, 6, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3534.0, 3, 387, 5, 29293, 18, 3, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3759.0, 3, 491, 4, 481311, 15, 2, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1235.0, 1, 230, 5, 471462, 19, 4, 4, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3229.0, 68, 15, 104365, 58, 6, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2479.0, 3, 316, 17, 404172, 65, 1, 4, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1532.0, 2, 480, 7, 170564, 27, 3, 5, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3814.0, 2, 407, 17, 375560, 65, 6, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1640.0, 5, 401, 4, 336879, 14, 5, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1400.0, 298, 17, 301329, 66, 6, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 3, 3536.0, 3, 404, 16, 344516, 61, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3211.0, 5, 117, 11, 380398, 43, 5, 3, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3356.0, 6, 296, 10, 248565, 38, 6, 6, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2619.0, 5, 480, 8, 29523, 30, 6, 5, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2117.0, 1, 351, 6, 437911, 22, 6, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2874.0, 6, 100, 5, 151553, 18, 2, 4, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3061.0, 6, 263, 14, 210962, 54, 5, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1142.0, 2, 460, 17, 150250, 65, 4, 2, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2253.0, 4, 473, 19, 179745, 75, 5, 5, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2835.0, 3, 215, 15, 260251, 58, 4, 3, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1405.0, 1, 189, 11, 102448, 41, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3279.0, 3, 424, 16, 288998, 63, 3, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1400.0, 5, 172, 2, 121418, 6, 4, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1601.0, 6, 121, 15, 443272, 59, 1, 5, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2583.0, 2, 346, 4, 448765, 15, 5, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2037.0, 6, 419, 2, 164598, 6, 3, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2754.0, 3, 460, 4, 468554, 15, 6, 4, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2173.0, 6, 460, 13, 380009, 51, 2, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1105.0, 6, 453, 7, 116665, 26, 1, 1, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2406.0, 4, 497, 1, 205334, 3, 6, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3348.0, 4, 493, 14, 355016, 54, 5, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3974.0, 6, 281, 18, 230069, 69, 1, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2892.0, 185, 18, 204345, 69, 5, 3, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2156.0, 5, 299, 19, 438568, 75, 6, 1, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1651.0, 4, 394, 1, 489358, 2, 1, 3, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1581.0, 430, 17, 204332, 67, 2, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3965.0, 1, 309, 18, 175486, 70, 6, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2858.0, 3, 434, 17, 422270, 66, 2, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 6, 2654.0, 5, 184, 1, 433546, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2437.0, 138, 10, 409555, 37, 1, 4, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2416.0, 2, 495, 9, 410187, 33, 6, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3687.0, 275, 3, 470313, 10, 2, 5, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1119.0, 4, 437, 8, 464983, 30, 6, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2860.0, 5, 161, 8, 436247, 29, 2, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3017.0, 88, 14, 164578, 55, 6, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 1249.0, 2, 186, 3, 216656, 11, 1, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3603.0, 1, 62, 2, 57072, 5, 2, 3, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 2491.0, 4, 495, 5, 411796, 17, 4, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3931.0, 2, 462, 7, 477355, 27, 1, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2268.0, 431, 16, 365730, 62, 3, 6, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3708.0, 6, 274, 18, 39775, 69, 4, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1538.0, 4, 300, 11, 316980, 41, 3, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 3653.0, 167, 7, 422423, 27, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3769.0, 4, 484, 15, 431437, 57, 6, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3411.0, 62, 11, 210935, 43, 3, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2641.0, 158, 8, 91215, 29, 2, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1764.0, 4, 221, 205896, 66, 4, 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 6, 3590.0, 2, 316, 3, 496333, 9, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2052.0, 6, 216, 15, 342076, 58, 1, 5, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2753.0, 6, 415, 14, 217985, 53, 2, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2146.0, 1, 242, 18, 160515, 69, 6, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1086.0, 6, 366, 4, 279417, 13, 1, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3310.0, 1, 428, 9, 168091, 33, 5, 1, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 3888.0, 3, 196, 9, 248310, 34, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1608.0, 1, 76, 3, 120202, 9, 4, 5, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3851.0, 3, 188, 16, 375057, 62, 1, 4, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 4, 1010.0, 6, 352, 2, 333577, 6, 2006 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8741), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8742), 19803m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8750), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8750), 1901m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8754), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8754), 26126m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8756), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8757), 1144m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8759), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8759), 10853m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8762), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8762), 16800m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8765), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8765), 10488m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8767), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8767), 5128m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8769), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8769), 31068m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8772), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8773), 24379m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8775), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8775), 23996m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8777), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8777), 14110m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8816), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8817), 20936m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8819), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8819), 31976m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8821), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8821), 24821m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8823), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8824), 32018m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8825), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8826), 21100m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8828), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8828), 29246m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8830), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8830), 10486m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8832), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8833), 7314m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8834), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8835), 3022m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8837), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8837), 16479m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8839), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8839), 16837m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8841), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8841), 14046m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8843), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8843), 4466m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8845), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8845), 23162m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8847), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8847), 19591m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8849), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8849), 10020m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8851), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8851), 15839m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8853), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8853), 2781m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8855), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8855), 23642m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8857), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8857), 33674m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8859), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8859), 15576m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8862), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8862), 4435m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8864), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8864), 6666m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8897), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8898), 5791m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8899), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8900), 32721m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8902), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8902), 8777m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8903), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8904), 38153m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8905), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8906), 4805m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8907), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8908), 8962m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8909), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8910), 26365m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8911), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8912), 18626m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8913), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8914), 4953m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8915), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8916), 8027m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8917), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8918), 24505m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8920), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8920), 18718m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8922), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8922), 26974m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8925), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8925), 35671m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8927), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8927), 34748m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8929), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8929), 23065m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8931), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8931), 12480m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8933), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8933), 16285m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8935), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8935), 11433m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8936), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8937), 21095m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8938), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8938), 9750m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8940), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8940), 15537m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8942), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8942), 6293m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8944), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8944), 27425m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8946), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8946), 15443m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8982), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8982), 28478m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8983), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8984), 7634m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8985), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8986), 22657m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8987), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8988), 15463m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8989), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8990), 4816m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8993), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8993), 10371m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8995), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8995), 9187m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8997), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8997), 28864m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8999), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(8999), 21433m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9001), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9001), 28722m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9003), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9003), 6044m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9004), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9005), 36786m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9006), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9007), 29123m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9008), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9009), 18890m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9010), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9011), 2500m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9012), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9013), 5274m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9014), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9014), 35392m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9016), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9016), 15404m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9018), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9019), 3330m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9020), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9021), 28779m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9022), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9022), 32345m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9024), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9024), 18234m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9057), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9058), 31218m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9059), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9059), 2695m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9061), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9062), 35831m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9064), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9064), 3254m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9066), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9066), 10530m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9068), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9068), 26326m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9070), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9070), 10145m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9071), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9072), 15867m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9073), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9074), 12268m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9076), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9076), 10370m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9077), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9078), 17425m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9080), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9080), 36508m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9082), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9082), 36342m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9084), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9084), 31342m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9086), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9086), 31250m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9088), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9088), 16033m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9090), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9090), 2112m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9092), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9092), 22825m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9094), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9094), 25435m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9096), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9097), 33545m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9098), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9099), 26102m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9100), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9101), 10051m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9102), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9103), 23241m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9104), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9105), 12728m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9106), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9107), 25162m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9108), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9109), 6996m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9166), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9166), 9132m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9168), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9169), 35628m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9170), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9171), 745m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9172), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9173), 18101m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9175), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9175), 11226m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9177), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9177), 11824m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9179), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9179), 23107m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9181), 715m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9182), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9183), 26303m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9184), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9185), 39803m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9186), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9187), 11823m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9188), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9189), 8362m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9191), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9191), 5448m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9193), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9193), 2291m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9195), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9195), 24684m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9197), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9197), 29636m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9199), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9199), 12122m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9201), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9201), 37973m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9203), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9203), 1202m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9205), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9206), 6478m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9207), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9208), 24819m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9242), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9243), 26773m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9245), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9245), 27349m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9247), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9247), 8612m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9249), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9249), 25819m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9250), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9251), 30722m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9252), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9253), 3058m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9255), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9255), 38724m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9257), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9257), 9474m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9259), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9260), 5895m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9262), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9262), 24006m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9264), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9265), 26950m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9266), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9267), 13911m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9268), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9269), 24871m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9270), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9271), 25612m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9273), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9273), 39061m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9275), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9275), 7552m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9277), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9277), 10727m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9279), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9279), 8701m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9280), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9281), 16911m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9282), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9282), 32453m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9284), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9284), 37956m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9286), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9287), 9363m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9323), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9323), 4556m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9325), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9325), 25761m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9327), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9327), 33395m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9328), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9329), 15397m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9330), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9331), 38791m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9332), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9333), 14262m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9334), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9334), 16830m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9336), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9336), 1161m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9338), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9338), 37866m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9340), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9340), 36106m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9342), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9342), 39213m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9344), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9344), 31115m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9346), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9346), 5925m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9348), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9348), 22982m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9350), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9351), 9109m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9352), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9352), 23249m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9354), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9354), 19191m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9356), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9356), 16694m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9358), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9358), 21599m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9360), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9360), 32278m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9361), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9362), 38292m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9363), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9364), 22078m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9365), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9365), 5535m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9367), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9367), 25332m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9369), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9369), 29949m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9407), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9407), 25991m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9409), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9409), 25985m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9411), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9411), 36546m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9413), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9413), 29716m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9415), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9415), 4468m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9417), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9417), 33628m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9419), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9419), 10981m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9421), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9421), 32673m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9422), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9423), 7956m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9424), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9424), 36849m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9426), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9426), 21021m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9428), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9428), 27093m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9430), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9431), 20397m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9432), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9433), 18512m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9434), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9434), 38071m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9436), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9437), 16486m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9438), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9439), 27641m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9440), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9440), 34243m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9442), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9442), 18115m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9444), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9444), 16634m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9446), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9446), 25734m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9448), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9448), 17225m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9449), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9450), 32921m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9451), new DateTime(2022, 12, 21, 11, 8, 48, 604, DateTimeKind.Utc).AddTicks(9452), 652m });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 21, 11, 8, 48, 602, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 21, 11, 8, 48, 602, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 21, 11, 8, 48, 602, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 21, 11, 8, 48, 602, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_OfferThumbnail_OfferThumbnailId",
                table: "Offers",
                column: "OfferThumbnailId",
                principalTable: "OfferThumbnail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_OfferThumbnail_OfferThumbnailId",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b893c209-340b-489c-b09b-24926b87e730", "AQAAAAEAACcQAAAAEJGdfGsE29nPBHoB1fwEdmC2zZjw3G3+pJ2jLx2YDsYC4vKv5aBXfUFr21unorLP6Q==", "8ece9e42-3d2d-4e00-b7ea-1628fe4cbb0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74f78e5a-7c71-414d-906d-31b3c91b8aae", "AQAAAAEAACcQAAAAEMTk9KMPJzCXuRiwnyVn7ikXDJsoWR7uZ3Wa0hASyFSwLHg4fQeA0m3Ibql+nLHQTA==", "176b7768-4442-402d-ba72-30004dc24809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf638e1d-5bc4-4d0c-82f7-3d73c8dea3e8", "AQAAAAEAACcQAAAAEHCkUmW7rElFsJu5gjCREOvUegiDRmW3Z9QpnVIzNFvIe0VkgETnc9MG7XXDK9desw==", "d1b81eb5-573a-42ef-a8d3-a5f497b738ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "505cb964-c6fd-4ecd-b6f4-0842bbf0c3c6", "AQAAAAEAACcQAAAAEJzWuSW9712fR81wm+OvfInmnwCzJrQkKoXTzd8A0Pt9q/a3MkVLAcE9kyEo8qTNzg==", "0746d3e6-7cb5-49c2-9bd8-51042e27e581" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3357.0, 138, 2, 263016, 5, 5, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1751.0, 3, 333, 6, 338002, 22, 4, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2083.0, 1, 335, 11, 22442, 41, 4, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3513.0, 4, 212, 5, 223618, 19, 5, 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1522.0, 5, 312, 14, 89548, 54, 2, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 3767.0, 1, 403, 2, 454641, 7, 2, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3566.0, 278, 3, 47807, 9, 4, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3714.0, 331, 2, 411330, 6, 5, 5, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3869.0, 6, 218, 3, 205749, 10, 1, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3270.0, 3, 101, 1, 128264, 2, 2, 5, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2987.0, 6, 245, 6, 421918, 22, 5, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3246.0, 5, 484, 8, 239257, 30, 2, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 3, 3695.0, 6, 204, 14, 166478, 53, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3122.0, 123, 12, 249611, 47, 6, 4, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2036.0, 2, 463, 19, 323512, 73, 6, 4, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3005.0, 187, 2, 255785, 7, 2, 3, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2772.0, 3, 315, 1, 145183, 3, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3615.0, 3, 295, 3, 409278, 9, 2, 5, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2618.0, 1, 434, 14, 329521, 53, 1, 6, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1612.0, 6, 441, 182313, 7, 1, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3594.0, 2, 113, 18, 391529, 71, 5, 1, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3983.0, 3, 351, 7, 94443, 26, 1, 1, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3112.0, 2, 274, 2, 56101, 7, 6, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1708.0, 5, 148, 5, 257042, 18, 6, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EngineDisplacement", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3541.0, 164, 437392, 3, 6, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3839.0, 2, 122, 14, 475355, 53, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3791.0, 6, 335, 6, 354525, 21, 1, 5, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1130.0, 6, 95, 18, 250220, 69, 5, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1804.0, 195, 14, 426393, 53, 4, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1022.0, 62, 7, 323906, 27, 3, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1273.0, 280, 16, 437810, 63, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1148.0, 437, 305605, 5, 2, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3685.0, 482, 2, 134575, 6, 6, 6, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1304.0, 5, 84, 9, 486258, 34, 4, 3, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2532.0, 2, 98, 416107, 42, 6, 4, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3374.0, 2, 230, 10, 443442, 37, 3, 2, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3211.0, 2, 459, 13, 367985, 50, 2, 4, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2125.0, 6, 97, 16, 325365, 61, 2, 2, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2063.0, 3, 202, 7, 414806, 25, 2, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3038.0, 5, 181, 18, 260581, 69, 1, 6, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1800.0, 3, 104, 17, 454528, 65, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3057.0, 3, 293, 5, 305422, 19, 1, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3054.0, 3, 103, 11, 368594, 41, 4, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3044.0, 6, 237, 14, 268741, 55, 3, 4, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2049.0, 5, 311, 9, 120883, 35, 3, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1289.0, 4, 307, 14, 220277, 53, 6, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2299.0, 412, 12, 472026, 46, 4, 1, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 7, 2972.0, 6, 107, 9, 76230, 34, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1800.0, 1, 427, 18, 339667, 71, 2, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2861.0, 2, 453, 1, 365066, 1, 3, 5, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1906.0, 470, 13, 460060, 50, 4, 5, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3336.0, 498, 19, 396693, 75, 5, 1, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1765.0, 4, 318, 9, 237590, 35, 2, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1056.0, 419, 12, 148299, 45, 1, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2079.0, 3, 369, 9, 381768, 34, 4, 4, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3076.0, 1, 481, 3, 135025, 9, 4, 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1805.0, 6, 148, 9, 93717, 33, 5, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1544.0, 6, 398, 9, 474012, 34, 6, 5, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2693.0, 3, 323, 6, 397977, 21, 5, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1285.0, 5, 373, 13, 104934, 51, 1, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3095.0, 2, 133, 6, 429062, 22, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 4, 1490.0, 4, 376, 4, 271083, 13, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3566.0, 3, 246, 15, 428291, 59, 5, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1547.0, 5, 486, 7, 88221, 25, 3, 1, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2896.0, 4, 439, 1, 162044, 3, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3303.0, 2, 146, 18, 296317, 70, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2092.0, 2, 105, 1, 440367, 3, 6, 2, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1218.0, 4, 328, 16, 21358, 62, 4, 1, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3965.0, 6, 302, 18, 335174, 70, 6, 2, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1888.0, 2, 191, 12, 208203, 45, 2, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3158.0, 2, 119, 9, 403329, 34, 3, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2448.0, 3, 442, 18, 198673, 71, 4, 2, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1292.0, 2, 191, 13, 451237, 50, 5, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3219.0, 470, 463790, 39, 1, 5, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3156.0, 5, 488, 10, 191570, 39, 4, 2, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3602.0, 4, 112, 5, 204649, 17, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1302.0, 6, 344, 12, 307017, 46, 3, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2940.0, 4, 179, 7, 401774, 27, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1086.0, 5, 179, 2, 389624, 5, 6, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2615.0, 346, 14, 174694, 54, 6, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2094.0, 6, 461, 3, 368498, 11, 6, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3914.0, 6, 239, 2, 372970, 5, 6, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3962.0, 2, 422, 16, 409662, 61, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2618.0, 1, 97, 1, 430587, 1, 1, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1956.0, 5, 451, 10, 89646, 38, 5, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3794.0, 5, 327, 19, 499005, 73, 6, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3576.0, 4, 430, 8, 371556, 29, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3589.0, 2, 298, 15, 490405, 57, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1846.0, 3, 194, 6, 79995, 23, 3, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1043.0, 2, 97, 3, 183062, 9, 3, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1512.0, 6, 411, 9, 233563, 34, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2425.0, 1, 359, 10, 296918, 39, 4, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1928.0, 5, 441, 6, 315135, 21, 6, 6, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2232.0, 259, 14, 472831, 55, 5, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3672.0, 5, 456, 11, 213665, 43, 4, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2070.0, 3, 259, 14, 83240, 55, 3, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2532.0, 3, 260, 4, 58240, 15, 4, 5, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 6, 2659.0, 324, 2, 59312, 5, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3964.0, 5, 367, 19, 160359, 73, 5, 4, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 2234.0, 5, 296, 11, 398323, 42, 5, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 3, 3940.0, 4, 62, 16, 437017, 62, 4 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3386.0, 6, 171, 18, 204915, 70, 6, 4, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 2126.0, 204, 17, 92626, 67, 4, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1154.0, 3, 306, 9, 315826, 33, 2, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2381.0, 4, 193, 7, 477013, 25, 6, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1190.0, 3, 145, 18, 239980, 69, 1, 2, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2071.0, 5, 324, 18, 310098, 70, 5, 4, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2781.0, 6, 358, 13, 496312, 51, 4, 1, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1017.0, 1, 431, 19, 344233, 74, 2, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3171.0, 1, 87, 12, 296831, 46, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2979.0, 2, 485, 438671, 75, 1, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1917.0, 1, 318, 6, 222098, 21, 2, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2279.0, 3, 96, 18, 256661, 71, 2, 6, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2260.0, 1, 211, 11, 469126, 43, 2, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1167.0, 5, 492, 1, 124384, 2, 1, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2655.0, 292, 14, 246963, 55, 4, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3950.0, 5, 225, 10, 182611, 37, 3, 4, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1915.0, 2, 267, 2, 120638, 6, 1, 4, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3650.0, 6, 188, 8, 270258, 29, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2483.0, 4, 96, 16, 429455, 61, 1, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3131.0, 4, 127, 8, 245435, 29, 2, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2469.0, 6, 322, 16, 103944, 63, 6, 1, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3942.0, 308, 3, 159966, 10, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3270.0, 411, 4, 40060, 14, 2, 2, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2030.0, 1, 170, 8, 312256, 31, 1, 4, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2419.0, 1, 393, 2, 349152, 6, 6, 1, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3560.0, 6, 260, 18, 297289, 69, 5, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 2, 1120.0, 5, 445, 8, 72788, 30, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2412.0, 3, 158, 12, 254592, 45, 4, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2178.0, 1, 154, 5, 331142, 19, 4, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1433.0, 370, 8, 221651, 30, 6, 6, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2995.0, 2, 189, 14, 103612, 55, 6, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2599.0, 3, 127, 18, 391145, 70, 1, 1, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2059.0, 3, 209, 19, 265261, 73, 3, 4, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1315.0, 5, 170, 18, 462704, 69, 2, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3408.0, 1, 418, 3, 348725, 10, 4, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1767.0, 4, 458, 8, 264001, 31, 5, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3705.0, 194, 6, 302488, 23, 2, 2, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1485.0, 2, 69, 14, 454081, 54, 4, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1013.0, 3, 446, 13, 309797, 50, 2, 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3531.0, 6, 233, 2, 364756, 7, 4, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2322.0, 4, 403, 1, 71516, 2, 2, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3786.0, 121, 6, 413187, 22, 4, 4, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 6, 3248.0, 6, 354, 17, 105099, 65, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1492.0, 1, 104, 19, 442464, 75, 4, 5, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3753.0, 3, 263, 1, 451617, 1, 4, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2867.0, 6, 81, 14, 36008, 53, 5, 2, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2850.0, 5, 420, 9, 108337, 33, 5, 2, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3010.0, 4, 85, 19, 165776, 73, 4, 1, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3954.0, 2, 68, 10, 36228, 37, 6, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3678.0, 5, 167, 1, 278540, 3, 2, 4, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3532.0, 5, 490, 16, 448865, 62, 2, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1599.0, 1, 82, 12, 432714, 45, 5, 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2577.0, 2, 245, 6, 130981, 22, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2812.0, 5, 86, 4, 37237, 14, 2, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2204.0, 2, 234, 11, 268333, 42, 3, 4, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2236.0, 1, 162, 5, 437438, 19, 5, 1, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1082.0, 6, 395, 12, 32330, 47, 1, 1, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1941.0, 3, 427, 9, 65309, 33, 5, 3, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1784.0, 6, 320, 15, 325224, 57, 5, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1754.0, 5, 163, 9, 28910, 34, 5, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3583.0, 1, 423, 18, 493692, 70, 6, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2583.0, 3, 342, 9, 221290, 34, 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2427.0, 6, 404, 1, 404132, 3, 4, 2, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3358.0, 1, 153, 17, 265803, 67, 6, 3, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2819.0, 298, 5, 279759, 19, 4, 1, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1570.0, 3, 385, 3, 75108, 9, 4, 3, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2846.0, 1, 193, 10, 131489, 37, 6, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3619.0, 302, 9, 418724, 34, 1, 3, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2549.0, 3, 168, 13, 160130, 49, 1, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3980.0, 6, 108, 6, 228837, 23, 5, 2, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 8, 3027.0, 2, 300, 8, 207801, 29, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3703.0, 280, 7, 278560, 27, 4, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1224.0, 1, 152, 13, 54345, 50, 2, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1457.0, 413, 14, 168265, 53, 3, 3, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 1352.0, 5, 287, 2, 59343, 7, 2, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1100.0, 1, 471, 18, 206402, 71, 4, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1837.0, 107, 13, 111804, 50, 1, 5, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 3810.0, 3, 204, 10, 266743, 39, 5, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1996.0, 2, 144, 10, 183746, 38, 6, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 3662.0, 1, 101, 3, 455046, 11, 6, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1255.0, 3, 79, 15, 293896, 57, 4, 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2107.0, 248, 7, 66179, 26, 2, 1, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2246.0, 2, 330, 7, 168708, 25, 3, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2510.0, 3, 451, 6, 317928, 23, 5, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2254.0, 396, 10, 430083, 38, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3489.0, 2, 440, 2, 160909, 7, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2414.0, 129, 14, 466150, 54, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2529.0, 86, 13, 124544, 49, 5, 1, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1068.0, 5, 388, 334213, 67, 1, 6, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 5, 2512.0, 5, 64, 7, 304185, 25, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1713.0, 4, 168, 12, 118048, 45, 4, 6, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1735.0, 2, 484, 1, 93310, 2, 6, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2411.0, 5, 224, 15, 47362, 58, 4, 5, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3927.0, 1, 404, 19, 448537, 74, 6, 2, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1283.0, 2, 422, 2, 86641, 5, 3, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2405.0, 1, 197, 10, 445589, 39, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3219.0, 3, 188, 15, 28868, 58, 1, 1, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3280.0, 4, 195, 8, 403747, 31, 4, 5, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 1, 2788.0, 5, 91, 4, 88968, 13, 2021 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1504), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1506), 23546m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1514), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1515), 37087m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1517), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1518), 36647m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1520), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1520), 19318m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1523), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1523), 12028m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1526), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1527), 10319m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1529), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1529), 23082m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1531), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1531), 26322m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1533), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1533), 9831m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1536), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1536), 19901m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1538), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1538), 28910m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1540), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1541), 33867m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1543), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1543), 34151m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1545), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1545), 1527m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1547), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1548), 21712m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1582), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1583), 26297m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1585), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1586), 20183m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1588), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1589), 12840m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1591), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1591), 12538m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1593), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1593), 37960m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1595), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1595), 12308m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1597), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1597), 12442m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1599), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1599), 3728m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1601), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1601), 13162m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1603), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1604), 15431m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1605), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1605), 38417m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1607), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1607), 15333m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1609), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1610), 2936m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1611), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1612), 38489m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1613), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1614), 33733m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1615), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1616), 39152m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1618), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1618), 1869m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1620), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1621), 15366m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1623), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1624), 15586m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1625), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1626), 38082m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1627), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1628), 9369m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1629), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1630), 16194m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1632), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1632), 2468m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1686), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1686), 23254m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1689), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1689), 5898m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1691), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1691), 19742m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1693), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1693), 16147m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1695), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1695), 36617m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1697), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1697), 2319m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1699), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1699), 24928m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1701), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1702), 24441m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1703), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1703), 18225m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1705), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1706), 19795m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1708), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1708), 35390m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1710), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1710), 2480m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1712), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1712), 38307m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1714), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1714), 15575m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1716), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1717), 34033m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1719), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1719), 7293m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1721), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1721), 11800m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1723), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1723), 37897m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1725), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1725), 11645m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1727), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1727), 24473m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1729), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1729), 17775m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1731), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1731), 19728m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1733), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1733), 26828m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1735), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1735), 20229m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1737), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1738), 38103m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1739), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1740), 30929m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1781), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1782), 26395m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1784), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1785), 30419m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1786), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1787), 8719m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1789), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1789), 37384m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1791), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1791), 28396m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1793), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1794), 30573m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1795), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1796), 4345m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1798), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1798), 14262m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1800), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1800), 9053m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1802), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1802), 18006m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1804), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1804), 6520m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1806), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1806), 32114m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1808), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1809), 29731m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1810), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1811), 18378m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1812), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1813), 20990m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1814), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1815), 10891m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1817), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1817), 22287m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1819), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1819), 20544m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1821), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1821), 7765m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1823), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1823), 17740m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1825), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1825), 24516m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1827), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1827), 2462m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1867), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1867), 39667m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1869), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1870), 37416m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1871), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1871), 34357m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1873), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1873), 15123m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1875), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1876), 21816m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1878), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1878), 36481m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1880), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1880), 9865m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1882), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1882), 26480m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1884), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1884), 6445m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1886), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1886), 39694m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1888), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1888), 3824m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1890), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1890), 27547m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1892), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1892), 31156m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1894), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1895), 24754m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1896), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1897), 6534m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1898), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1898), 21335m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1900), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1900), 13465m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1902), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1902), 36987m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1904), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1904), 8576m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1906), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1906), 21031m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1908), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1908), 32923m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1910), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1910), 39164m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1912), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1912), 14937m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1914), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1915), 34887m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1916), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1917), 13110m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1943), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1944), 21867m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1945), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1946), 32369m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1948), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1948), 6234m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1950), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1950), 1617m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1952), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1952), 11634m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1954), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1954), 38362m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1956), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1956), 27534m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1958), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1959), 6069m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1961), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1961), 11984m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1963), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1963), 25604m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1965), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1966), 19144m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1967), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1968), 3035m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1969), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1969), 5457m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1971), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1971), 18214m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1973), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1974), 36005m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1975), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1976), 38155m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1977), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1978), 23859m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1979), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1980), 39742m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1983), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1983), 3106m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2012), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2012), 12467m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2014), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2014), 2799m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2016), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2016), 15146m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2018), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2018), 22788m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2020), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2021), 23010m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2022), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2023), 894m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2024), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2025), 25386m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2026), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2027), 11760m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2028), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2029), 30615m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2030), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2031), 39997m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2033), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2033), 20367m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2034), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2035), 24187m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2037), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2037), 6423m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2038), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2039), 8681m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2041), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2041), 10964m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2042), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2043), 6256m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2044), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2045), 3949m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2047), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2047), 4368m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2049), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2049), 37736m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2051), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2051), 35988m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2053), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2054), 5827m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2055), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2056), 29884m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2057), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2058), 16416m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2060), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2060), 6611m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2062), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2062), 7071m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2088), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2089), 26475m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2090), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2091), 7663m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2093), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2093), 25148m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2095), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2095), 31146m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2096), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2097), 21552m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2099), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2099), 12988m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2101), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2101), 992m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2103), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2103), 33828m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2105), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2105), 23331m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2107), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2108), 38955m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2110), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2110), 27156m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2112), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2112), 13292m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2113), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2114), 17229m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2116), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2116), 15992m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2118), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2118), 16657m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2120), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2120), 22135m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2122), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2123), 16393m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2124), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2125), 1640m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2126), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2127), 8055m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2128), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2129), 22209m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2130), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2131), 22975m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2132), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2133), 23358m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2135), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2135), 24311m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2137), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2137), 7506m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2139), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2139), 39111m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2165), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2165), 16067m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2167), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2167), 18687m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2169), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2169), 27285m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2171), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2172), 25158m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2174), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2174), 21423m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2175), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2176), 21268m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2177), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2178), 15748m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2179), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2180), 19601m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2181), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2181), 13332m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2183), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2184), 27579m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2185), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2185), 27595m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2187), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2187), 6337m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2189), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2190), 3378m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2191), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2192), 11474m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2193), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2193), 21417m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2195), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2196), 33638m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2198), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2198), 24728m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2200), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2200), 38346m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2202), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2202), 15728m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2204), new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2204), 3455m });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_OfferThumbnail_OfferThumbnailId",
                table: "Offers",
                column: "OfferThumbnailId",
                principalTable: "OfferThumbnail",
                principalColumn: "Id");
        }
    }
}
