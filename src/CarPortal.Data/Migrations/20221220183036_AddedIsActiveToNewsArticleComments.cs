using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class AddedIsActiveToNewsArticleComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "NewsArticleComments",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cc4c376-2ece-412c-a877-c7463934a577", "AQAAAAEAACcQAAAAEPXy8PycMZmQ5IyNcyXW5o+YNb/p9OgJJaaxajXdG8plV2dn7BQ8VaMkrl4XiPPB4w==", "7de19b80-2e79-4ccb-8458-615212a402a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d94f3e67-29ad-47d3-be65-5cd3a1cc8ef8", "AQAAAAEAACcQAAAAEKEiCSKogBlbpGkS0YQ1i+M9ybJGvs6wMa6iriCCJMBYIiaFLVHc+iHA2Fyvny7JUg==", "b6ae4758-8100-49f2-a183-5606cbf38cad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fb86b06-25cb-4e03-bbe8-b9388ed21003", "AQAAAAEAACcQAAAAEOln+2EDGhChMjlBtfi/LDKjpWfLtRAEFe+2G1zv9HFZ0faJV9Q0gavAsQjPNQBt+A==", "9cdc24bc-7640-41d1-8ef4-c3fd87118109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8aedc43-2259-4eef-a317-326e1e8038f9", "AQAAAAEAACcQAAAAEEV8R+iX5g1IXMoz5GwFg2hk3xX71FeRVdtJlDofu3p8EqU7NYGLd4+N7Qvg9fwWow==", "9f6e3e21-b40b-4eed-9a83-e60a84a73c53" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 3478.0, 4, 107, 9, 160869, 34, 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2100.0, 2, 284, 8, 84655, 29, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1581.0, 4, 257, 15, 74621, 57, 3, 4, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1244.0, 3, 114, 11, 309267, 42, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1874.0, 6, 247, 232349, 21, 4, 4, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 4, 2816.0, 4, 89, 1, 348513, 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3214.0, 2, 497, 6, 250929, 21, 5, 6, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 2549.0, 5, 443, 4, 377473, 13, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3781.0, 3, 386, 5, 246412, 17, 2, 3, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2971.0, 4, 322, 5, 184548, 17, 5, 6, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1381.0, 2, 80, 12, 24163, 47, 5, 1, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1600.0, 3, 385, 7, 448679, 27, 5, 5, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1881.0, 3, 215, 13, 332696, 51, 5, 4, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2875.0, 6, 110, 23858, 2, 6, 4, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 3145.0, 4, 478, 14, 148695, 55, 6, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3912.0, 6, 100, 16, 203299, 63, 1, 1, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2581.0, 1, 168, 16, 473475, 63, 5, 6, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1795.0, 1, 107, 19, 143951, 74, 1, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2355.0, 2, 345, 7, 389576, 27, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2722.0, 1, 441, 41576, 27, 2, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2632.0, 3, 75, 12, 52492, 47, 1, 2, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 3166.0, 2, 256, 6, 454916, 22, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2853.0, 2, 108, 12, 425400, 47, 6, 3, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 2037.0, 5, 229, 11, 245475, 42, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2423.0, 5, 304, 3, 355846, 9, 3, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2463.0, 1, 315, 19, 304358, 75, 4, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2308.0, 3, 295, 18, 52354, 71, 4, 2, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3436.0, 1, 255, 18, 479806, 71, 4, 3, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2283.0, 480, 5, 80456, 18, 5, 4, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3282.0, 1, 104, 10, 152069, 39, 6, 1, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1752.0, 391, 10, 483386, 39, 3, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 1584.0, 4, 491, 15, 46259, 58, 1, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3049.0, 5, 470, 3, 87255, 10, 5, 6, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1000.0, 3, 394, 18, 117747, 69, 3, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1055.0, 6, 319, 19, 322314, 74, 1, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2321.0, 297, 8, 118796, 29, 4, 6, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3220.0, 4, 196, 1, 336326, 2, 5, 6, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1021.0, 5, 170, 3, 226905, 10, 3, 4, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2459.0, 2, 476, 1, 56564, 2, 1, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 7, 2109.0, 3, 159, 11, 461724, 43, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1244.0, 4, 225, 14, 370402, 55, 3, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1984.0, 5, 69, 16, 434625, 61, 2, 2, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2882.0, 228, 9, 139137, 33, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2144.0, 85, 17, 78608, 67, 6, 5, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1323.0, 4, 68, 7, 53592, 26, 5, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1163.0, 2, 210, 4, 75381, 15, 5, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1205.0, 4, 364, 333283, 22, 5, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3755.0, 3, 460, 6, 203968, 21, 4, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2320.0, 3, 363, 10, 488500, 37, 4, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1033.0, 6, 321, 19, 154226, 75, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1569.0, 2, 497, 18, 440142, 70, 1, 1, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3038.0, 2, 146, 2, 465090, 5, 4, 4, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3343.0, 6, 87, 19, 95498, 73, 6, 2, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 7, 2792.0, 3, 170, 274998, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2668.0, 4, 180, 8, 132251, 29, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1046.0, 2, 416, 14, 77382, 54, 4, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1168.0, 2, 357, 4, 217442, 15, 1, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2470.0, 4, 334, 17, 373924, 67, 2, 4, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1032.0, 4, 197, 19, 395176, 73, 4, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3750.0, 3, 388, 16, 253781, 61, 4, 4, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3551.0, 382, 6, 24887, 21, 4, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1474.0, 356, 15, 261851, 58, 2, 2, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1213.0, 4, 222, 7, 51311, 25, 1, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3119.0, 2, 185, 11, 323872, 41, 2, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2459.0, 457, 15, 459997, 58, 2, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1630.0, 3, 133, 10, 155717, 39, 6, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1958.0, 1, 274, 8, 442272, 31, 1, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1934.0, 1, 469, 17, 164451, 66, 1, 3, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2378.0, 6, 330, 7, 246546, 25, 6, 1, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3886.0, 208, 14, 117460, 55, 1, 4, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1012.0, 3, 244, 16, 281049, 61, 5, 2, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3643.0, 4, 106, 1, 84922, 1, 6, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3478.0, 3, 110, 19, 86360, 75, 2, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3511.0, 5, 267, 12, 46256, 47, 3, 4, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2036.0, 4, 324, 1, 421596, 2, 2, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1960.0, 1, 454, 12, 51968, 45, 6, 3, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2281.0, 1, 327, 11, 123039, 42, 2, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2916.0, 392, 6, 424177, 21, 6, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2528.0, 6, 409, 5, 105038, 18, 5, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2891.0, 2, 232, 10, 260762, 37, 3, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2166.0, 90, 10, 369552, 38, 4, 2, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3076.0, 3, 364, 13, 65663, 50, 3, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2289.0, 6, 74, 14, 123535, 55, 1, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 2609.0, 3, 428, 16, 45738, 61, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2343.0, 4, 464, 10, 43161, 37, 5, 6, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1378.0, 3, 356, 186849, 2, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 2786.0, 6, 136, 3, 27197, 9, 2, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3335.0, 2, 349, 4, 476820, 14, 5, 2, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1446.0, 2, 219, 1, 444399, 1, 5, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1856.0, 3, 472, 9, 289814, 35, 2, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2559.0, 458, 18, 54292, 71, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3257.0, 5, 114, 19, 235117, 74, 2, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1627.0, 6, 435, 5, 331649, 18, 5, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2993.0, 1, 332, 15, 230906, 57, 2, 1, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3090.0, 3, 147, 1, 477251, 1, 2, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1568.0, 2, 117, 6, 496319, 23, 5, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1178.0, 2, 450, 18, 332433, 71, 5, 4, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3479.0, 2, 150, 6, 204388, 21, 3, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2154.0, 6, 161, 19, 265133, 74, 3, 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2039.0, 4, 3, 146372, 9, 1, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1904.0, 1, 241, 18, 476242, 70, 2, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3133.0, 1, 268, 7, 47435, 26, 6, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1111.0, 3, 179, 11, 55035, 43, 4, 5, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3143.0, 5, 417, 10, 334916, 38, 1, 4, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2289.0, 6, 397, 4, 211044, 14, 5, 2, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 2, 2187.0, 2, 328, 7, 243852, 26, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 2, 2278.0, 6, 209, 14, 316776, 53, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3885.0, 4, 264, 3, 435273, 9, 5, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3707.0, 6, 91, 5, 349019, 19, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1696.0, 4, 180, 1, 31148, 1, 3, 3, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3853.0, 6, 203, 7, 281835, 26, 5, 6, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1966.0, 3, 121, 11, 330912, 42, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2711.0, 3, 101, 18, 465313, 70, 2, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2193.0, 151, 18, 155163, 70, 5, 3, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1301.0, 6, 202, 5, 349967, 18, 3, 2, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1221.0, 5, 97, 17, 261079, 65, 6, 5, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1566.0, 387, 10, 318228, 39, 2, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3006.0, 5, 442, 8, 313903, 29, 5, 3, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1032.0, 2, 122, 17, 211753, 66, 4, 2, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1617.0, 5, 489, 3, 371702, 9, 1, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 1883.0, 5, 423, 8, 153889, 30, 4, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2962.0, 2, 361, 13, 167738, 50, 1, 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3992.0, 1, 322, 19, 462130, 75, 4, 3, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1678.0, 2, 100, 13, 168438, 51, 5, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1307.0, 3, 418, 15, 399117, 58, 3, 3, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2617.0, 1, 300, 9, 360651, 33, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3183.0, 164, 1, 92103, 2, 5, 3, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3915.0, 3, 343, 6, 123564, 23, 1, 1, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2422.0, 245, 19, 85352, 74, 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 2029.0, 1, 295, 2, 488452, 5, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1603.0, 1, 106, 6, 152015, 22, 6, 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3224.0, 6, 309, 14, 41558, 53, 3, 2, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1162.0, 3, 132, 12, 285212, 46, 4, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 2327.0, 2, 481, 1, 277101, 3, 2, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3118.0, 214, 4, 282149, 14, 5, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3745.0, 1, 191, 5, 363141, 19, 6, 6, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2478.0, 6, 76, 3, 262666, 11, 5, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1014.0, 6, 139, 19, 122429, 74, 2, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1328.0, 2, 161, 16, 60942, 62, 3, 4, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2205.0, 4, 181, 10, 295004, 39, 1, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1083.0, 4, 327, 18, 32916, 70, 4, 2, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3234.0, 3, 473, 2, 366171, 6, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1893.0, 1, 282, 11, 483678, 42, 3, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1218.0, 1, 383, 10, 181713, 37, 3, 2, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2099.0, 142, 4, 278162, 13, 4, 4, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2734.0, 6, 248, 9, 102940, 34, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 2777.0, 412, 5, 295261, 17, 2, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3111.0, 6, 157, 15, 301278, 59, 1, 6, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1516.0, 1, 62, 3, 36031, 10, 4, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1636.0, 3, 372, 19, 386975, 73, 5, 4, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 3, 3558.0, 4, 417, 9, 163394, 34, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1921.0, 1, 484, 14, 92042, 54, 1, 6, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3174.0, 4, 484, 10, 245385, 38, 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2999.0, 217, 16, 208641, 63, 6, 6, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1451.0, 3, 487, 14, 467269, 55, 4, 2, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 2, 3582.0, 6, 373, 7, 259415, 27, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 1882.0, 1, 293, 4, 36996, 13, 5, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1746.0, 3, 105, 13, 65737, 49, 2, 3, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1346.0, 6, 340, 15, 238445, 57, 4, 5, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2023.0, 3, 356, 190717, 65, 2, 4, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1570.0, 1, 268, 5, 191088, 17, 6, 1, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1453.0, 3, 153, 12, 434196, 47, 2, 4, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 1602.0, 2, 165, 8, 380462, 29, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1790.0, 5, 177, 7, 335058, 25, 5, 1, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2041.0, 4, 227, 14, 437265, 53, 5, 1, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1319.0, 1, 296, 5, 306227, 17, 2, 2, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 4, 3857.0, 1, 101, 3, 269554, 10, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2253.0, 4, 434, 4, 167844, 15, 1, 1, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3580.0, 4, 129, 4, 182386, 15, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 2933.0, 1, 136, 3, 305643, 9, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2249.0, 1, 106, 19, 31861, 75, 2, 6, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1800.0, 6, 450, 15, 356695, 59, 3, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3739.0, 3, 303, 1, 76835, 3, 4, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3731.0, 6, 70, 18, 477887, 71, 1, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1302.0, 2, 291, 8, 382421, 29, 4, 3, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3157.0, 6, 88, 18, 173888, 71, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3583.0, 89, 4, 303804, 15, 2, 4, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3128.0, 2, 81, 11, 211835, 42, 6, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3940.0, 5, 101, 5, 333572, 17, 5, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2525.0, 5, 325, 6, 242715, 21, 1, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2846.0, 4, 99, 3, 343930, 9, 2, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 3851.0, 1, 204, 8, 117698, 29, 2, 6, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2799.0, 1, 307, 2, 132211, 7, 4, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2017.0, 6, 389, 1, 263918, 3, 1, 6, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1501.0, 1, 253, 15, 354821, 57, 6, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3984.0, 4, 175, 18, 43484, 69, 3, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3972.0, 4, 318, 6, 131191, 23, 5, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1798.0, 3, 139, 4, 411347, 14, 1, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1741.0, 2, 279, 408995, 1, 5, 5, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2178.0, 2, 243, 12, 396965, 47, 2, 6, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1855.0, 4, 152, 9, 130323, 33, 6, 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1622.0, 233, 8, 385172, 29, 5, 3, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1015.0, 352, 9, 86479, 34, 1, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2344.0, 5, 411, 4, 465578, 14, 4, 1, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3319.0, 5, 88, 3, 447871, 11, 4, 3, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3557.0, 6, 81, 9, 439201, 34, 6, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2647.0, 3, 274, 10, 460419, 38, 5, 1, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3852.0, 6, 242, 10, 139104, 39, 1, 5, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1342.0, 1, 305, 6, 166518, 22, 5, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2205.0, 4, 182, 12, 461445, 47, 3, 3, 2015 });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6589), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6590), 31681m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6599), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6599), 20649m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6602), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6602), 7168m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6604), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6605), 18572m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6607), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6607), 15866m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6610), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6611), 5313m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6612), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6613), 3280m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6614), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6615), 32280m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6617), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6617), 4902m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6619), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6620), 29682m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6621), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6622), 2341m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6624), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6624), 5651m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6655), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6655), 35359m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6658), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6658), 25931m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6660), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6661), 31278m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6663), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6663), 36837m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6665), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6666), 30877m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6668), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6669), 22369m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6671), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6671), 19957m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6673), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6673), 11437m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6675), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6675), 28198m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6677), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6677), 10604m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6679), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6680), 39190m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6681), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6681), 14705m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6683), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6683), 26860m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6685), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6685), 4046m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6687), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6687), 30921m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6689), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6690), 5064m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6691), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6692), 36337m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6693), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6694), 24310m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6696), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6696), 28424m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6698), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6698), 8520m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6700), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6700), 30003m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6703), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6704), 35666m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6706), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6706), 22666m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6707), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6708), 8555m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6710), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6710), 32870m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6712), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6712), 26550m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6785), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6785), 23712m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6788), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6788), 33679m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6790), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6790), 8318m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6792), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6793), 16362m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6795), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6795), 15565m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6797), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6797), 21914m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6799), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6799), 23556m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6801), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6802), 7838m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6803), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6804), 4973m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6806), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6806), 2163m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6808), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6809), 11534m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6811), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6811), 31442m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6813), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6814), 39966m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6815), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6816), 28785m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6818), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6818), 35114m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6820), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6820), 27577m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6823), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6823), 21608m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6825), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6825), 31253m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6828), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6828), 22560m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6830), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6830), 24084m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6832), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6832), 16974m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6834), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6834), 34834m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6836), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6836), 789m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6838), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6839), 24474m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6840), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6841), 30333m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6843), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6843), 25233m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6845), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6845), 8917m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6872), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6873), 37476m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6874), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6874), 10617m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6876), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6877), 26694m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6879), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6879), 3249m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6881), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6881), 36186m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6883), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6883), 6039m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6885), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6885), 21119m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6887), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6888), 26504m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6890), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6890), 16140m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6892), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6892), 34436m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6894), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6894), 25631m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6896), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6897), 2524m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6899), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6899), 11240m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6901), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6901), 20213m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6903), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6904), 37494m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6905), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6906), 13240m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6908), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6908), 3887m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6910), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6910), 34503m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6912), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6912), 16157m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6914), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6914), 14060m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6916), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6916), 17846m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6919), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6919), 36107m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6921), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6921), 12381m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6923), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6924), 30145m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6926), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6926), 9380m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6928), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6928), 25970m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6929), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6930), 20380m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6931), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6932), 10512m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6957), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6958), 15853m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6959), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6960), 14639m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6962), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6962), 12591m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6964), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6964), 29366m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6967), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6967), 2387m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6968), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6969), 6677m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6971), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6971), 9309m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6973), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6973), 22397m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6975), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6976), 9332m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6978), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6978), 17743m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6980), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6980), 29462m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6982), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6982), 4345m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6984), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6984), 2448m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6987), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6987), 29013m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6989), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6989), 25072m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6991), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6992), 23771m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6993), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6994), 24079m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6996), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6996), 31682m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6998), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(6999), 10073m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7001), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7001), 28942m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7003), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7004), 18175m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7006), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7006), 26967m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7008), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7008), 27067m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7010), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7010), 30163m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7013), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7013), 13307m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7015), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7015), 18418m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7017), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7018), 757m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7020), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7020), 31786m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7022), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7023), 30610m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7051), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7052), 27908m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7054), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7054), 16770m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7056), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7056), 28594m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7058), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7059), 34118m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7061), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7061), 35389m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7063), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7063), 19157m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7065), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7065), 12735m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7068), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7069), 37107m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7070), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7071), 23591m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7072), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7073), 37237m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7074), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7075), 25123m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7076), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7077), 10930m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7079), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7079), 22424m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7080), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7081), 37341m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7083), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7083), 25037m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7086), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7086), 10984m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7088), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7088), 12638m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7090), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7090), 8670m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7092), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7093), 32072m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7095), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7095), 9650m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7097), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7097), 37475m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7123), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7124), 39941m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7126), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7126), 14969m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7128), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7128), 18244m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7130), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7130), 763m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7132), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7133), 21845m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7135), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7135), 15702m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7137), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7137), 7851m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7139), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7139), 38790m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7141), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7142), 32607m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7144), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7144), 10468m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7146), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7147), 11416m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7148), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7149), 1820m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7151), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7151), 9327m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7153), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7153), 16267m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7154), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7155), 1668m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7157), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7157), 27409m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7159), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7160), 4206m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7161), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7162), 22945m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7163), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7164), 35345m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7166), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7166), 20945m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7168), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7169), 10563m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7171), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7171), 32180m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7173), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7174), 36393m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7176), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7176), 21755m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7178), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7178), 1010m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7180), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7180), 19473m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7182), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7183), 19004m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7185), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7185), 5576m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7211), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7212), 13024m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7214), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7214), 16646m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7216), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7216), 32465m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7218), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7219), 5734m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7220), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7221), 35285m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7223), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7223), 21771m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7225), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7225), 20271m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7227), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7228), 16853m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7229), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7230), 22575m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7231), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7232), 775m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7233), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7234), 679m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7235), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7236), 33858m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7237), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7238), 3944m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7239), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7240), 36633m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7241), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7242), 29269m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7243), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7244), 25794m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7246), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7246), 18292m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7248), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7248), 17676m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7250), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7250), 24460m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7252), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7252), 5835m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7254), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7254), 22314m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7256), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7256), 32479m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7258), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7258), 25366m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7260), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7260), 22976m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7262), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7262), 13358m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7264), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7264), 16129m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7266), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7267), 7456m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7268), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7269), 7864m });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedOn", "LastEdited", "Price" },
                values: new object[] { new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7301), new DateTime(2022, 12, 20, 18, 30, 35, 596, DateTimeKind.Utc).AddTicks(7301), 10978m });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 18, 30, 35, 594, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 18, 30, 35, 594, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 18, 30, 35, 594, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 20, 18, 30, 35, 594, DateTimeKind.Utc).AddTicks(8127));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "NewsArticleComments");

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3985.0, 2, 204, 12, 20091, 45, 3, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2595.0, 3, 281, 16, 34603, 62, 4, 2021 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3637.0, 5, 436, 4, 252101, 14, 2, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3820.0, 5, 445, 250722, 22, 3, 5, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 2, 2078.0, 2, 480, 6, 112579, 21, 6, 3 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 2014.0, 2, 165, 12, 324700, 47, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3987.0, 1, 187, 4, 347880, 13, 5, 1, 2008 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2374.0, 6, 450, 4, 463197, 13, 6, 3, 1991 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3210.0, 4, 331, 488183, 1, 5, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2441.0, 5, 302, 13, 439436, 49, 5, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3327.0, 5, 145, 5, 253807, 17, 2, 3, 2011 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2988.0, 6, 264, 11, 356877, 43, 3, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 6, 1263.0, 4, 166, 19, 264846, 73, 3, 2011 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2888.0, 6, 450, 14, 396098, 54, 5, 3, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 2252.0, 3, 388, 4, 97761, 13, 3, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2190.0, 3, 474, 16, 22201, 62, 5, 2, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId" },
                values: new object[] { 1640.0, 3, 68, 1, 497161, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3023.0, 2, 290, 7, 431952, 27, 6, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1571.0, 6, 409, 12, 176924, 46, 3, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1724.0, 2, 361, 2, 274808, 6, 6, 6, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1431.0, 6, 415, 14, 107546, 55, 1, 6, 1996 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3400.0, 3, 257, 5, 35846, 17, 4, 6, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 1577.0, 254, 4, 217224, 13, 4, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3067.0, 1, 120, 12, 74414, 45, 6, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 2207.0, 3, 178, 18, 169431, 70, 4, 4, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2021.0, 6, 454, 8, 489303, 29, 2, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1050.0, 3, 91, 3, 330407, 10, 5, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2576.0, 132, 10, 187319, 39, 3, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3636.0, 3, 222, 11, 45337, 43, 2, 1, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2430.0, 4, 96, 8, 131243, 31, 1, 3, 2011 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 3, 3706.0, 1, 176, 14, 398319, 54, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2668.0, 5, 120, 10, 325491, 39, 5, 5, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1428.0, 4, 442, 11, 136537, 41, 5, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2328.0, 130, 18, 422506, 71, 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1411.0, 334, 7, 228855, 27, 1, 3, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3635.0, 5, 337, 17, 61436, 65, 3, 3, 1996 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2034.0, 1, 334, 430566, 21, 1, 4, 2011 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1433.0, 2, 308, 16, 81938, 62, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3121.0, 2, 350, 14, 355728, 53, 1, 6, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 3748.0, 5, 480, 6, 177677, 23, 1, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2235.0, 5, 180, 7, 375186, 26, 2, 6, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2581.0, 4, 84, 5, 339503, 19, 2, 1, 2015 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 6, 3138.0, 2, 460, 477845, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3356.0, 3, 151, 10, 148213, 38, 4, 2003 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 8, 3186.0, 5, 60, 19, 243579, 74, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2960.0, 3, 453, 8, 417189, 31, 6, 1, 1992 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2433.0, 4, 115, 11, 232637, 41, 5, 1, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 3447.0, 299, 7, 256961, 25, 5, 5, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3998.0, 443, 12, 41497, 45, 6, 6, 1994 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1075.0, 5, 176, 19, 71869, 74, 5, 3, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2657.0, 136, 13, 230263, 49, 5, 1, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3803.0, 1, 243, 5, 463238, 19, 3, 5, 1994 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3311.0, 3, 361, 4, 93260, 13, 3, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3174.0, 1, 396, 15, 29760, 57, 3, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 2661.0, 151, 11, 156491, 42, 5, 3, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3658.0, 1, 92, 4, 359241, 15, 4, 1, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1424.0, 5, 496, 18, 251007, 69, 2, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3396.0, 5, 284, 12, 341377, 45, 1, 5, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1342.0, 6, 336, 5, 497957, 19, 6, 6, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2706.0, 1, 440, 5, 33102, 18, 4, 5, 2000 });

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
                columns: new[] { "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3153.0, 454, 2, 166014, 5, 3, 2011 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3312.0, 3, 224, 17, 367178, 65, 1, 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2577.0, 482, 18, 277265, 71, 6, 1, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1387.0, 5, 95, 17, 263831, 66, 5, 2, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1531.0, 3, 110, 13, 173559, 50, 2, 6, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 3943.0, 2, 478, 7, 46607, 26, 1, 2002 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3603.0, 4, 367, 329026, 6, 3, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1064.0, 1, 340, 6, 165417, 22, 4, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2501.0, 1, 475, 19, 327485, 75, 1, 4, 1995 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3341.0, 4, 280, 15, 324543, 57, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2696.0, 354, 5, 482876, 17, 6, 1998 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3816.0, 5, 279, 8, 273769, 30, 3, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3588.0, 1, 382, 1, 248976, 3, 6, 6, 2016 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2324.0, 1, 457, 2, 160203, 5, 5, 5, 1995 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2494.0, 2, 19, 309052, 75, 3, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3830.0, 3, 147, 16, 339410, 62, 3, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1751.0, 6, 294, 14, 469351, 53, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1104.0, 6, 82, 17, 276635, 67, 2, 6, 2005 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3047.0, 5, 330, 14, 242599, 53, 2, 3, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 4, 1741.0, 4, 205, 6, 450814, 22, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId" },
                values: new object[] { 4, 2718.0, 2, 286, 13, 269967, 50, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1388.0, 2, 380, 9, 498667, 33, 1, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 3860.0, 1, 491, 14, 401276, 54, 1, 2014 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2952.0, 3, 399, 6, 423733, 21, 4, 5, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2518.0, 1, 111, 7, 166241, 25, 2, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3747.0, 5, 416, 1, 443619, 1, 4, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2625.0, 374, 13, 465185, 49, 3, 6, 2006 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2947.0, 1, 181, 7, 166459, 27, 5, 3, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 2869.0, 464, 9, 145722, 33, 1, 3, 2019 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3175.0, 4, 149, 12, 295900, 45, 4, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 3711.0, 4, 498, 3, 254966, 11, 3, 2009 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2862.0, 3, 223, 16, 455223, 63, 3, 2, 2018 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2837.0, 6, 367, 6, 443074, 23, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 3301.0, 297, 17, 304633, 66, 3, 2, 2004 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2442.0, 171, 8, 86586, 29, 4, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 2641.0, 3, 203, 7, 69231, 26, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 4, 1766.0, 6, 297, 7, 495574, 27, 4, 2, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 1727.0, 4, 202, 16, 252761, 61, 1, 5, 2018 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 1880.0, 1, 193, 12, 239838, 46, 5, 2002 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2231.0, 3, 424, 10, 31449, 38, 2, 5, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1458.0, 3, 64, 8, 472582, 30, 1, 3, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 2137.0, 3, 328, 1, 296920, 1, 4, 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2234.0, 4, 455, 17, 394668, 67, 6, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1097.0, 2, 205, 19, 426358, 75, 5, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3276.0, 1, 285, 11, 113041, 42, 1, 3, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2421.0, 6, 407, 3, 282525, 10, 6, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2521.0, 6, 453, 16, 188143, 62, 2, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1605.0, 3, 405, 18, 225068, 70, 1, 5, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3336.0, 95, 16, 276274, 61, 3, 3, 2000 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3, 3884.0, 4, 159, 19, 414178, 74, 2, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 1957.0, 335, 18, 156529, 69, 6, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 1954.0, 3, 451, 8, 180536, 29, 6, 1, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3855.0, 2, 154, 6, 86021, 22, 5, 3, 1995 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 5, 3715.0, 1, 431, 5, 164436, 19, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 1440.0, 4, 197, 15, 110151, 58, 2, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1161.0, 3, 466, 15, 456625, 57, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 5, 3977.0, 436, 1, 398615, 3, 1, 2, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3032.0, 2, 164, 17, 164212, 67, 2, 3, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 5, 1886.0, 2, 255, 12, 61296, 47, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 4, 1376.0, 4, 118, 19, 201503, 73, 3, 1997 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1751.0, 2, 387, 3, 221450, 9, 1, 6, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 2539.0, 4, 200, 127882, 67, 3, 3, 1993 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2, 2054.0, 4, 418, 19, 377598, 74, 2, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2391.0, 2, 448, 12, 95111, 46, 2, 3, 1993 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "Year" },
                values: new object[] { 3, 1223.0, 3, 289, 14, 418233, 54, 1999 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 2609.0, 5, 149, 3, 354762, 9, 1, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 1, 1430.0, 2, 364, 14, 319661, 55, 1, 2001 });

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
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1395.0, 5, 466, 17, 72655, 65, 6, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 2749.0, 4, 440, 8, 404666, 30, 6, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3482.0, 6, 269, 16, 198884, 63, 2, 1, 2008 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 2453.0, 2, 91, 19, 62865, 75, 2, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 1704.0, 335, 18, 90952, 71, 6, 6, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2496.0, 5, 279, 9, 275202, 33, 4, 5, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 7, 2165.0, 4, 288, 3, 459721, 10, 3, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2124.0, 4, 312, 16, 191839, 61, 4, 4, 2010 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 6, 1889.0, 3, 286, 11, 35539, 43, 3, 5, 1992 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3223.0, 3, 360, 4, 324130, 14, 4, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 3978.0, 5, 465, 13, 60177, 50, 5, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 3470.0, 3, 456, 10, 284347, 39, 3, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "Year" },
                values: new object[] { 5, 2086.0, 1, 355, 7, 287312, 25, 5, 1994 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2046.0, 3, 68, 250926, 3, 1, 2, 2004 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 3, 1257.0, 1, 225, 9, 177251, 33, 4, 3, 1992 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1, 3310.0, 442, 17, 413463, 67, 2, 5, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "EngineDisplacement", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 7, 3831.0, 84, 5, 387348, 18, 5, 2, 1999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2, 1086.0, 6, 189, 3, 354568, 10, 1, 5, 1999 });

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
                columns: new[] { "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 8, 2495.0, 2, 415, 1, 177548, 3, 3, 4, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 2099.0, 1, 126, 14, 200151, 54, 2, 6, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EngineDisplacement", "FuelTypeId", "HorsePower", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[] { 1160.0, 3, 211, 8, 43655, 29, 1, 2, 2007 });

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
    }
}
