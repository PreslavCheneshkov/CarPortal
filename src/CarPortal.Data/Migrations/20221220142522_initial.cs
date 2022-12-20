using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfferThumbnail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferThumbnail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransmissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarPortalUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDealer = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePictureAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_CarPortalUserId",
                        column: x => x.CarPortalUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleCategoryId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    EngineDisplacement = table.Column<double>(type: "float", nullable: true),
                    HorsePower = table.Column<int>(type: "int", nullable: true),
                    TransmissionTypeId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    IsBrandNew = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_TransmissionTypes_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalTable: "TransmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferThumbnailId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CarPortalProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offers_OfferThumbnail_OfferThumbnailId",
                        column: x => x.OfferThumbnailId,
                        principalTable: "OfferThumbnail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Offers_Profiles_CarPortalProfileId",
                        column: x => x.CarPortalProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Offers_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImage",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImage_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfferComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    CarPortalUserId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    OfferCommentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferComments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OfferComments_OfferComments_OfferCommentId",
                        column: x => x.OfferCommentId,
                        principalTable: "OfferComments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OfferComments_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilesInterestedOffers",
                columns: table => new
                {
                    CarPortalProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilesInterestedOffers", x => new { x.CarPortalProfileId, x.OfferId });
                    table.ForeignKey(
                        name: "FK_ProfilesInterestedOffers_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProfilesInterestedOffers_Profiles_CarPortalProfileId",
                        column: x => x.CarPortalProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", 10, "9226d908-cbd0-4567-a726-2d8e8fd3dec6", "admin@carportal.com", true, false, null, "ADMIN@CARPORTAL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBPxhRD1RmQfZgCWSWuquurNqlTGvQWL+fO9cW5nBUzrJ6Ytu3Ur7uAxQozZ5X3N3A==", null, true, "b477be35-f36e-4986-91a4-2af08b8aace9", "8a2dc4f8-8eb4-4f49-b1f0-7f5ab46f7b47", false, "admin" },
                    { "1599b271-fc59-4726-a4a1-49e1ecc43b20", 10, "3b7ccb0e-1f91-4362-a5c8-21eefb3b3b50", "dealer@carportal.com", true, false, null, "DEALER@CARPORTAL.COM", "DEALER", "AQAAAAEAACcQAAAAEHrpyaPiqsJqfZBzGew3nZ6ALKFIoo1T2gpKn56PnhcbvHRuqZ/huuiF9xPx2gn4YQ==", null, true, "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "054949bd-bbc4-4976-adb0-eb7ab7cdb9a9", false, "dealer" },
                    { "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", 10, "aeb9ce08-cc6e-46d0-b30b-cd84856d2cc3", "newsWriter@carportal.com", true, false, null, "NEWSWRITER@CARPORTAL.COM", "NEWSWRITER", "AQAAAAEAACcQAAAAEI1aDOfS3ss25/+jtWD93kvstiSnVEpxtGIgHeTcJbwlgi0xM1tEQCLKRbU7hPc/Dw==", null, true, "840f8101-dba1-4559-af43-a15af74d321c", "a9810a1b-9361-4e62-b699-147e8d680b3d", false, "newsWriter" },
                    { "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", 10, "7afbd59a-7c7f-4a56-92fb-a7be5a3daa7b", "regular@carportal.com", true, false, null, "REGULAR@CARPORTAL.COM", "REGULAR", "AQAAAAEAACcQAAAAEKlRJ+NSzIOkMCvZTacUpVgg6v5HBiRo33nv/j657xmmDc56fsNkNHFGKHWCk+Yxlg==", null, true, "243d758e-59b0-46bd-bc56-3b41c4adc264", "a235ed1b-56fc-4530-8da8-75c90eddbbb1", false, "regular" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "Blue" },
                    { 3, "Green" },
                    { 4, "Black" },
                    { 5, "White" },
                    { 6, "Silver" },
                    { 7, "Grey" },
                    { 8, "Yellow" },
                    { 9, "Orange" }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Leather seats" },
                    { 2, "LED Headlights" },
                    { 3, "Cruise Control" },
                    { 4, "Heated seats" },
                    { 5, "Navigation" },
                    { 6, "Sunroof" },
                    { 7, "Premium sound system" },
                    { 8, "7 seats" },
                    { 9, "Fogligths" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gasoline" },
                    { 2, "Diesel" },
                    { 3, "LPG" },
                    { 4, "Gasoline Hybrid" },
                    { 5, "EV" },
                    { 6, "Methane" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Volkswagen" },
                    { 2, "Audi" },
                    { 3, "Porsche" },
                    { 4, "BMW" },
                    { 5, "Mercedes-Benz" },
                    { 6, "Opel" },
                    { 7, "Honda" },
                    { 8, "Toyota" },
                    { 9, "Subaru" },
                    { 10, "Volvo" },
                    { 11, "Citroen" },
                    { 12, "Peugeot" },
                    { 13, "Renault" },
                    { 14, "Fiat" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 15, "Alfa Romeo" },
                    { 16, "Ford" },
                    { 17, "Dacia" },
                    { 18, "Seat" },
                    { 19, "Kia" },
                    { 20, "Hyundai" }
                });

            migrationBuilder.InsertData(
                table: "OfferThumbnail",
                columns: new[] { "Id", "Extension", "OfferId" },
                values: new object[,]
                {
                    { "firstSeedThumbnail", ".jpg", null },
                    { "secondSeedThumbnail", ".jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Varna" },
                    { 2, "Sofia" },
                    { 3, "Pleven" },
                    { 4, "Plovdiv" },
                    { 5, "Burgas" },
                    { 6, "Veliko Turnovo" },
                    { 7, "Ruse" }
                });

            migrationBuilder.InsertData(
                table: "TransmissionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manual 5-speed" },
                    { 2, "Manual 4-speed" },
                    { 3, "Manual 6-speed" },
                    { 4, "Automatic" },
                    { 5, "Automatic-robot" },
                    { 6, "Dual-clutch automatic" },
                    { 7, "CVT" }
                });

            migrationBuilder.InsertData(
                table: "VehicleCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "Estate" },
                    { 3, "Small SUV" },
                    { 4, "Large SUV" },
                    { 5, "Off-road SUV" },
                    { 6, "Coupe" },
                    { 7, "Hatchback" }
                });

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

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Golf" },
                    { 2, 1, "Passat" },
                    { 3, 1, "Arteon" },
                    { 4, 1, "Polo" },
                    { 5, 2, "A3" },
                    { 6, 2, "A4" },
                    { 7, 2, "A5" },
                    { 8, 2, "A6" },
                    { 9, 3, "911" },
                    { 10, 3, "718" },
                    { 11, 3, "Panamera" },
                    { 12, 3, "Cayenne" },
                    { 13, 4, "3-series" },
                    { 14, 4, "5-series" },
                    { 15, 4, "7-series" },
                    { 16, 4, "X3" },
                    { 17, 5, "A-class" },
                    { 18, 5, "C-class" },
                    { 19, 5, "E-class" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 20, 5, "S-class" },
                    { 21, 6, "Astra" },
                    { 22, 6, "Corsa" },
                    { 23, 6, "Signum" },
                    { 24, 6, "Vectra" },
                    { 25, 7, "Civic" },
                    { 26, 7, "Accord" },
                    { 27, 7, "Jazz" },
                    { 28, 7, "CR-V" },
                    { 29, 8, "Corolla" },
                    { 30, 8, "Auris" },
                    { 31, 8, "Yaris" },
                    { 32, 8, "LandCruiser" },
                    { 33, 9, "Forester" },
                    { 34, 9, "Impreza" },
                    { 35, 9, "Legacy" },
                    { 36, 9, "Crosstrek" },
                    { 37, 10, "V40" },
                    { 38, 10, "V60" },
                    { 39, 10, "XC40" },
                    { 40, 10, "XC60" },
                    { 41, 11, "C3" },
                    { 42, 11, "C4" },
                    { 43, 11, "C5" },
                    { 44, 11, "C6" },
                    { 45, 12, "306" },
                    { 46, 12, "406" },
                    { 47, 12, "307" },
                    { 48, 12, "407" },
                    { 49, 13, "Clio" },
                    { 50, 13, "Megane" },
                    { 51, 13, "Laguna" },
                    { 52, 13, "Twingo" },
                    { 53, 14, "Panda" },
                    { 54, 14, "500" },
                    { 55, 14, "124" },
                    { 56, 14, "Albea " },
                    { 57, 15, "156" },
                    { 58, 15, "147" },
                    { 59, 15, "159" },
                    { 60, 15, "GT" },
                    { 61, 16, "Focus" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 62, 16, "Fiesta" },
                    { 63, 16, "F-150" },
                    { 64, 16, "Mondeo" },
                    { 65, 17, "Duster" },
                    { 66, 17, "Sandero" },
                    { 67, 17, "Logan" },
                    { 68, 17, "Dokker" },
                    { 69, 18, "Ibiza" },
                    { 70, 18, "Toledo" },
                    { 71, 18, "Leon" },
                    { 72, 18, "Ateca" },
                    { 73, 19, "Stinger" },
                    { 74, 19, "Ceed" },
                    { 75, 19, "Sportage" },
                    { 76, 19, "K5" },
                    { 77, 20, "Tuscon" },
                    { 78, 20, "i30" },
                    { 79, 20, "i20" },
                    { 80, 20, "i10" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "CarPortalUserId", "CreatedDate", "IsDealer", "ProfilePictureAdress" },
                values: new object[,]
                {
                    { "243d758e-59b0-46bd-bc56-3b41c4adc264", "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", new DateTime(2022, 12, 20, 14, 25, 22, 222, DateTimeKind.Utc).AddTicks(7349), false, null },
                    { "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "1599b271-fc59-4726-a4a1-49e1ecc43b20", new DateTime(2022, 12, 20, 14, 25, 22, 222, DateTimeKind.Utc).AddTicks(7346), true, null },
                    { "840f8101-dba1-4559-af43-a15af74d321c", "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", new DateTime(2022, 12, 20, 14, 25, 22, 222, DateTimeKind.Utc).AddTicks(7343), false, null },
                    { "b477be35-f36e-4986-91a4-2af08b8aace9", "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", new DateTime(2022, 12, 20, 14, 25, 22, 222, DateTimeKind.Utc).AddTicks(7338), false, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 2374.0, 6, 246, false, 14, 164686, 54, 4, 6, 2011 },
                    { 2, 4, 3780.0, 5, 254, false, 3, 105059, 11, 1, 1, 1993 },
                    { 3, 8, 1906.0, 1, 417, false, 11, 97679, 41, 2, 3, 2001 },
                    { 4, 6, 1821.0, 2, 63, false, 6, 245895, 23, 4, 6, 2004 },
                    { 5, 6, 1100.0, 2, 94, false, 17, 400003, 66, 3, 4, 2010 },
                    { 6, 5, 3087.0, 4, 453, false, 4, 76069, 14, 1, 2, 2007 },
                    { 7, 6, 3293.0, 1, 213, false, 14, 282073, 55, 1, 2, 2005 },
                    { 8, 5, 2718.0, 4, 338, false, 2, 294006, 5, 1, 6, 1996 },
                    { 9, 5, 1316.0, 4, 198, false, 1, 339825, 1, 4, 4, 2001 },
                    { 10, 3, 2781.0, 5, 308, false, 10, 460966, 38, 3, 1, 1994 },
                    { 11, 7, 3203.0, 4, 186, false, 5, 406960, 18, 4, 6, 1997 },
                    { 12, 4, 3438.0, 6, 241, false, 7, 458388, 26, 1, 1, 1997 },
                    { 13, 7, 3787.0, 2, 264, false, 8, 140317, 31, 3, 5, 2016 },
                    { 14, 7, 1416.0, 3, 375, false, 2, 433611, 7, 4, 1, 2002 },
                    { 15, 5, 2761.0, 5, 97, false, 3, 350150, 10, 3, 2, 1998 },
                    { 16, 5, 2805.0, 5, 335, false, 15, 23695, 57, 1, 6, 2001 },
                    { 17, 8, 3256.0, 6, 335, false, 10, 159867, 39, 2, 2, 2000 },
                    { 18, 4, 3257.0, 5, 382, false, 19, 234905, 73, 6, 6, 2006 },
                    { 19, 3, 2346.0, 2, 483, false, 9, 236385, 33, 1, 1, 1992 },
                    { 20, 5, 2185.0, 4, 104, false, 12, 269509, 46, 6, 4, 2010 },
                    { 21, 5, 3322.0, 5, 88, false, 18, 299887, 70, 2, 1, 2002 },
                    { 22, 5, 2067.0, 5, 326, false, 8, 359311, 30, 2, 5, 2005 },
                    { 23, 4, 1251.0, 2, 158, false, 9, 290855, 35, 3, 4, 2003 },
                    { 24, 3, 3749.0, 3, 238, false, 12, 118975, 46, 3, 3, 2021 },
                    { 25, 3, 2928.0, 1, 401, false, 5, 403010, 18, 1, 3, 2016 },
                    { 26, 1, 2752.0, 1, 262, false, 2, 372666, 6, 2, 4, 2012 },
                    { 27, 7, 1664.0, 4, 196, false, 7, 437379, 27, 5, 4, 2018 },
                    { 28, 7, 3615.0, 3, 134, false, 11, 98103, 41, 2, 3, 2020 },
                    { 29, 4, 3889.0, 6, 196, false, 13, 118089, 49, 1, 6, 2019 },
                    { 30, 4, 2528.0, 4, 380, false, 10, 24819, 39, 1, 1, 1998 },
                    { 31, 1, 2702.0, 2, 417, false, 14, 320276, 53, 1, 5, 2014 },
                    { 32, 4, 1583.0, 6, 147, false, 19, 355144, 74, 5, 1, 1998 },
                    { 33, 3, 3464.0, 5, 497, false, 17, 381007, 66, 6, 2, 1993 },
                    { 34, 6, 3958.0, 4, 329, false, 15, 291928, 57, 4, 4, 1998 },
                    { 35, 7, 2682.0, 5, 199, false, 7, 132267, 25, 4, 4, 2009 },
                    { 36, 4, 1120.0, 1, 118, false, 8, 94827, 31, 5, 5, 1999 },
                    { 37, 5, 3795.0, 4, 481, false, 13, 194531, 51, 3, 3, 1999 },
                    { 38, 1, 1305.0, 1, 497, false, 11, 367986, 41, 3, 2, 2011 },
                    { 39, 1, 1786.0, 3, 462, false, 11, 166063, 41, 4, 5, 1995 },
                    { 40, 7, 2209.0, 2, 333, false, 18, 50393, 69, 1, 6, 1991 },
                    { 41, 2, 2059.0, 5, 423, false, 12, 412941, 46, 5, 6, 1996 },
                    { 42, 8, 2211.0, 3, 376, false, 5, 420167, 17, 6, 5, 1991 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 43, 4, 2433.0, 2, 329, false, 15, 35955, 59, 1, 1, 1994 },
                    { 44, 8, 1469.0, 5, 79, false, 9, 103972, 33, 5, 6, 2002 },
                    { 45, 4, 2531.0, 5, 266, false, 15, 217026, 58, 5, 3, 2013 },
                    { 46, 1, 3154.0, 4, 181, false, 2, 335200, 7, 1, 4, 1992 },
                    { 47, 8, 1150.0, 5, 360, false, 12, 402011, 47, 5, 5, 2016 },
                    { 48, 8, 3073.0, 1, 286, false, 13, 30264, 50, 1, 5, 1992 },
                    { 49, 2, 1098.0, 2, 233, false, 8, 124742, 29, 4, 4, 2019 },
                    { 50, 2, 1259.0, 1, 255, false, 12, 270002, 46, 1, 2, 2000 },
                    { 51, 2, 2017.0, 1, 236, false, 8, 223303, 29, 2, 5, 1990 },
                    { 52, 4, 2130.0, 5, 83, false, 19, 154587, 75, 5, 1, 2013 },
                    { 53, 8, 3412.0, 1, 407, false, 8, 42935, 30, 5, 3, 2007 },
                    { 54, 3, 1857.0, 2, 168, false, 12, 212454, 46, 1, 6, 2006 },
                    { 55, 7, 2023.0, 4, 107, false, 8, 109587, 30, 4, 1, 1995 },
                    { 56, 5, 2489.0, 6, 443, false, 18, 106026, 71, 6, 4, 1991 },
                    { 57, 4, 2496.0, 5, 97, false, 4, 461906, 15, 3, 2, 2002 },
                    { 58, 1, 2100.0, 1, 371, false, 9, 438581, 33, 6, 2, 1990 },
                    { 59, 2, 2134.0, 4, 163, false, 13, 270955, 50, 5, 5, 2010 },
                    { 60, 1, 1026.0, 3, 499, false, 6, 259436, 22, 4, 6, 1994 },
                    { 61, 5, 2631.0, 1, 481, false, 14, 259405, 53, 5, 2, 2004 },
                    { 62, 1, 2707.0, 6, 129, false, 13, 378494, 51, 2, 3, 2003 },
                    { 63, 8, 1338.0, 3, 485, false, 1, 219331, 2, 6, 6, 2013 },
                    { 64, 8, 2987.0, 2, 286, false, 5, 490474, 17, 6, 4, 1999 },
                    { 65, 3, 1417.0, 4, 86, false, 12, 172660, 47, 2, 4, 1990 },
                    { 66, 8, 2744.0, 5, 460, false, 1, 322930, 1, 5, 6, 2010 },
                    { 67, 8, 3581.0, 6, 464, false, 14, 24454, 55, 3, 3, 1992 },
                    { 68, 3, 1831.0, 5, 223, false, 10, 386196, 37, 5, 2, 2001 },
                    { 69, 3, 3391.0, 1, 455, false, 15, 319995, 58, 3, 6, 2006 },
                    { 70, 3, 1969.0, 5, 226, false, 17, 109434, 65, 1, 1, 1993 },
                    { 71, 8, 2859.0, 6, 388, false, 6, 209789, 22, 6, 6, 2008 },
                    { 72, 5, 1113.0, 5, 442, false, 10, 66548, 38, 6, 4, 2009 },
                    { 73, 6, 1756.0, 5, 348, false, 7, 478409, 25, 5, 6, 1997 },
                    { 74, 4, 1657.0, 1, 417, false, 2, 135831, 6, 5, 1, 2012 },
                    { 75, 7, 1454.0, 6, 287, false, 9, 271223, 33, 1, 3, 1995 },
                    { 76, 7, 3095.0, 4, 286, false, 5, 309835, 19, 5, 1, 1996 },
                    { 77, 7, 1293.0, 4, 337, false, 16, 165333, 62, 3, 5, 2021 },
                    { 78, 4, 2372.0, 2, 156, false, 14, 384029, 55, 1, 6, 2019 },
                    { 79, 8, 2802.0, 6, 304, false, 10, 44749, 38, 2, 1, 2021 },
                    { 80, 4, 1747.0, 1, 491, false, 7, 82639, 27, 2, 6, 1992 },
                    { 81, 1, 2348.0, 1, 118, false, 5, 76263, 19, 2, 1, 1997 },
                    { 82, 5, 1775.0, 3, 177, false, 11, 308705, 43, 1, 1, 2007 },
                    { 83, 5, 3654.0, 1, 313, false, 6, 362946, 21, 6, 6, 2003 },
                    { 84, 1, 1464.0, 2, 142, false, 1, 283059, 1, 6, 4, 2006 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 85, 4, 2921.0, 2, 346, false, 15, 124640, 59, 3, 6, 1995 },
                    { 86, 7, 3028.0, 2, 173, false, 18, 297206, 71, 6, 4, 2017 },
                    { 87, 1, 1177.0, 5, 374, false, 7, 306658, 26, 6, 6, 2008 },
                    { 88, 5, 2601.0, 6, 337, false, 8, 346988, 30, 2, 6, 1994 },
                    { 89, 1, 3612.0, 3, 317, false, 2, 266021, 7, 4, 3, 2015 },
                    { 90, 7, 2123.0, 5, 206, false, 14, 120141, 54, 2, 6, 2011 },
                    { 91, 8, 2931.0, 5, 242, false, 15, 125103, 58, 2, 3, 1999 },
                    { 92, 3, 3977.0, 5, 351, false, 1, 417022, 3, 1, 4, 2016 },
                    { 93, 7, 2390.0, 3, 243, false, 9, 29076, 35, 1, 6, 1990 },
                    { 94, 1, 1771.0, 5, 440, false, 16, 86775, 61, 4, 5, 2011 },
                    { 95, 4, 1722.0, 6, 442, false, 13, 381825, 50, 5, 3, 2020 },
                    { 96, 2, 2475.0, 3, 97, false, 7, 227372, 25, 1, 3, 2011 },
                    { 97, 2, 3403.0, 6, 78, false, 5, 227792, 18, 4, 5, 2001 },
                    { 98, 5, 2306.0, 1, 405, false, 14, 458708, 53, 1, 4, 2006 },
                    { 99, 2, 2254.0, 4, 319, false, 19, 37019, 75, 1, 1, 1990 },
                    { 100, 8, 3480.0, 3, 421, false, 19, 484660, 75, 5, 1, 2002 },
                    { 101, 6, 2663.0, 2, 313, false, 4, 217379, 13, 4, 5, 1991 },
                    { 102, 4, 1585.0, 5, 192, false, 16, 337728, 61, 6, 2, 2012 },
                    { 103, 8, 1127.0, 3, 446, false, 4, 462803, 13, 5, 1, 1991 },
                    { 104, 2, 1003.0, 3, 443, false, 14, 335353, 54, 1, 6, 2011 },
                    { 105, 5, 2380.0, 4, 452, false, 1, 229601, 3, 5, 1, 2003 },
                    { 106, 4, 1614.0, 4, 209, false, 6, 134662, 23, 3, 5, 2014 },
                    { 107, 2, 2140.0, 2, 136, false, 2, 395856, 5, 1, 4, 1992 },
                    { 108, 8, 2689.0, 4, 69, false, 7, 206056, 27, 4, 6, 1993 },
                    { 109, 2, 3948.0, 4, 396, false, 7, 94367, 25, 5, 4, 2001 },
                    { 110, 5, 1773.0, 6, 330, false, 11, 491900, 42, 2, 2, 1996 },
                    { 111, 3, 3646.0, 6, 317, false, 5, 358633, 18, 4, 6, 2019 },
                    { 112, 5, 3981.0, 6, 487, false, 1, 123413, 1, 2, 2, 1991 },
                    { 113, 4, 2114.0, 4, 360, false, 15, 251130, 57, 2, 3, 1995 },
                    { 114, 3, 3450.0, 2, 122, false, 3, 491904, 10, 1, 3, 2007 },
                    { 115, 3, 2019.0, 1, 262, false, 18, 218076, 70, 6, 6, 2016 },
                    { 116, 2, 3332.0, 5, 291, false, 6, 406554, 21, 3, 6, 1997 },
                    { 117, 3, 1609.0, 4, 279, false, 13, 345382, 51, 6, 4, 1997 },
                    { 118, 2, 1268.0, 6, 477, false, 18, 139975, 71, 1, 5, 2012 },
                    { 119, 7, 2917.0, 2, 106, false, 3, 432754, 11, 2, 5, 2004 },
                    { 120, 3, 3365.0, 6, 355, false, 10, 328748, 37, 5, 5, 1993 },
                    { 121, 5, 2450.0, 1, 482, false, 18, 131499, 69, 2, 6, 1999 },
                    { 122, 2, 2328.0, 2, 305, false, 1, 457747, 1, 5, 4, 2018 },
                    { 123, 7, 2510.0, 6, 191, false, 5, 239358, 19, 4, 6, 2011 },
                    { 124, 8, 3484.0, 5, 494, false, 7, 413568, 27, 3, 3, 2020 },
                    { 125, 8, 1488.0, 1, 256, false, 5, 412795, 19, 4, 5, 2013 },
                    { 126, 3, 2856.0, 1, 175, false, 8, 478576, 29, 1, 4, 1995 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 127, 4, 1009.0, 4, 338, false, 19, 186136, 75, 4, 1, 2000 },
                    { 128, 2, 1963.0, 5, 355, false, 18, 209497, 70, 5, 6, 2011 },
                    { 129, 7, 2296.0, 1, 266, false, 12, 194517, 45, 4, 6, 2010 },
                    { 130, 1, 1615.0, 3, 230, false, 14, 61738, 55, 5, 6, 2016 },
                    { 131, 8, 3475.0, 4, 382, false, 17, 165660, 65, 3, 6, 1990 },
                    { 132, 3, 1986.0, 6, 253, false, 3, 44041, 9, 5, 5, 1996 },
                    { 133, 8, 3602.0, 1, 184, false, 9, 62183, 34, 1, 5, 2018 },
                    { 134, 5, 2560.0, 1, 90, false, 18, 212827, 70, 1, 6, 1992 },
                    { 135, 1, 2748.0, 6, 160, false, 18, 383159, 69, 5, 3, 2007 },
                    { 136, 8, 1675.0, 1, 187, false, 13, 238770, 50, 4, 2, 2012 },
                    { 137, 6, 2210.0, 2, 367, false, 17, 396686, 66, 5, 1, 2013 },
                    { 138, 3, 2315.0, 4, 273, false, 13, 402100, 49, 3, 2, 2012 },
                    { 139, 6, 1942.0, 3, 323, false, 10, 335212, 37, 4, 1, 1997 },
                    { 140, 8, 2978.0, 4, 238, false, 17, 76147, 65, 1, 5, 1996 },
                    { 141, 1, 3638.0, 5, 67, false, 15, 464137, 59, 2, 6, 2016 },
                    { 142, 1, 2790.0, 6, 69, false, 14, 267822, 55, 1, 1, 2012 },
                    { 143, 2, 1438.0, 5, 467, false, 19, 66415, 75, 6, 3, 2019 },
                    { 144, 2, 3109.0, 6, 418, false, 5, 283397, 19, 5, 2, 2006 },
                    { 145, 2, 1280.0, 5, 460, false, 5, 425709, 18, 4, 1, 1999 },
                    { 146, 1, 3987.0, 2, 72, false, 6, 238601, 23, 5, 5, 2016 },
                    { 147, 3, 2365.0, 6, 439, false, 11, 316472, 41, 1, 4, 2004 },
                    { 148, 4, 2172.0, 6, 435, false, 13, 359820, 49, 2, 6, 1990 },
                    { 149, 6, 3940.0, 1, 184, false, 11, 247160, 42, 6, 1, 2007 },
                    { 150, 1, 3215.0, 1, 324, false, 1, 217629, 3, 5, 4, 2002 },
                    { 151, 6, 3812.0, 1, 361, false, 6, 124949, 22, 1, 3, 1990 },
                    { 152, 5, 1758.0, 2, 469, false, 16, 187816, 63, 5, 2, 2009 },
                    { 153, 3, 2868.0, 6, 479, false, 11, 59318, 43, 5, 1, 1992 },
                    { 154, 1, 2364.0, 4, 347, false, 4, 29972, 15, 3, 4, 2009 },
                    { 155, 8, 2720.0, 4, 152, false, 4, 156540, 14, 1, 2, 2007 },
                    { 156, 4, 2263.0, 6, 65, false, 3, 27603, 11, 2, 6, 2018 },
                    { 157, 6, 1394.0, 2, 474, false, 7, 45965, 26, 3, 3, 2001 },
                    { 158, 6, 1345.0, 1, 249, false, 6, 24890, 22, 5, 3, 2012 },
                    { 159, 4, 2574.0, 3, 80, false, 15, 389813, 58, 5, 3, 1998 },
                    { 160, 1, 3518.0, 4, 484, false, 9, 27546, 35, 3, 1, 2014 },
                    { 161, 6, 2610.0, 4, 372, false, 18, 440128, 71, 6, 6, 2014 },
                    { 162, 4, 3396.0, 1, 364, false, 5, 20991, 18, 5, 2, 2014 },
                    { 163, 2, 2028.0, 5, 76, false, 11, 374503, 42, 2, 1, 2009 },
                    { 164, 5, 1646.0, 3, 281, false, 4, 403357, 15, 3, 6, 1991 },
                    { 165, 3, 1099.0, 6, 184, false, 14, 163204, 54, 5, 3, 2018 },
                    { 166, 6, 2965.0, 2, 106, false, 16, 272001, 62, 4, 3, 1994 },
                    { 167, 1, 3317.0, 3, 104, false, 5, 360308, 19, 1, 6, 2018 },
                    { 168, 5, 2539.0, 5, 359, false, 15, 384825, 57, 6, 4, 2005 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 169, 6, 2046.0, 6, 329, false, 12, 72932, 47, 5, 1, 1990 },
                    { 170, 4, 2749.0, 5, 147, false, 9, 113382, 35, 3, 1, 2009 },
                    { 171, 4, 1017.0, 2, 145, false, 6, 373775, 23, 3, 5, 2009 },
                    { 172, 3, 2588.0, 3, 151, false, 5, 246630, 17, 2, 6, 1994 },
                    { 173, 7, 3945.0, 2, 88, false, 4, 256282, 13, 5, 4, 2017 },
                    { 174, 4, 3922.0, 4, 160, false, 7, 44362, 27, 6, 1, 2004 },
                    { 175, 3, 2980.0, 2, 273, false, 1, 387602, 2, 2, 1, 2019 },
                    { 176, 7, 1607.0, 6, 110, false, 1, 376646, 3, 3, 6, 1990 },
                    { 177, 4, 2708.0, 2, 187, false, 16, 142111, 61, 4, 1, 2000 },
                    { 178, 7, 1569.0, 1, 92, false, 15, 262562, 57, 2, 3, 1991 },
                    { 179, 1, 2900.0, 4, 95, false, 19, 339024, 75, 3, 5, 2004 },
                    { 180, 6, 2697.0, 4, 398, false, 18, 294521, 70, 6, 6, 1993 },
                    { 181, 6, 1701.0, 3, 422, false, 13, 220232, 51, 6, 5, 2019 },
                    { 182, 2, 1861.0, 5, 164, false, 17, 152671, 67, 6, 6, 2019 },
                    { 183, 7, 3018.0, 2, 463, false, 17, 465789, 66, 2, 4, 2000 },
                    { 184, 2, 2329.0, 4, 340, false, 18, 298605, 71, 3, 2, 1990 },
                    { 185, 6, 2498.0, 6, 229, false, 5, 151267, 19, 3, 6, 1992 },
                    { 186, 6, 3934.0, 1, 208, false, 10, 265584, 39, 1, 3, 1991 },
                    { 187, 2, 3672.0, 6, 309, false, 13, 425946, 51, 3, 6, 2001 },
                    { 188, 8, 1393.0, 4, 249, false, 18, 216655, 69, 2, 1, 2006 },
                    { 189, 2, 2156.0, 5, 469, false, 1, 145638, 3, 3, 4, 1997 },
                    { 190, 8, 1238.0, 1, 350, false, 10, 449525, 38, 6, 1, 2016 },
                    { 191, 7, 3451.0, 2, 182, false, 18, 103637, 71, 4, 2, 1993 },
                    { 192, 1, 2280.0, 5, 224, false, 1, 181112, 2, 2, 3, 1993 },
                    { 193, 6, 2400.0, 1, 468, false, 16, 112683, 63, 4, 4, 1998 },
                    { 194, 6, 1328.0, 4, 479, false, 18, 283779, 70, 2, 3, 2002 },
                    { 195, 2, 2510.0, 3, 362, false, 19, 37619, 75, 5, 1, 2001 },
                    { 196, 5, 1622.0, 4, 70, false, 10, 457002, 37, 5, 4, 1999 },
                    { 197, 7, 1830.0, 3, 341, false, 7, 417397, 26, 5, 5, 1999 },
                    { 198, 8, 2368.0, 3, 333, false, 5, 410343, 18, 2, 2, 1996 },
                    { 199, 7, 1558.0, 4, 371, false, 11, 173071, 43, 6, 1, 2009 },
                    { 200, 5, 2455.0, 3, 437, false, 6, 23661, 23, 2, 6, 2015 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 1, "", 1, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7664), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7665), "SeedOffer #1", null, 37247m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 2, "", 2, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7699), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7700), "SeedOffer #2", null, 21137m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 3, "", 3, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7702), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7702), "SeedOffer #3", null, 21057m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 4, "", 4, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7704), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7705), "SeedOffer #4", null, 11892m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 5, "", 5, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7707), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7707), "SeedOffer #5", null, 2625m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 6, "", 6, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7711), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7711), "SeedOffer #6", null, 15450m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 7, "", 7, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7713), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7713), "SeedOffer #7", null, 20427m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 8, "", 8, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7715), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7715), "SeedOffer #8", null, 6100m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 9, "", 9, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7717), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7717), "SeedOffer #9", null, 28592m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 10, "", 10, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7720), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7720), "SeedOffer #10", null, 9354m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 11, "", 11, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7722), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7723), "SeedOffer #11", null, 24703m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 12, "", 12, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7725), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7725), "SeedOffer #12", null, 19296m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 13, "", 13, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7727), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7727), "SeedOffer #13", null, 34047m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 14, "", 14, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7729), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7729), "SeedOffer #14", null, 28857m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 15, "", 15, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7731), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7731), "SeedOffer #15", null, 22616m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 16, "", 16, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7733), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7733), "SeedOffer #16", null, 38948m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 17, "", 17, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7735), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7736), "SeedOffer #17", null, 30928m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 18, "", 18, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7738), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7738), "SeedOffer #18", null, 4828m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 19, "", 19, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7740), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7741), "SeedOffer #19", null, 4229m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 20, "", 20, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7742), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7743), "SeedOffer #20", null, 39268m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 21, "", 21, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7744), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7745), "SeedOffer #21", null, 3820m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 22, "", 22, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7746), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7747), "SeedOffer #22", null, 26026m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 23, "", 23, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7748), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7749), "SeedOffer #23", null, 29371m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 24, "", 24, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7750), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7750), "SeedOffer #24", null, 21261m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 25, "", 25, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7752), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7753), "SeedOffer #25", null, 33810m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 26, "", 26, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7754), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7755), "SeedOffer #26", null, 1998m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 27, "", 27, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7757), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7757), "SeedOffer #27", null, 35573m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 28, "", 28, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7759), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7759), "SeedOffer #28", null, 18147m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 29, "", 29, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7784), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7785), "SeedOffer #29", null, 4845m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 30, "", 30, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7787), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7787), "SeedOffer #30", null, 30028m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 31, "", 31, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7788), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7789), "SeedOffer #31", null, 28487m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 32, "", 32, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7790), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7791), "SeedOffer #32", null, 12106m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 33, "", 33, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7792), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7793), "SeedOffer #33", null, 34818m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 34, "", 34, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7795), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7796), "SeedOffer #34", null, 30486m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 35, "", 35, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7798), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7798), "SeedOffer #35", null, 9862m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 36, "", 36, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7800), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7800), "SeedOffer #36", null, 22801m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 37, "", 37, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7802), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7802), "SeedOffer #37", null, 10140m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 38, "", 38, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7804), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7804), "SeedOffer #38", null, 8532m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 39, "", 39, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7806), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7806), "SeedOffer #39", null, 29518m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 40, "", 40, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7808), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7808), "SeedOffer #40", null, 27104m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 41, "", 41, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7810), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7811), "SeedOffer #41", null, 2632m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 42, "", 42, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7813), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7813), "SeedOffer #42", null, 21925m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 43, "", 43, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7815), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7815), "SeedOffer #43", null, 12995m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 44, "", 44, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7817), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7817), "SeedOffer #44", null, 22326m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 45, "", 45, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7818), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7819), "SeedOffer #45", null, 15916m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 46, "", 46, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7821), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7821), "SeedOffer #46", null, 39556m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 47, "", 47, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7823), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7823), "SeedOffer #47", null, 24114m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 48, "", 48, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7825), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7825), "SeedOffer #48", null, 2184m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 49, "", 49, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7827), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7827), "SeedOffer #49", null, 23333m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 50, "", 50, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7828), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7829), "SeedOffer #50", null, 38654m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 51, "", 51, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7831), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7831), "SeedOffer #51", null, 13258m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 52, "", 52, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7833), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7833), "SeedOffer #52", null, 37852m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 53, "", 53, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7834), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7835), "SeedOffer #53", null, 39188m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 54, "", 54, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7836), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7837), "SeedOffer #54", null, 19011m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 55, "", 55, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7838), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7839), "SeedOffer #55", null, 19856m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 56, "", 56, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7864), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7865), "SeedOffer #56", null, 31657m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 57, "", 57, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7867), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7867), "SeedOffer #57", null, 5734m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 58, "", 58, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7869), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7870), "SeedOffer #58", null, 34748m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 59, "", 59, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7871), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7872), "SeedOffer #59", null, 20074m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 60, "", 60, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7874), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7874), "SeedOffer #60", null, 29751m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 61, "", 61, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7876), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7877), "SeedOffer #61", null, 19061m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 62, "", 62, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7878), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7879), "SeedOffer #62", null, 35276m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 63, "", 63, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7881), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7881), "SeedOffer #63", null, 15793m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 64, "", 64, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7883), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7883), "SeedOffer #64", null, 9924m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 65, "", 65, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7885), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7885), "SeedOffer #65", null, 2703m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 66, "", 66, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7887), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7888), "SeedOffer #66", null, 15266m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 67, "", 67, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7889), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7890), "SeedOffer #67", null, 3607m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 68, "", 68, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7891), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7892), "SeedOffer #68", null, 29828m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 69, "", 69, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7893), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7894), "SeedOffer #69", null, 38354m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 70, "", 70, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7895), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7896), "SeedOffer #70", null, 20788m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 71, "", 71, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7898), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7898), "SeedOffer #71", null, 22757m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 72, "", 72, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7900), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7900), "SeedOffer #72", null, 698m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 73, "", 73, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7902), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7902), "SeedOffer #73", null, 12104m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 74, "", 74, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7904), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7905), "SeedOffer #74", null, 14829m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 75, "", 75, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7907), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7907), "SeedOffer #75", null, 38207m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 76, "", 76, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7909), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7909), "SeedOffer #76", null, 5379m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 77, "", 77, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7911), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7911), "SeedOffer #77", null, 21106m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 78, "", 78, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7913), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7913), "SeedOffer #78", null, 20404m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 79, "", 79, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7915), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7915), "SeedOffer #79", null, 34321m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 80, "", 80, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7917), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7917), "SeedOffer #80", null, 31144m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 81, "", 81, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7919), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7919), "SeedOffer #81", null, 7566m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 82, "", 82, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7968), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7969), "SeedOffer #82", null, 2365m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 83, "", 83, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7970), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7970), "SeedOffer #83", null, 26765m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 84, "", 84, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7972), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7973), "SeedOffer #84", null, 15594m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 85, "", 85, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7974), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7974), "SeedOffer #85", null, 791m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 86, "", 86, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7976), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7977), "SeedOffer #86", null, 8735m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 87, "", 87, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7978), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7978), "SeedOffer #87", null, 30841m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 88, "", 88, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7980), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7980), "SeedOffer #88", null, 36874m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 89, "", 89, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7982), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7983), "SeedOffer #89", null, 2762m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 90, "", 90, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7985), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7985), "SeedOffer #90", null, 5268m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 91, "", 91, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7987), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7987), "SeedOffer #91", null, 18296m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 92, "", 92, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7989), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7989), "SeedOffer #92", null, 21466m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 93, "", 93, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7991), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7991), "SeedOffer #93", null, 24059m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 94, "", 94, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7993), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7993), "SeedOffer #94", null, 14736m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 95, "", 95, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7995), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7996), "SeedOffer #95", null, 8141m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 96, "", 96, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7998), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(7998), "SeedOffer #96", null, 24942m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 97, "", 97, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8000), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8000), "SeedOffer #97", null, 11185m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 98, "", 98, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8002), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8003), "SeedOffer #98", null, 11796m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 99, "", 99, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8004), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8005), "SeedOffer #99", null, 19691m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 100, "", 100, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8007), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8007), "SeedOffer #100", null, 12469m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 101, "", 101, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8009), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8009), "SeedOffer #101", null, 16167m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 102, "", 102, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8011), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8011), "SeedOffer #102", null, 34385m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 103, "", 103, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8013), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8013), "SeedOffer #103", null, 1492m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 104, "", 104, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8015), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8015), "SeedOffer #104", null, 23753m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 105, "", 105, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8017), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8018), "SeedOffer #105", null, 28587m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 106, "", 106, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8019), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8020), "SeedOffer #106", null, 14876m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 107, "", 107, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8021), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8022), "SeedOffer #107", null, 22624m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 108, "", 108, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8023), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8023), "SeedOffer #108", null, 34500m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 109, "", 109, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8025), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8025), "SeedOffer #109", null, 6227m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 110, "", 110, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8052), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8052), "SeedOffer #110", null, 32481m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 111, "", 111, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8054), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8055), "SeedOffer #111", null, 25994m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 112, "", 112, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8056), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8057), "SeedOffer #112", null, 832m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 113, "", 113, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8058), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8059), "SeedOffer #113", null, 16602m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 114, "", 114, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8060), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8061), "SeedOffer #114", null, 31407m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 115, "", 115, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8062), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8062), "SeedOffer #115", null, 3988m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 116, "", 116, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8064), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8065), "SeedOffer #116", null, 29738m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 117, "", 117, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8066), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8067), "SeedOffer #117", null, 5275m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 118, "", 118, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8068), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8069), "SeedOffer #118", null, 13858m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 119, "", 119, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8070), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8070), "SeedOffer #119", null, 8645m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 120, "", 120, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8072), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8073), "SeedOffer #120", null, 12716m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 121, "", 121, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8074), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8074), "SeedOffer #121", null, 25417m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 122, "", 122, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8076), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8077), "SeedOffer #122", null, 20149m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 123, "", 123, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8078), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8079), "SeedOffer #123", null, 3311m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 124, "", 124, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8080), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8081), "SeedOffer #124", null, 4480m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 125, "", 125, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8082), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8083), "SeedOffer #125", null, 22887m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 126, "", 126, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8085), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8085), "SeedOffer #126", null, 16361m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 127, "", 127, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8087), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8087), "SeedOffer #127", null, 20213m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 128, "", 128, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8089), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8089), "SeedOffer #128", null, 12776m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 129, "", 129, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8090), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8091), "SeedOffer #129", null, 33788m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 130, "", 130, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8094), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8094), "SeedOffer #130", null, 34411m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 131, "", 131, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8096), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8096), "SeedOffer #131", null, 3057m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 132, "", 132, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8122), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8122), "SeedOffer #132", null, 14741m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 133, "", 133, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8124), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8124), "SeedOffer #133", null, 36414m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 134, "", 134, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8126), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8127), "SeedOffer #134", null, 3374m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 135, "", 135, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8128), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8129), "SeedOffer #135", null, 11094m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 136, "", 136, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8130), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8131), "SeedOffer #136", null, 24871m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 137, "", 137, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8132), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8133), "SeedOffer #137", null, 6517m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 138, "", 138, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8134), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8135), "SeedOffer #138", null, 33504m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 139, "", 139, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8136), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8137), "SeedOffer #139", null, 15487m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 140, "", 140, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8138), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8139), "SeedOffer #140", null, 29959m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 141, "", 141, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8141), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8141), "SeedOffer #141", null, 26517m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 142, "", 142, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8143), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8143), "SeedOffer #142", null, 34184m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 143, "", 143, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8145), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8145), "SeedOffer #143", null, 5245m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 144, "", 144, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8147), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8147), "SeedOffer #144", null, 34842m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 145, "", 145, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8149), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8149), "SeedOffer #145", null, 9742m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 146, "", 146, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8151), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8151), "SeedOffer #146", null, 11339m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 147, "", 147, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8153), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8154), "SeedOffer #147", null, 13078m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 148, "", 148, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8155), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8156), "SeedOffer #148", null, 16367m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 149, "", 149, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8157), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8158), "SeedOffer #149", null, 2095m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 150, "", 150, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8160), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8160), "SeedOffer #150", null, 38861m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 151, "", 151, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8162), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8162), "SeedOffer #151", null, 9670m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 152, "", 152, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8164), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8164), "SeedOffer #152", null, 29490m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 153, "", 153, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8166), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8166), "SeedOffer #153", null, 30352m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 154, "", 154, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8168), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8168), "SeedOffer #154", null, 15907m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 155, "", 155, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8170), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8170), "SeedOffer #155", null, 38034m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 156, "", 156, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8172), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8172), "SeedOffer #156", null, 13711m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 157, "", 157, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8174), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8174), "SeedOffer #157", null, 18510m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 158, "", 158, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8176), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8176), "SeedOffer #158", null, 30457m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 159, "", 159, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8178), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8178), "SeedOffer #159", null, 21560m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 160, "", 160, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8204), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8204), "SeedOffer #160", null, 9935m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 161, "", 161, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8206), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8206), "SeedOffer #161", null, 25872m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 162, "", 162, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8208), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8208), "SeedOffer #162", null, 23050m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 163, "", 163, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8210), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8211), "SeedOffer #163", null, 24996m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 164, "", 164, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8212), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8213), "SeedOffer #164", null, 11201m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 165, "", 165, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8214), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8215), "SeedOffer #165", null, 1403m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 166, "", 166, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8216), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8216), "SeedOffer #166", null, 23284m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 167, "", 167, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8218), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8218), "SeedOffer #167", null, 7312m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 168, "", 168, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8220), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8220), "SeedOffer #168", null, 15872m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 169, "", 169, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8222), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8222), "SeedOffer #169", null, 9821m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 170, "", 170, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8224), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8224), "SeedOffer #170", null, 3598m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 171, "", 171, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8225), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8226), "SeedOffer #171", null, 31831m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 172, "", 172, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8227), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8227), "SeedOffer #172", null, 33425m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 173, "", 173, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8229), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8230), "SeedOffer #173", null, 16127m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 174, "", 174, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8231), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8232), "SeedOffer #174", null, 1291m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 175, "", 175, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8233), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8234), "SeedOffer #175", null, 16532m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 176, "", 176, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8235), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8236), "SeedOffer #176", null, 30585m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 177, "", 177, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8238), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8238), "SeedOffer #177", null, 15214m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 178, "", 178, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8240), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8240), "SeedOffer #178", null, 2654m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 179, "", 179, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8242), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8242), "SeedOffer #179", null, 24352m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 180, "", 180, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8244), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8244), "SeedOffer #180", null, 1825m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 181, "", 181, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8245), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8246), "SeedOffer #181", null, 18763m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 182, "", 182, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8248), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8248), "SeedOffer #182", null, 15589m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 183, "", 183, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8249), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8250), "SeedOffer #183", null, 8714m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 184, "", 184, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8251), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8252), "SeedOffer #184", null, 9299m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 185, "", 185, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8253), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8254), "SeedOffer #185", null, 9826m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 186, "", 186, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8255), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8256), "SeedOffer #186", null, 1557m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 187, "", 187, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8257), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8257), "SeedOffer #187", null, 21427m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 188, "", 188, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8283), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8283), "SeedOffer #188", null, 38169m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 189, "", 189, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8285), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8286), "SeedOffer #189", null, 27710m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 190, "", 190, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8287), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8287), "SeedOffer #190", null, 18474m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 191, "", 191, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8289), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8289), "SeedOffer #191", null, 15425m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 192, "", 192, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8291), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8291), "SeedOffer #192", null, 27022m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 193, "", 193, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8293), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8294), "SeedOffer #193", null, 38524m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 194, "", 194, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8295), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8296), "SeedOffer #194", null, 27208m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 195, "", 195, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8297), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8298), "SeedOffer #195", null, 25209m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 196, "", 196, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8300), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8300), "SeedOffer #196", null, 3228m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 197, "", 197, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8302), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8302), "SeedOffer #197", null, 14375m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 198, "", 198, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8304), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8304), "SeedOffer #198", null, 24173m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 199, "", 199, null, 1, "0789789789", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8306), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8306), "SeedOffer #199", null, 10743m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 200, "", 200, null, 1, "0123123123", new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8308), true, new DateTime(2022, 12, 20, 14, 25, 22, 224, DateTimeKind.Utc).AddTicks(8309), "SeedOffer #200", null, 19726m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarImage_OfferId",
                table: "CarImage",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerId",
                table: "Cars",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmissionTypeId",
                table: "Cars",
                column: "TransmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_VehicleCategoryId",
                table: "Cars",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CarsExtras_ExtraId",
                table: "CarsExtras",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RegionId",
                table: "Cities",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ManufacturerId",
                table: "Models",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferComments_AuthorId",
                table: "OfferComments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferComments_OfferCommentId",
                table: "OfferComments",
                column: "OfferCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferComments_OfferId",
                table: "OfferComments",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CarId",
                table: "Offers",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CarPortalProfileId",
                table: "Offers",
                column: "CarPortalProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CityId",
                table: "Offers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OfferThumbnailId",
                table: "Offers",
                column: "OfferThumbnailId",
                unique: true,
                filter: "[OfferThumbnailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RegionId",
                table: "Offers",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SellerId",
                table: "Offers",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CarPortalUserId",
                table: "Profiles",
                column: "CarPortalUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfilesInterestedOffers_OfferId",
                table: "ProfilesInterestedOffers",
                column: "OfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarImage");

            migrationBuilder.DropTable(
                name: "CarsExtras");

            migrationBuilder.DropTable(
                name: "OfferComments");

            migrationBuilder.DropTable(
                name: "ProfilesInterestedOffers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "OfferThumbnail");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "TransmissionTypes");

            migrationBuilder.DropTable(
                name: "VehicleCategories");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
