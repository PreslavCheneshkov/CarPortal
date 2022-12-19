using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPortal.Data.Migrations
{
    public partial class innitial : Migration
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
                    OfferThumbnailId = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValue: "firstSeedThumbnail"),
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
                    table.ForeignKey(
                        name: "FK_OfferThumbnail_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id");
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
                    { "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", 10, "c8b09f10-4987-4487-a7be-62bafa5914d1", "admin@carportal.com", true, false, null, "ADMIN@CARPORTAL.COM", "ADMIN", "AQAAAAEAACcQAAAAEP/7PQgICf4eFvDepJMbVSizfyeBBb3rROYU4gq6GNxO+QlsqwuguAACKo4gB059ZA==", null, true, "b477be35-f36e-4986-91a4-2af08b8aace9", "8dc8b419-711d-4908-8f3a-fadf47d803a6", false, "admin" },
                    { "1599b271-fc59-4726-a4a1-49e1ecc43b20", 10, "65ce0c7f-8dc4-477a-b055-8c9dd9605ed2", "dealer@carportal.com", true, false, null, "DEALER@CARPORTAL.COM", "DEALER", "AQAAAAEAACcQAAAAEOcIa2yO3d/UF8h/0Rb44rYDmfU0hHYYdFcuE0A1pGhylzgpkreulCQce/0RpWlYfA==", null, true, "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "c12aae48-6abc-41ea-9a2c-92e294292b7f", false, "dealer" },
                    { "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", 10, "e251dff4-1bcd-4274-8b6f-e479dd38f606", "newsWriter@carportal.com", true, false, null, "NEWSWRITER@CARPORTAL.COM", "NEWSWRITER", "AQAAAAEAACcQAAAAEFqfgowTJmvdlepgOYlm6NK3kS130XkyP/BqlFt4VlZPGr854DB7PQOT6UOgvB4t8A==", null, true, "840f8101-dba1-4559-af43-a15af74d321c", "eaa73af7-e319-41c5-88ad-3d5216e1c92d", false, "newsWriter" },
                    { "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", 10, "08ed084d-04e2-46a0-883c-a1c1645318f7", "regular@carportal.com", true, false, null, "REGULAR@CARPORTAL.COM", "REGULAR", "AQAAAAEAACcQAAAAEOnTmeyvqzcCtwRJSJ7N81EPOS/R6/cIfsQHc5/Sy9/mqHPIprM1V9QnePOc1udHAg==", null, true, "243d758e-59b0-46bd-bc56-3b41c4adc264", "c85d3d0b-821c-457a-8792-53d8928e7aec", false, "regular" }
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
                    { 61, 16, "Duster" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 62, 16, "Sandero" },
                    { 63, 16, "Logan" },
                    { 64, 16, "Dokker" },
                    { 65, 17, "Ibiza" },
                    { 66, 17, "Toledo" },
                    { 67, 17, "Leon" },
                    { 68, 17, "Ateca" },
                    { 69, 18, "Focus" },
                    { 70, 18, "Fiesta" },
                    { 71, 18, "F-150" },
                    { 72, 18, "Mondeo" },
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
                    { "243d758e-59b0-46bd-bc56-3b41c4adc264", "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", new DateTime(2022, 12, 19, 21, 23, 18, 304, DateTimeKind.Utc).AddTicks(1815), false, null },
                    { "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "1599b271-fc59-4726-a4a1-49e1ecc43b20", new DateTime(2022, 12, 19, 21, 23, 18, 304, DateTimeKind.Utc).AddTicks(1812), true, null },
                    { "840f8101-dba1-4559-af43-a15af74d321c", "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", new DateTime(2022, 12, 19, 21, 23, 18, 304, DateTimeKind.Utc).AddTicks(1809), false, null },
                    { "b477be35-f36e-4986-91a4-2af08b8aace9", "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", new DateTime(2022, 12, 19, 21, 23, 18, 304, DateTimeKind.Utc).AddTicks(1805), false, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1179.0, 4, 81, false, 9, 414670, 35, 1, 6, 1993 },
                    { 2, 1, 2468.0, 1, 301, false, 19, 116625, 73, 1, 3, 2019 },
                    { 3, 1, 1716.0, 6, 184, false, 19, 496007, 75, 5, 5, 2009 },
                    { 4, 3, 1960.0, 5, 394, false, 16, 292391, 63, 2, 4, 2000 },
                    { 5, 6, 3172.0, 3, 489, false, 12, 207783, 47, 4, 3, 2007 },
                    { 6, 8, 2111.0, 4, 302, false, 17, 395129, 67, 6, 4, 2021 },
                    { 7, 2, 3607.0, 6, 142, false, 9, 147373, 34, 6, 2, 2009 },
                    { 8, 1, 2843.0, 3, 241, false, 7, 168526, 26, 3, 3, 2019 },
                    { 9, 3, 1771.0, 1, 449, false, 16, 278291, 62, 1, 1, 1990 },
                    { 10, 3, 2183.0, 2, 78, false, 17, 41609, 67, 3, 6, 2005 },
                    { 11, 4, 1930.0, 2, 80, false, 16, 372943, 63, 3, 6, 2015 },
                    { 12, 8, 3431.0, 1, 133, false, 1, 179978, 2, 5, 5, 2000 },
                    { 13, 3, 2996.0, 4, 133, false, 16, 201937, 61, 2, 3, 1997 },
                    { 14, 7, 1516.0, 2, 420, false, 14, 447181, 55, 1, 1, 2019 },
                    { 15, 5, 3870.0, 6, 192, false, 15, 302914, 57, 4, 6, 1998 },
                    { 16, 2, 1289.0, 1, 466, false, 11, 223632, 43, 2, 3, 2020 },
                    { 17, 6, 2703.0, 4, 150, false, 9, 202046, 34, 6, 2, 1999 },
                    { 18, 5, 2430.0, 4, 337, false, 9, 262028, 34, 6, 6, 2016 },
                    { 19, 3, 1786.0, 5, 267, false, 3, 456289, 11, 5, 2, 2017 },
                    { 20, 5, 3005.0, 2, 344, false, 8, 82385, 29, 3, 5, 1999 },
                    { 21, 4, 3551.0, 3, 458, false, 5, 307191, 19, 3, 1, 2018 },
                    { 22, 5, 2632.0, 3, 231, false, 18, 221491, 70, 4, 1, 2005 },
                    { 23, 2, 1212.0, 6, 90, false, 7, 488159, 26, 4, 6, 2020 },
                    { 24, 2, 3490.0, 6, 463, false, 15, 357654, 59, 5, 2, 2002 },
                    { 25, 5, 2735.0, 5, 412, false, 18, 240840, 71, 6, 6, 2016 },
                    { 26, 2, 1682.0, 5, 444, false, 5, 327387, 17, 6, 5, 1995 },
                    { 27, 5, 1130.0, 1, 247, false, 17, 88790, 66, 4, 4, 2012 },
                    { 28, 7, 2421.0, 5, 470, false, 3, 116116, 9, 3, 1, 1999 },
                    { 29, 3, 3874.0, 1, 167, false, 13, 259451, 50, 4, 4, 2021 },
                    { 30, 5, 1269.0, 2, 227, false, 10, 55551, 37, 3, 4, 1993 },
                    { 31, 3, 1207.0, 6, 458, false, 2, 189513, 5, 5, 5, 1992 },
                    { 32, 2, 1411.0, 1, 330, false, 1, 368975, 1, 4, 3, 2001 },
                    { 33, 5, 1276.0, 6, 159, false, 4, 430334, 15, 5, 2, 2011 },
                    { 34, 3, 1635.0, 6, 401, false, 7, 83129, 25, 3, 3, 2009 },
                    { 35, 7, 3423.0, 4, 349, false, 3, 363890, 11, 5, 4, 2014 },
                    { 36, 4, 1177.0, 1, 413, false, 6, 193289, 21, 1, 2, 2008 },
                    { 37, 8, 2039.0, 4, 364, false, 2, 289965, 7, 6, 5, 2009 },
                    { 38, 3, 1194.0, 1, 451, false, 3, 284172, 10, 6, 2, 1994 },
                    { 39, 6, 3522.0, 3, 179, false, 4, 441913, 15, 4, 6, 1998 },
                    { 40, 4, 2920.0, 4, 311, false, 5, 86308, 19, 1, 3, 2011 },
                    { 41, 2, 2719.0, 3, 226, false, 8, 221199, 29, 1, 6, 2004 },
                    { 42, 6, 2542.0, 4, 423, false, 16, 117291, 63, 5, 4, 1995 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 43, 3, 3382.0, 2, 109, false, 16, 485525, 62, 1, 1, 2019 },
                    { 44, 6, 2026.0, 6, 152, false, 12, 294158, 46, 3, 5, 1996 },
                    { 45, 3, 1780.0, 4, 74, false, 8, 207685, 30, 1, 5, 2016 },
                    { 46, 6, 3357.0, 4, 413, false, 1, 338438, 3, 5, 6, 1996 },
                    { 47, 7, 3360.0, 3, 116, false, 18, 286293, 71, 4, 3, 1999 },
                    { 48, 6, 3118.0, 4, 404, false, 9, 95089, 34, 1, 3, 2000 },
                    { 49, 3, 1854.0, 2, 401, false, 10, 225445, 38, 3, 3, 2018 },
                    { 50, 4, 2768.0, 6, 88, false, 11, 241627, 41, 2, 1, 2013 },
                    { 51, 5, 3395.0, 3, 93, false, 6, 331065, 21, 6, 2, 2012 },
                    { 52, 5, 1817.0, 4, 87, false, 6, 371614, 22, 3, 1, 1997 },
                    { 53, 6, 2056.0, 5, 398, false, 17, 392658, 67, 5, 2, 2003 },
                    { 54, 8, 1808.0, 1, 407, false, 7, 458075, 27, 1, 2, 2005 },
                    { 55, 3, 1622.0, 6, 224, false, 19, 75908, 73, 6, 1, 1999 },
                    { 56, 1, 1799.0, 6, 492, false, 18, 387080, 69, 6, 2, 1991 },
                    { 57, 6, 2153.0, 4, 66, false, 13, 101978, 50, 5, 1, 2010 },
                    { 58, 2, 1165.0, 4, 261, false, 8, 198991, 31, 1, 3, 2003 },
                    { 59, 8, 1164.0, 3, 212, false, 16, 177106, 62, 4, 2, 1990 },
                    { 60, 4, 3511.0, 4, 89, false, 7, 289389, 25, 1, 5, 2008 },
                    { 61, 2, 3012.0, 2, 393, false, 8, 145956, 31, 2, 5, 1992 },
                    { 62, 4, 2462.0, 1, 165, false, 8, 162633, 31, 2, 1, 1999 },
                    { 63, 5, 3012.0, 6, 221, false, 15, 241289, 59, 4, 2, 2007 },
                    { 64, 1, 1806.0, 1, 253, false, 19, 100118, 74, 6, 4, 2013 },
                    { 65, 4, 3829.0, 1, 305, false, 18, 436511, 70, 2, 6, 1999 },
                    { 66, 5, 2140.0, 4, 313, false, 5, 440472, 17, 2, 3, 1992 },
                    { 67, 7, 2790.0, 5, 302, false, 4, 349099, 15, 5, 4, 1998 },
                    { 68, 2, 1013.0, 2, 304, false, 2, 82520, 5, 6, 5, 1990 },
                    { 69, 8, 2571.0, 5, 61, false, 13, 197555, 51, 4, 4, 2010 },
                    { 70, 2, 2287.0, 5, 77, false, 7, 209904, 27, 3, 3, 2008 },
                    { 71, 7, 1367.0, 2, 261, false, 19, 128449, 74, 5, 1, 1996 },
                    { 72, 2, 3721.0, 6, 156, false, 8, 210086, 29, 2, 3, 2003 },
                    { 73, 4, 2339.0, 2, 144, false, 14, 299154, 55, 3, 4, 2016 },
                    { 74, 1, 1497.0, 6, 334, false, 13, 463041, 51, 6, 5, 1990 },
                    { 75, 3, 2472.0, 6, 340, false, 18, 449528, 70, 1, 6, 1999 },
                    { 76, 4, 2606.0, 4, 439, false, 13, 131273, 50, 6, 4, 1994 },
                    { 77, 4, 1114.0, 6, 131, false, 17, 341234, 65, 2, 5, 2003 },
                    { 78, 8, 2902.0, 5, 313, false, 9, 427594, 33, 3, 4, 2018 },
                    { 79, 8, 2906.0, 3, 421, false, 17, 21974, 65, 3, 2, 2019 },
                    { 80, 6, 3320.0, 6, 481, false, 3, 236942, 11, 4, 2, 2018 },
                    { 81, 7, 1758.0, 1, 74, false, 10, 347832, 39, 1, 3, 1991 },
                    { 82, 8, 2886.0, 4, 404, false, 4, 477973, 15, 3, 6, 1994 },
                    { 83, 8, 1736.0, 5, 379, false, 1, 406021, 3, 2, 4, 1999 },
                    { 84, 7, 3632.0, 6, 495, false, 3, 37450, 10, 6, 1, 2011 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 85, 8, 2929.0, 4, 213, false, 15, 166441, 57, 3, 3, 1990 },
                    { 86, 8, 1075.0, 3, 82, false, 18, 426337, 69, 4, 4, 2005 },
                    { 87, 7, 2563.0, 4, 361, false, 12, 338006, 47, 3, 2, 2000 },
                    { 88, 2, 2446.0, 5, 257, false, 9, 167479, 34, 1, 6, 1992 },
                    { 89, 7, 1539.0, 3, 495, false, 6, 441388, 21, 6, 3, 1992 },
                    { 90, 5, 3522.0, 4, 216, false, 1, 373286, 3, 6, 4, 2010 },
                    { 91, 2, 2566.0, 5, 153, false, 19, 274841, 74, 3, 2, 1990 },
                    { 92, 8, 3896.0, 4, 68, false, 15, 314849, 59, 1, 3, 2003 },
                    { 93, 1, 2223.0, 2, 315, false, 10, 315221, 38, 3, 3, 1997 },
                    { 94, 6, 2405.0, 5, 372, false, 8, 163880, 29, 3, 4, 2009 },
                    { 95, 8, 1075.0, 2, 92, false, 8, 440480, 30, 5, 2, 1992 },
                    { 96, 5, 3737.0, 5, 386, false, 6, 48153, 22, 3, 1, 2005 },
                    { 97, 3, 3429.0, 5, 400, false, 14, 220328, 53, 5, 1, 2014 },
                    { 98, 7, 1123.0, 4, 113, false, 9, 117222, 34, 1, 6, 2016 },
                    { 99, 5, 1865.0, 4, 264, false, 1, 79049, 3, 3, 1, 2012 },
                    { 100, 2, 2102.0, 4, 331, false, 11, 129312, 41, 4, 3, 1991 },
                    { 101, 7, 3386.0, 1, 222, false, 17, 310989, 65, 1, 3, 1995 },
                    { 102, 8, 2623.0, 5, 340, false, 7, 443173, 25, 5, 2, 2015 },
                    { 103, 7, 2767.0, 1, 221, false, 5, 181567, 19, 5, 1, 1994 },
                    { 104, 3, 1942.0, 1, 211, false, 11, 298915, 43, 1, 3, 1999 },
                    { 105, 5, 1669.0, 5, 363, false, 14, 300300, 55, 1, 6, 1991 },
                    { 106, 7, 3583.0, 4, 153, false, 16, 495078, 61, 6, 3, 1997 },
                    { 107, 3, 2817.0, 3, 425, false, 3, 340671, 11, 5, 2, 1993 },
                    { 108, 6, 1541.0, 3, 374, false, 6, 189881, 23, 6, 2, 2015 },
                    { 109, 1, 2848.0, 6, 159, false, 14, 273640, 54, 1, 1, 2004 },
                    { 110, 5, 1546.0, 2, 408, false, 9, 396075, 34, 6, 6, 1998 },
                    { 111, 7, 3911.0, 3, 84, false, 9, 22026, 33, 5, 6, 2007 },
                    { 112, 1, 1835.0, 1, 499, false, 12, 122229, 47, 5, 3, 2019 },
                    { 113, 2, 2457.0, 1, 67, false, 9, 245741, 33, 1, 1, 2005 },
                    { 114, 3, 3095.0, 5, 237, false, 11, 461250, 42, 4, 1, 2015 },
                    { 115, 5, 2205.0, 1, 470, false, 9, 446753, 33, 6, 6, 1990 },
                    { 116, 8, 1910.0, 5, 397, false, 9, 445365, 33, 6, 5, 2003 },
                    { 117, 4, 3110.0, 2, 254, false, 5, 498656, 18, 5, 1, 2010 },
                    { 118, 7, 3691.0, 4, 351, false, 8, 310011, 31, 4, 4, 2013 },
                    { 119, 3, 3488.0, 5, 145, false, 8, 370954, 30, 5, 5, 2016 },
                    { 120, 4, 2898.0, 3, 227, false, 18, 310058, 70, 2, 2, 2016 },
                    { 121, 1, 2954.0, 1, 339, false, 12, 408850, 46, 5, 6, 2015 },
                    { 122, 6, 2017.0, 3, 426, false, 9, 77415, 35, 5, 5, 2008 },
                    { 123, 5, 3532.0, 1, 483, false, 18, 168612, 69, 1, 5, 2010 },
                    { 124, 6, 1902.0, 6, 295, false, 3, 493971, 11, 5, 3, 2002 },
                    { 125, 5, 2504.0, 6, 438, false, 16, 246565, 61, 4, 5, 2010 },
                    { 126, 3, 1911.0, 5, 368, false, 10, 102509, 38, 2, 2, 2006 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 127, 6, 1987.0, 5, 180, false, 15, 409929, 59, 5, 4, 2003 },
                    { 128, 4, 2613.0, 3, 79, false, 18, 117083, 71, 4, 3, 2018 },
                    { 129, 3, 1870.0, 2, 260, false, 15, 108141, 58, 6, 1, 2021 },
                    { 130, 2, 1354.0, 6, 154, false, 15, 95140, 57, 3, 4, 1992 },
                    { 131, 7, 3688.0, 1, 375, false, 19, 202906, 73, 1, 1, 1991 },
                    { 132, 7, 2328.0, 4, 374, false, 3, 133083, 10, 5, 5, 1991 },
                    { 133, 8, 2660.0, 3, 379, false, 1, 210937, 2, 3, 2, 1993 },
                    { 134, 6, 2978.0, 6, 133, false, 15, 339437, 58, 1, 4, 2017 },
                    { 135, 8, 3653.0, 1, 348, false, 1, 190218, 3, 3, 2, 1997 },
                    { 136, 8, 3729.0, 4, 332, false, 8, 55569, 30, 5, 3, 1994 },
                    { 137, 3, 2334.0, 1, 155, false, 9, 445744, 33, 2, 6, 2008 },
                    { 138, 4, 2178.0, 4, 255, false, 15, 478941, 59, 2, 5, 1993 },
                    { 139, 8, 1520.0, 2, 355, false, 15, 165171, 58, 6, 4, 2002 },
                    { 140, 5, 1399.0, 2, 441, false, 10, 415918, 37, 6, 2, 2006 },
                    { 141, 4, 2510.0, 5, 347, false, 13, 208458, 49, 2, 4, 2006 },
                    { 142, 4, 2469.0, 2, 403, false, 13, 336603, 49, 3, 3, 2007 },
                    { 143, 8, 3338.0, 1, 125, false, 17, 286917, 66, 6, 5, 2001 },
                    { 144, 8, 3895.0, 4, 457, false, 17, 320934, 66, 2, 5, 2020 },
                    { 145, 5, 3843.0, 2, 434, false, 15, 175905, 59, 3, 4, 2017 },
                    { 146, 5, 2372.0, 4, 196, false, 16, 352144, 61, 3, 6, 2004 },
                    { 147, 6, 2583.0, 4, 143, false, 11, 114323, 41, 1, 5, 2021 },
                    { 148, 8, 2856.0, 2, 177, false, 10, 418520, 38, 2, 6, 2003 },
                    { 149, 4, 3921.0, 1, 472, false, 19, 199260, 74, 6, 2, 2019 },
                    { 150, 6, 3664.0, 2, 369, false, 17, 336329, 65, 4, 1, 2013 },
                    { 151, 2, 2422.0, 5, 308, false, 19, 496032, 75, 6, 1, 1999 },
                    { 152, 1, 1903.0, 5, 291, false, 12, 263150, 46, 6, 5, 1993 },
                    { 153, 5, 3773.0, 1, 156, false, 18, 477882, 70, 1, 5, 2000 },
                    { 154, 7, 1108.0, 6, 87, false, 11, 472271, 41, 6, 2, 2020 },
                    { 155, 6, 2221.0, 6, 78, false, 19, 184523, 75, 5, 2, 1993 },
                    { 156, 4, 3557.0, 1, 340, false, 11, 82530, 43, 3, 2, 2016 },
                    { 157, 5, 1176.0, 3, 431, false, 3, 320485, 9, 5, 3, 2000 },
                    { 158, 8, 3908.0, 1, 283, false, 6, 165215, 23, 2, 5, 2012 },
                    { 159, 6, 1931.0, 6, 310, false, 11, 398205, 41, 1, 2, 1990 },
                    { 160, 1, 2333.0, 3, 388, false, 6, 148641, 22, 1, 2, 2004 },
                    { 161, 3, 2275.0, 5, 118, false, 1, 84568, 1, 4, 6, 1997 },
                    { 162, 7, 1344.0, 5, 337, false, 12, 142338, 47, 1, 1, 2007 },
                    { 163, 3, 3612.0, 3, 170, false, 10, 131836, 37, 5, 5, 2008 },
                    { 164, 7, 2804.0, 6, 349, false, 7, 190179, 26, 5, 3, 1990 },
                    { 165, 6, 2791.0, 2, 404, false, 14, 378549, 55, 3, 5, 2021 },
                    { 166, 1, 2242.0, 6, 361, false, 3, 309402, 11, 6, 2, 2001 },
                    { 167, 5, 3757.0, 6, 461, false, 10, 344023, 38, 6, 5, 2020 },
                    { 168, 5, 3680.0, 6, 244, false, 15, 121838, 59, 6, 1, 2011 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 169, 1, 3911.0, 2, 397, false, 16, 59389, 62, 4, 2, 2015 },
                    { 170, 3, 3770.0, 6, 82, false, 2, 269655, 6, 1, 2, 2010 },
                    { 171, 7, 3502.0, 3, 225, false, 16, 407835, 63, 1, 3, 2006 },
                    { 172, 6, 3683.0, 3, 107, false, 13, 192348, 49, 5, 4, 2004 },
                    { 173, 3, 1421.0, 3, 239, false, 6, 101268, 22, 5, 2, 1999 },
                    { 174, 4, 2436.0, 1, 480, false, 16, 474307, 61, 5, 4, 2001 },
                    { 175, 5, 3204.0, 3, 81, false, 1, 466510, 1, 4, 2, 2010 },
                    { 176, 7, 2357.0, 3, 244, false, 8, 337984, 29, 6, 1, 2009 },
                    { 177, 8, 3703.0, 5, 434, false, 6, 158408, 23, 5, 4, 2000 },
                    { 178, 7, 2243.0, 2, 374, false, 18, 498749, 69, 4, 4, 1993 },
                    { 179, 3, 2010.0, 6, 303, false, 4, 38207, 13, 5, 2, 2016 },
                    { 180, 6, 1265.0, 4, 433, false, 5, 425334, 19, 2, 6, 2013 },
                    { 181, 6, 1826.0, 4, 203, false, 2, 74316, 6, 5, 6, 1990 },
                    { 182, 3, 3465.0, 3, 89, false, 1, 144452, 3, 2, 3, 2014 },
                    { 183, 7, 1332.0, 6, 392, false, 5, 158334, 17, 2, 1, 2011 },
                    { 184, 4, 1079.0, 6, 162, false, 1, 424953, 2, 3, 2, 2001 },
                    { 185, 5, 2346.0, 4, 345, false, 7, 36013, 26, 4, 3, 2016 },
                    { 186, 6, 3182.0, 5, 140, false, 15, 291507, 57, 1, 1, 2012 },
                    { 187, 5, 1106.0, 3, 344, false, 17, 294142, 67, 3, 6, 2005 },
                    { 188, 8, 2470.0, 1, 409, false, 5, 314666, 18, 3, 3, 2011 },
                    { 189, 5, 1527.0, 5, 364, false, 16, 42909, 62, 6, 3, 1993 },
                    { 190, 2, 2233.0, 4, 135, false, 9, 325730, 33, 4, 4, 2006 },
                    { 191, 2, 2986.0, 6, 352, false, 16, 35183, 62, 3, 3, 1990 },
                    { 192, 1, 2824.0, 6, 336, false, 11, 407834, 43, 4, 3, 2020 },
                    { 193, 1, 3245.0, 1, 383, false, 18, 196809, 70, 6, 4, 2009 },
                    { 194, 6, 3778.0, 1, 437, false, 12, 325186, 45, 1, 6, 1992 },
                    { 195, 2, 3316.0, 4, 468, false, 5, 246935, 18, 2, 6, 1990 },
                    { 196, 4, 1230.0, 5, 405, false, 10, 48952, 37, 6, 6, 2018 },
                    { 197, 7, 1691.0, 5, 215, false, 14, 21988, 54, 5, 6, 2003 },
                    { 198, 6, 3649.0, 5, 281, false, 7, 419336, 25, 1, 3, 2021 },
                    { 199, 8, 2566.0, 3, 316, false, 13, 73109, 51, 6, 5, 1998 },
                    { 200, 7, 3316.0, 3, 405, false, 8, 289191, 30, 2, 6, 2000 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 1, "", 1, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(388), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(389), "SeedOffer #1", 20698m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 2, "", 2, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(398), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(398), "SeedOffer #2", 24612m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 3, "", 3, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(404), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(404), "SeedOffer #3", 11544m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 4, "", 4, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(407), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(407), "SeedOffer #4", 19624m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 5, "", 5, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(410), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(410), "SeedOffer #5", 5113m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 6, "", 6, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(415), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(415), "SeedOffer #6", 7439m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 7, "", 7, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(418), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(418), "SeedOffer #7", 14326m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 8, "", 8, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(420), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(421), "SeedOffer #8", 32626m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 9, "", 9, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(423), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(424), "SeedOffer #9", 27328m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 10, "", 10, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(481), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(482), "SeedOffer #10", 21051m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 11, "", 11, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(485), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(486), "SeedOffer #11", 32537m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 12, "", 12, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(489), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(489), "SeedOffer #12", 39734m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 13, "", 13, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(493), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(494), "SeedOffer #13", 35608m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 14, "", 14, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(496), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(496), "SeedOffer #14", 34799m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 15, "", 15, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(499), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(499), "SeedOffer #15", 29243m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 16, "", 16, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(501), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(502), "SeedOffer #16", 2849m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 17, "", 17, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(504), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(505), "SeedOffer #17", 38302m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 18, "", 18, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(509), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(509), "SeedOffer #18", 26243m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 19, "", 19, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(512), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(512), "SeedOffer #19", 39544m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 20, "", 20, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(514), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(515), "SeedOffer #20", 24714m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 21, "", 21, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(517), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(518), "SeedOffer #21", 4848m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 22, "", 22, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(520), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(520), "SeedOffer #22", 36534m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 23, "", 23, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(523), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(523), "SeedOffer #23", 9403m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 24, "", 24, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(526), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(526), "SeedOffer #24", 24264m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 25, "", 25, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(528), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(529), "SeedOffer #25", 29004m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 26, "", 26, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(531), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(532), "SeedOffer #26", 28411m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 27, "", 27, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(535), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(535), "SeedOffer #27", 19374m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 28, "", 28, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(537), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(538), "SeedOffer #28", 5344m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 29, "", 29, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(540), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(540), "SeedOffer #29", 27685m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 30, "", 30, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(543), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(543), "SeedOffer #30", 12017m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 31, "", 31, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(546), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(546), "SeedOffer #31", 22539m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 32, "", 32, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(549), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(549), "SeedOffer #32", 38512m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 33, "", 33, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(551), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(552), "SeedOffer #33", 17321m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 34, "", 34, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(558), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(558), "SeedOffer #34", 7176m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 35, "", 35, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(561), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(561), "SeedOffer #35", 25564m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 36, "", 36, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(627), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(627), "SeedOffer #36", 16341m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 37, "", 37, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(630), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(630), "SeedOffer #37", 12840m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 38, "", 38, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(633), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(633), "SeedOffer #38", 21022m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 39, "", 39, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(636), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(637), "SeedOffer #39", 17376m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 40, "", 40, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(639), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(639), "SeedOffer #40", 22413m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 41, "", 41, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(642), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(642), "SeedOffer #41", 13022m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 42, "", 42, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(645), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(645), "SeedOffer #42", 2282m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 43, "", 43, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(647), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(648), "SeedOffer #43", 36305m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 44, "", 44, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(650), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(651), "SeedOffer #44", 12182m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 45, "", 45, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(653), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(654), "SeedOffer #45", 38453m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 46, "", 46, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(656), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(658), "SeedOffer #46", 7500m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 47, "", 47, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(661), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(661), "SeedOffer #47", 7822m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 48, "", 48, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(663), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(664), "SeedOffer #48", 10961m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 49, "", 49, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(667), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(667), "SeedOffer #49", 6691m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 50, "", 50, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(669), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(670), "SeedOffer #50", 2858m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 51, "", 51, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(672), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(672), "SeedOffer #51", 11288m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 52, "", 52, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(675), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(675), "SeedOffer #52", 25534m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 53, "", 53, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(677), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(678), "SeedOffer #53", 19388m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 54, "", 54, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(680), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(681), "SeedOffer #54", 6517m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 55, "", 55, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(683), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(684), "SeedOffer #55", 33178m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 56, "", 56, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(686), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(686), "SeedOffer #56", 16524m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 57, "", 57, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(688), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(688), "SeedOffer #57", 9743m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 58, "", 58, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(689), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(690), "SeedOffer #58", 31058m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 59, "", 59, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(691), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(692), "SeedOffer #59", 9949m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 60, "", 60, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(694), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(694), "SeedOffer #60", 25032m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 61, "", 61, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(696), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(696), "SeedOffer #61", 5928m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 62, "", 62, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(697), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(698), "SeedOffer #62", 12400m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 63, "", 63, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(699), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(699), "SeedOffer #63", 19416m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 64, "", 64, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(701), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(702), "SeedOffer #64", 12000m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 65, "", 65, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(731), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(731), "SeedOffer #65", 37286m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 66, "", 66, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(734), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(735), "SeedOffer #66", 3224m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 67, "", 67, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(737), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(737), "SeedOffer #67", 24808m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 68, "", 68, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(738), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(739), "SeedOffer #68", 2477m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 69, "", 69, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(740), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(741), "SeedOffer #69", 30058m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 70, "", 70, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(742), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(743), "SeedOffer #70", 32385m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 71, "", 71, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(744), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(744), "SeedOffer #71", 31784m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 72, "", 72, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(746), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(746), "SeedOffer #72", 26842m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 73, "", 73, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(748), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(748), "SeedOffer #73", 2667m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 74, "", 74, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(750), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(750), "SeedOffer #74", 8462m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 75, "", 75, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(752), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(752), "SeedOffer #75", 38875m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 76, "", 76, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(754), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(754), "SeedOffer #76", 34494m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 77, "", 77, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(756), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(756), "SeedOffer #77", 34386m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 78, "", 78, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(758), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(758), "SeedOffer #78", 9805m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 79, "", 79, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(760), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(760), "SeedOffer #79", 30804m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 80, "", 80, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(761), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(762), "SeedOffer #80", 8645m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 81, "", 81, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(763), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(763), "SeedOffer #81", 26266m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 82, "", 82, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(765), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(766), "SeedOffer #82", 30064m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 83, "", 83, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(767), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(767), "SeedOffer #83", 8075m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 84, "", 84, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(769), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(769), "SeedOffer #84", 10938m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 85, "", 85, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(771), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(771), "SeedOffer #85", 28721m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 86, "", 86, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(773), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(773), "SeedOffer #86", 3510m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 87, "", 87, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(774), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(775), "SeedOffer #87", 23751m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 88, "", 88, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(776), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(777), "SeedOffer #88", 2136m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 89, "", 89, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(778), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(779), "SeedOffer #89", 17015m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 90, "", 90, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(781), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(781), "SeedOffer #90", 6655m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 91, "", 91, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(807), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(807), "SeedOffer #91", 27704m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 92, "", 92, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(809), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(809), "SeedOffer #92", 3981m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 93, "", 93, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(811), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(811), "SeedOffer #93", 13503m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 94, "", 94, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(813), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(813), "SeedOffer #94", 33373m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 95, "", 95, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(815), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(815), "SeedOffer #95", 24630m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 96, "", 96, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(816), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(817), "SeedOffer #96", 14183m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 97, "", 97, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(818), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(819), "SeedOffer #97", 32117m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 98, "", 98, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(820), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(821), "SeedOffer #98", 2138m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 99, "", 99, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(822), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(822), "SeedOffer #99", 11632m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 100, "", 100, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(824), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(824), "SeedOffer #100", 11735m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 101, "", 101, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(826), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(826), "SeedOffer #101", 38152m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 102, "", 102, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(828), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(828), "SeedOffer #102", 3992m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 103, "", 103, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(830), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(830), "SeedOffer #103", 35085m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 104, "", 104, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(832), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(832), "SeedOffer #104", 12169m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 105, "", 105, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(833), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(834), "SeedOffer #105", 35671m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 106, "", 106, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(835), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(836), "SeedOffer #106", 6689m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 107, "", 107, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(837), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(838), "SeedOffer #107", 15604m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 108, "", 108, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(839), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(840), "SeedOffer #108", 11697m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 109, "", 109, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(841), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(842), "SeedOffer #109", 39872m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 110, "", 110, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(843), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(844), "SeedOffer #110", 27537m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 111, "", 111, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(845), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(846), "SeedOffer #111", 2983m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 112, "", 112, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(847), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(848), "SeedOffer #112", 12447m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 113, "", 113, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(851), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(851), "SeedOffer #113", 36266m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 114, "", 114, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(853), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(853), "SeedOffer #114", 24236m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 115, "", 115, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(855), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(855), "SeedOffer #115", 9647m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 116, "", 116, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(857), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(857), "SeedOffer #116", 16465m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 117, "", 117, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(859), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(859), "SeedOffer #117", 12570m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 118, "", 118, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(861), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(861), "SeedOffer #118", 30761m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 119, "", 119, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(888), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(888), "SeedOffer #119", 9888m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 120, "", 120, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(890), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(891), "SeedOffer #120", 34510m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 121, "", 121, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(892), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(893), "SeedOffer #121", 19895m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 122, "", 122, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(895), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(895), "SeedOffer #122", 4321m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 123, "", 123, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(896), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(897), "SeedOffer #123", 27596m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 124, "", 124, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(898), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(899), "SeedOffer #124", 16138m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 125, "", 125, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(900), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(900), "SeedOffer #125", 21693m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 126, "", 126, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(902), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(902), "SeedOffer #126", 13566m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 127, "", 127, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(904), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(904), "SeedOffer #127", 37530m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 128, "", 128, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(905), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(906), "SeedOffer #128", 39274m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 129, "", 129, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(908), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(908), "SeedOffer #129", 12734m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 130, "", 130, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(911), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(911), "SeedOffer #130", 4190m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 131, "", 131, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(913), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(913), "SeedOffer #131", 39467m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 132, "", 132, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(915), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(915), "SeedOffer #132", 16166m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 133, "", 133, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(916), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(917), "SeedOffer #133", 5422m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 134, "", 134, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(918), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(919), "SeedOffer #134", 25254m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 135, "", 135, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(920), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(920), "SeedOffer #135", 34072m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 136, "", 136, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(922), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(922), "SeedOffer #136", 38973m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 137, "", 137, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(924), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(924), "SeedOffer #137", 885m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 138, "", 138, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(926), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(926), "SeedOffer #138", 8045m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 139, "", 139, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(928), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(928), "SeedOffer #139", 37661m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 140, "", 140, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(929), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(930), "SeedOffer #140", 36740m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 141, "", 141, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(956), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(956), "SeedOffer #141", 18404m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 142, "", 142, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(958), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(958), "SeedOffer #142", 28069m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 143, "", 143, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(960), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(960), "SeedOffer #143", 9823m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 144, "", 144, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(962), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(962), "SeedOffer #144", 1296m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 145, "", 145, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(964), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(964), "SeedOffer #145", 22301m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 146, "", 146, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(969), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(969), "SeedOffer #146", 36278m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 147, "", 147, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(971), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(972), "SeedOffer #147", 34424m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 148, "", 148, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(974), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(975), "SeedOffer #148", 27990m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 149, "", 149, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(977), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(977), "SeedOffer #149", 15453m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 150, "", 150, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(980), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(980), "SeedOffer #150", 13597m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 151, "", 151, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(982), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(982), "SeedOffer #151", 19698m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 152, "", 152, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(984), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(985), "SeedOffer #152", 30562m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 153, "", 153, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(987), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(987), "SeedOffer #153", 26758m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 154, "", 154, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(990), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(991), "SeedOffer #154", 33375m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 155, "", 155, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(993), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(994), "SeedOffer #155", 12745m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 156, "", 156, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(996), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(996), "SeedOffer #156", 29896m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 157, "", 157, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(998), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(998), "SeedOffer #157", 18490m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 158, "", 158, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1000), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1001), "SeedOffer #158", 30958m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 159, "", 159, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1003), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1003), "SeedOffer #159", 36285m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 160, "", 160, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1005), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1006), "SeedOffer #160", 28466m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 161, "", 161, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1008), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1008), "SeedOffer #161", 9518m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 162, "", 162, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1010), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1010), "SeedOffer #162", 28403m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 163, "", 163, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1012), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1013), "SeedOffer #163", 6194m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 164, "", 164, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1015), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1015), "SeedOffer #164", 20311m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 165, "", 165, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1017), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1018), "SeedOffer #165", 28372m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 166, "", 166, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1020), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1020), "SeedOffer #166", 11317m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 167, "", 167, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1022), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1023), "SeedOffer #167", 1516m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 168, "", 168, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1025), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1026), "SeedOffer #168", 7137m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 169, "", 169, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1079), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1080), "SeedOffer #169", 19836m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 170, "", 170, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1082), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1083), "SeedOffer #170", 12784m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 171, "", 171, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1085), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1085), "SeedOffer #171", 6521m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 172, "", 172, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1087), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1088), "SeedOffer #172", 23646m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 173, "", 173, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1090), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1090), "SeedOffer #173", 35102m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 174, "", 174, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1093), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1093), "SeedOffer #174", 13188m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 175, "", 175, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1095), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1095), "SeedOffer #175", 14682m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 176, "", 176, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1098), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1099), "SeedOffer #176", 702m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 177, "", 177, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1101), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1101), "SeedOffer #177", 19316m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 178, "", 178, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1103), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1104), "SeedOffer #178", 26481m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 179, "", 179, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1107), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1107), "SeedOffer #179", 7388m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 180, "", 180, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1109), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1110), "SeedOffer #180", 37578m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 181, "", 181, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1112), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1112), "SeedOffer #181", 23766m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 182, "", 182, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1114), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1115), "SeedOffer #182", 19311m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 183, "", 183, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1117), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1117), "SeedOffer #183", 14630m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 184, "", 184, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1119), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1120), "SeedOffer #184", 7547m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 185, "", 185, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1122), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1122), "SeedOffer #185", 36681m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 186, "", 186, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1124), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1125), "SeedOffer #186", 19837m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 187, "", 187, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1127), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1127), "SeedOffer #187", 5920m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 188, "", 188, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1129), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1130), "SeedOffer #188", 22954m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 189, "", 189, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1132), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1132), "SeedOffer #189", 21676m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 190, "", 190, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1134), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1135), "SeedOffer #190", 2442m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 191, "", 191, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1137), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1138), "SeedOffer #191", 34464m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 192, "", 192, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1140), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1140), "SeedOffer #192", 1461m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 193, "", 193, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1142), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1143), "SeedOffer #193", 32675m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 194, "", 194, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1145), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1146), "SeedOffer #194", 32152m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 195, "", 195, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1148), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1148), "SeedOffer #195", 1569m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 196, "", 196, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1150), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1151), "SeedOffer #196", 24523m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 197, "", 197, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1190), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1190), "SeedOffer #197", 27085m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 198, "", 198, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1193), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1193), "SeedOffer #198", 39029m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 199, "", 199, null, 1, "0789789789", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1195), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1195), "SeedOffer #199", 23839m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 200, "", 200, null, 1, "0123123123", new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1197), true, new DateTime(2022, 12, 19, 21, 23, 18, 305, DateTimeKind.Utc).AddTicks(1197), "SeedOffer #200", 5168m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
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
                column: "OfferThumbnailId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RegionId",
                table: "Offers",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_SellerId",
                table: "Offers",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferThumbnail_OfferId",
                table: "OfferThumbnail",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_CarPortalUserId",
                table: "Profiles",
                column: "CarPortalUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfilesInterestedOffers_OfferId",
                table: "ProfilesInterestedOffers",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarImage_Offers_OfferId",
                table: "CarImage",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferComments_Offers_OfferId",
                table: "OfferComments",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_OfferThumbnail_OfferThumbnailId",
                table: "Offers",
                column: "OfferThumbnailId",
                principalTable: "OfferThumbnail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_AspNetUsers_SellerId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_AspNetUsers_CarPortalUserId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferThumbnail_Offers_OfferId",
                table: "OfferThumbnail");

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
                name: "AspNetUsers");

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
                name: "Manufacturers");
        }
    }
}
