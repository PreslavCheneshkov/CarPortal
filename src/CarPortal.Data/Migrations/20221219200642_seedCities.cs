using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class seedCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15581a01-e081-4038-90ad-1a804aa32218", "AQAAAAEAACcQAAAAEKVEq/L6u8qITw0ikRH+UvAfOCJCBtpLFCZW5hc/1c4t0HQR0sFxAooZP12J14E5Dg==", "e4e83cd7-a8a3-4f56-98cc-92045905c7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34c9cf69-c25d-4310-af56-71f9353982bd", "AQAAAAEAACcQAAAAEHdwYFMvtQ+QbSYGDBfrqngd3jKlT2P+NnNbyY9hM8md/I4t7pB7F8n8f2OjHE5TIg==", "c6622668-be6c-4dc9-8bfd-29e59021d61c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6748fc8f-9e7f-4886-a564-49e87ddcae8f", "AQAAAAEAACcQAAAAEH0sJv41BRzVcQ9VZElXqAmFDty1A4H0DMUdPmbHthAJFMXzEES7o6aDflTRrtdq9w==", "75334a8b-8ff3-43a4-9a64-dbbbe3a835da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7f88131-7062-48dc-84ba-86e9529ff0c0", "AQAAAAEAACcQAAAAEFWgllERY63OavSr/2PU2wvFfJA+hnBdFuJUwSS/bkt+g9CaWggJ6OYAQPVN7whEHw==", "32cffa64-872b-4f17-a72b-ffcc83ed909d" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, "Varna", 1 },
                    { 2, "Aksakovo", 1 },
                    { 3, "Devnya", 1 },
                    { 4, "Provadiya", 1 },
                    { 5, "Kranevo", 1 },
                    { 6, "Sofia", 2 },
                    { 7, "Pravets", 2 },
                    { 8, "Pleven", 3 },
                    { 9, "Belene", 3 },
                    { 10, "Nikopol", 3 },
                    { 11, "Levski", 3 },
                    { 12, "Plovdiv", 4 },
                    { 13, "Asenovgrad", 4 },
                    { 14, "Rakovski", 4 },
                    { 15, "Burgas", 5 },
                    { 16, "Aytos", 5 },
                    { 17, "Nesebar", 5 },
                    { 18, "Veliko Turnovo", 6 },
                    { 19, "Svishtov", 6 },
                    { 20, "Gorna Oryahovica", 6 },
                    { 21, "Ruse", 7 },
                    { 22, "Byala", 7 },
                    { 23, "Tsar Kaloyan", 7 }
                });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 6, 41, 562, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 6, 41, 562, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 6, 41, 562, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 6, 41, 562, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de58911a-5a95-400e-b66b-fd465784229a", "AQAAAAEAACcQAAAAELW0CuGLhTY/dVvqQGfgyQ0qcjWbmVigJVRswf6C50QmBd/Fuzueg0v4lvTl0t5YKw==", "e75967c7-a7fa-4f65-afbb-263159cc54f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1599b271-fc59-4726-a4a1-49e1ecc43b20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cabbc300-b108-42a1-8652-6aeb72e359d7", "AQAAAAEAACcQAAAAEGc41BDAuSUMddkesf7TTt6CWa2EyUmlaGGBwHucNqSouUbV+4qIDL7D8zyHzFzhyw==", "83392f7d-0735-4c16-9466-28ba9e0f042d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6685d0bd-2872-4fb8-9ff9-8a6c0704c821",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bf498ab-0079-4c5e-8dbd-a05f9ccec98d", "AQAAAAEAACcQAAAAEE4NeKVMH9nA+IceGx8IG1AibTBUV+6v03bFUXkvC3bR4sv0/dV+oIXeECn8iQ4CJg==", "282527bb-b067-40d8-bfa0-2178134b319d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5797ab3c-7e57-4959-86c1-c5a956e55792", "AQAAAAEAACcQAAAAEP6HGkqDia0aEtFgbSHQ49ujIiEYWagPLAXcx9lG1qMzccgBAVjwCICzuP4zvfCZJw==", "7a638e03-e6c5-4cd9-895b-44bb3f1932f6" });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "243d758e-59b0-46bd-bc56-3b41c4adc264",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 4, 32, 285, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "69f4e8cc-b668-4bdc-9822-c6be05dbdc07",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 4, 32, 285, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "840f8101-dba1-4559-af43-a15af74d321c",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 4, 32, 285, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: "b477be35-f36e-4986-91a4-2af08b8aace9",
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 20, 4, 32, 285, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Regions_RegionId",
                table: "Cities",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
