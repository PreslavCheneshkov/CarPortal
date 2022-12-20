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
                name: "NewsArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsArticles_Profiles_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Profiles",
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
                name: "NewsArticleComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommenterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NewsArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsArticleComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsArticleComments_NewsArticles_NewsArticleId",
                        column: x => x.NewsArticleId,
                        principalTable: "NewsArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsArticleComments_Profiles_CommenterId",
                        column: x => x.CommenterId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    CarPortalProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferComments_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OfferComments_Profiles_CarPortalProfileId",
                        column: x => x.CarPortalProfileId,
                        principalTable: "Profiles",
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
                    { "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", 10, "b893c209-340b-489c-b09b-24926b87e730", "admin@carportal.com", true, false, null, "ADMIN@CARPORTAL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJGdfGsE29nPBHoB1fwEdmC2zZjw3G3+pJ2jLx2YDsYC4vKv5aBXfUFr21unorLP6Q==", null, true, "b477be35-f36e-4986-91a4-2af08b8aace9", "8ece9e42-3d2d-4e00-b7ea-1628fe4cbb0e", false, "admin" },
                    { "1599b271-fc59-4726-a4a1-49e1ecc43b20", 10, "74f78e5a-7c71-414d-906d-31b3c91b8aae", "dealer@carportal.com", true, false, null, "DEALER@CARPORTAL.COM", "DEALER", "AQAAAAEAACcQAAAAEMTk9KMPJzCXuRiwnyVn7ikXDJsoWR7uZ3Wa0hASyFSwLHg4fQeA0m3Ibql+nLHQTA==", null, true, "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "176b7768-4442-402d-ba72-30004dc24809", false, "dealer" },
                    { "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", 10, "cf638e1d-5bc4-4d0c-82f7-3d73c8dea3e8", "newsWriter@carportal.com", true, false, null, "NEWSWRITER@CARPORTAL.COM", "NEWSWRITER", "AQAAAAEAACcQAAAAEHCkUmW7rElFsJu5gjCREOvUegiDRmW3Z9QpnVIzNFvIe0VkgETnc9MG7XXDK9desw==", null, true, "840f8101-dba1-4559-af43-a15af74d321c", "d1b81eb5-573a-42ef-a8d3-a5f497b738ab", false, "newsWriter" },
                    { "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", 10, "505cb964-c6fd-4ecd-b6f4-0842bbf0c3c6", "regular@carportal.com", true, false, null, "REGULAR@CARPORTAL.COM", "REGULAR", "AQAAAAEAACcQAAAAEJzWuSW9712fR81wm+OvfInmnwCzJrQkKoXTzd8A0Pt9q/a3MkVLAcE9kyEo8qTNzg==", null, true, "243d758e-59b0-46bd-bc56-3b41c4adc264", "0746d3e6-7cb5-49c2-9bd8-51042e27e581", false, "regular" }
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
                    { "243d758e-59b0-46bd-bc56-3b41c4adc264", "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7545), false, null },
                    { "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "1599b271-fc59-4726-a4a1-49e1ecc43b20", new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7542), true, null },
                    { "840f8101-dba1-4559-af43-a15af74d321c", "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7538), false, null },
                    { "b477be35-f36e-4986-91a4-2af08b8aace9", "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", new DateTime(2022, 12, 20, 21, 22, 12, 577, DateTimeKind.Utc).AddTicks(7534), false, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 1, 8, 3357.0, 1, 138, false, 2, 263016, 5, 5, 3, 2011 },
                    { 2, 3, 1751.0, 3, 333, false, 6, 338002, 22, 3, 4, 2010 },
                    { 3, 6, 2083.0, 1, 335, false, 11, 22442, 41, 1, 4, 1993 },
                    { 4, 3, 3513.0, 4, 212, false, 5, 223618, 19, 5, 4, 2002 },
                    { 5, 2, 1522.0, 5, 312, false, 14, 89548, 54, 2, 6, 2021 },
                    { 6, 6, 3767.0, 1, 403, false, 2, 454641, 7, 2, 6, 1994 },
                    { 7, 7, 3566.0, 4, 278, false, 3, 47807, 9, 4, 4, 2003 },
                    { 8, 8, 3714.0, 1, 331, false, 2, 411330, 6, 5, 5, 2017 },
                    { 9, 8, 3869.0, 6, 218, false, 3, 205749, 10, 1, 2, 2014 },
                    { 10, 7, 3270.0, 3, 101, false, 1, 128264, 2, 2, 5, 2017 },
                    { 11, 7, 2987.0, 6, 245, false, 6, 421918, 22, 5, 3, 2011 },
                    { 12, 2, 3246.0, 5, 484, false, 8, 239257, 30, 2, 6, 2012 },
                    { 13, 3, 3695.0, 6, 204, false, 14, 166478, 53, 2, 6, 2010 },
                    { 14, 6, 3122.0, 4, 123, false, 12, 249611, 47, 6, 4, 2020 },
                    { 15, 3, 2036.0, 2, 463, false, 19, 323512, 73, 6, 4, 1996 },
                    { 16, 1, 3005.0, 5, 187, false, 2, 255785, 7, 2, 3, 1991 },
                    { 17, 8, 2772.0, 3, 315, false, 1, 145183, 3, 5, 6, 2013 },
                    { 18, 7, 3615.0, 3, 295, false, 3, 409278, 9, 2, 5, 2000 },
                    { 19, 5, 2618.0, 1, 434, false, 14, 329521, 53, 1, 6, 2011 },
                    { 20, 7, 1612.0, 6, 441, false, 2, 182313, 7, 1, 1, 1999 },
                    { 21, 8, 3594.0, 2, 113, false, 18, 391529, 71, 5, 1, 2009 },
                    { 22, 1, 3983.0, 3, 351, false, 7, 94443, 26, 1, 1, 1991 },
                    { 23, 1, 3112.0, 2, 274, false, 2, 56101, 7, 6, 4, 1997 },
                    { 24, 1, 1708.0, 5, 148, false, 5, 257042, 18, 6, 6, 1997 },
                    { 25, 3, 3541.0, 3, 164, false, 1, 437392, 3, 6, 2, 1995 },
                    { 26, 7, 3839.0, 2, 122, false, 14, 475355, 53, 5, 1, 2012 },
                    { 27, 5, 3791.0, 6, 335, false, 6, 354525, 21, 1, 5, 2021 },
                    { 28, 7, 1130.0, 6, 95, false, 18, 250220, 69, 5, 2, 2004 },
                    { 29, 8, 1804.0, 3, 195, false, 14, 426393, 53, 4, 6, 2005 },
                    { 30, 2, 1022.0, 4, 62, false, 7, 323906, 27, 3, 4, 2004 },
                    { 31, 8, 1273.0, 5, 280, false, 16, 437810, 63, 6, 1, 2016 },
                    { 32, 7, 1148.0, 2, 437, false, 15, 305605, 58, 5, 2, 2019 },
                    { 33, 4, 3685.0, 6, 482, false, 2, 134575, 6, 6, 6, 2015 },
                    { 34, 1, 1304.0, 5, 84, false, 9, 486258, 34, 4, 3, 1998 },
                    { 35, 3, 2532.0, 2, 98, false, 11, 416107, 42, 6, 4, 2020 },
                    { 36, 8, 3374.0, 2, 230, false, 10, 443442, 37, 3, 2, 1992 },
                    { 37, 1, 3211.0, 2, 459, false, 13, 367985, 50, 2, 4, 2012 },
                    { 38, 1, 2125.0, 6, 97, false, 16, 325365, 61, 2, 2, 2002 },
                    { 39, 7, 2063.0, 3, 202, false, 7, 414806, 25, 2, 5, 2002 },
                    { 40, 4, 3038.0, 5, 181, false, 18, 260581, 69, 1, 6, 2005 },
                    { 41, 4, 1800.0, 3, 104, false, 17, 454528, 65, 3, 5, 2001 },
                    { 42, 7, 3057.0, 3, 293, false, 5, 305422, 19, 1, 1, 2019 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 43, 4, 3054.0, 3, 103, false, 11, 368594, 41, 4, 2, 2016 },
                    { 44, 6, 3044.0, 6, 237, false, 14, 268741, 55, 3, 4, 2021 },
                    { 45, 5, 2049.0, 5, 311, false, 9, 120883, 35, 3, 5, 2002 },
                    { 46, 4, 1289.0, 4, 307, false, 14, 220277, 53, 6, 5, 1994 },
                    { 47, 7, 2299.0, 4, 412, false, 12, 472026, 46, 4, 1, 2015 },
                    { 48, 7, 2972.0, 6, 107, false, 9, 76230, 34, 1, 3, 2012 },
                    { 49, 8, 1800.0, 1, 427, false, 18, 339667, 71, 1, 2, 2019 },
                    { 50, 7, 2861.0, 2, 453, false, 1, 365066, 1, 3, 5, 2014 },
                    { 51, 5, 1906.0, 2, 470, false, 13, 460060, 50, 4, 5, 2006 },
                    { 52, 2, 3336.0, 1, 498, false, 19, 396693, 75, 5, 1, 2013 },
                    { 53, 3, 1765.0, 4, 318, false, 9, 237590, 35, 2, 2, 2004 },
                    { 54, 3, 1056.0, 6, 419, false, 12, 148299, 45, 1, 4, 2016 },
                    { 55, 4, 2079.0, 3, 369, false, 9, 381768, 34, 4, 4, 2001 },
                    { 56, 2, 3076.0, 1, 481, false, 3, 135025, 9, 4, 1, 2007 },
                    { 57, 1, 1805.0, 6, 148, false, 9, 93717, 33, 5, 5, 1991 },
                    { 58, 4, 1544.0, 6, 398, false, 9, 474012, 34, 6, 5, 2008 },
                    { 59, 8, 2693.0, 3, 323, false, 6, 397977, 21, 5, 2, 2005 },
                    { 60, 1, 1285.0, 5, 373, false, 13, 104934, 51, 1, 5, 2016 },
                    { 61, 2, 3095.0, 2, 133, false, 6, 429062, 22, 4, 5, 2003 },
                    { 62, 4, 1490.0, 4, 376, false, 4, 271083, 13, 2, 3, 2006 },
                    { 63, 2, 3566.0, 3, 246, false, 15, 428291, 59, 2, 5, 2018 },
                    { 64, 5, 1547.0, 5, 486, false, 7, 88221, 25, 3, 1, 1994 },
                    { 65, 3, 2896.0, 4, 439, false, 1, 162044, 3, 3, 1, 2002 },
                    { 66, 3, 3303.0, 2, 146, false, 18, 296317, 70, 1, 3, 2006 },
                    { 67, 4, 2092.0, 2, 105, false, 1, 440367, 3, 6, 2, 2001 },
                    { 68, 4, 1218.0, 4, 328, false, 16, 21358, 62, 4, 1, 1990 },
                    { 69, 6, 3965.0, 6, 302, false, 18, 335174, 70, 6, 2, 1992 },
                    { 70, 1, 1888.0, 2, 191, false, 12, 208203, 45, 2, 2, 2003 },
                    { 71, 6, 3158.0, 2, 119, false, 9, 403329, 34, 3, 2, 2000 },
                    { 72, 8, 2448.0, 3, 442, false, 18, 198673, 71, 4, 2, 2010 },
                    { 73, 6, 1292.0, 2, 191, false, 13, 451237, 50, 5, 6, 1992 },
                    { 74, 3, 3219.0, 2, 470, false, 10, 463790, 39, 1, 5, 2021 },
                    { 75, 3, 3156.0, 5, 488, false, 10, 191570, 39, 4, 2, 2021 },
                    { 76, 4, 3602.0, 4, 112, false, 5, 204649, 17, 6, 6, 2021 },
                    { 77, 1, 1302.0, 6, 344, false, 12, 307017, 46, 3, 1, 2008 },
                    { 78, 8, 2940.0, 4, 179, false, 7, 401774, 27, 3, 5, 2011 },
                    { 79, 3, 1086.0, 5, 179, false, 2, 389624, 5, 4, 6, 2018 },
                    { 80, 4, 2615.0, 1, 346, false, 14, 174694, 54, 6, 6, 1991 },
                    { 81, 7, 2094.0, 6, 461, false, 3, 368498, 11, 6, 5, 2012 },
                    { 82, 6, 3914.0, 6, 239, false, 2, 372970, 5, 4, 6, 2000 },
                    { 83, 5, 3962.0, 2, 422, false, 16, 409662, 61, 3, 4, 2011 },
                    { 84, 1, 2618.0, 1, 97, false, 1, 430587, 1, 1, 2, 2012 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 85, 3, 1956.0, 5, 451, false, 10, 89646, 38, 1, 5, 2000 },
                    { 86, 3, 3794.0, 5, 327, false, 19, 499005, 73, 6, 5, 2012 },
                    { 87, 8, 3576.0, 4, 430, false, 8, 371556, 29, 4, 3, 2013 },
                    { 88, 6, 3589.0, 2, 298, false, 15, 490405, 57, 1, 6, 1991 },
                    { 89, 2, 1846.0, 3, 194, false, 6, 79995, 23, 3, 5, 1996 },
                    { 90, 6, 1043.0, 2, 97, false, 3, 183062, 9, 4, 3, 2002 },
                    { 91, 8, 1512.0, 6, 411, false, 9, 233563, 34, 2, 5, 2014 },
                    { 92, 5, 2425.0, 1, 359, false, 10, 296918, 39, 4, 5, 2011 },
                    { 93, 4, 1928.0, 5, 441, false, 6, 315135, 21, 6, 6, 1999 },
                    { 94, 3, 2232.0, 5, 259, false, 14, 472831, 55, 5, 5, 1995 },
                    { 95, 8, 3672.0, 5, 456, false, 11, 213665, 43, 4, 5, 2009 },
                    { 96, 7, 2070.0, 3, 259, false, 14, 83240, 55, 3, 4, 1997 },
                    { 97, 4, 2532.0, 3, 260, false, 4, 58240, 15, 4, 5, 2010 },
                    { 98, 6, 2659.0, 6, 324, false, 2, 59312, 5, 1, 6, 2000 },
                    { 99, 3, 3964.0, 5, 367, false, 19, 160359, 73, 5, 4, 2018 },
                    { 100, 4, 2234.0, 5, 296, false, 11, 398323, 42, 5, 1, 2013 },
                    { 101, 3, 3940.0, 4, 62, false, 16, 437017, 62, 4, 3, 2019 },
                    { 102, 1, 3386.0, 6, 171, false, 18, 204915, 70, 6, 4, 2018 },
                    { 103, 4, 2126.0, 1, 204, false, 17, 92626, 67, 4, 1, 2010 },
                    { 104, 6, 1154.0, 3, 306, false, 9, 315826, 33, 2, 1, 2002 },
                    { 105, 8, 2381.0, 4, 193, false, 7, 477013, 25, 6, 5, 2009 },
                    { 106, 2, 1190.0, 3, 145, false, 18, 239980, 69, 1, 2, 2018 },
                    { 107, 1, 2071.0, 5, 324, false, 18, 310098, 70, 5, 4, 2021 },
                    { 108, 7, 2781.0, 6, 358, false, 13, 496312, 51, 4, 1, 1995 },
                    { 109, 2, 1017.0, 1, 431, false, 19, 344233, 74, 1, 2, 1994 },
                    { 110, 5, 3171.0, 1, 87, false, 12, 296831, 46, 3, 6, 2011 },
                    { 111, 1, 2979.0, 2, 485, false, 19, 438671, 75, 1, 1, 1993 },
                    { 112, 6, 1917.0, 1, 318, false, 6, 222098, 21, 2, 1, 1992 },
                    { 113, 4, 2279.0, 3, 96, false, 18, 256661, 71, 2, 6, 1992 },
                    { 114, 2, 2260.0, 1, 211, false, 11, 469126, 43, 2, 3, 2013 },
                    { 115, 1, 1167.0, 5, 492, false, 1, 124384, 2, 1, 5, 1994 },
                    { 116, 3, 2655.0, 2, 292, false, 14, 246963, 55, 4, 6, 1993 },
                    { 117, 4, 3950.0, 5, 225, false, 10, 182611, 37, 3, 4, 2020 },
                    { 118, 3, 1915.0, 2, 267, false, 2, 120638, 6, 1, 4, 2012 },
                    { 119, 6, 3650.0, 6, 188, false, 8, 270258, 29, 1, 2, 1995 },
                    { 120, 7, 2483.0, 4, 96, false, 16, 429455, 61, 1, 2, 1998 },
                    { 121, 2, 3131.0, 4, 127, false, 8, 245435, 29, 2, 5, 2009 },
                    { 122, 6, 2469.0, 6, 322, false, 16, 103944, 63, 6, 1, 2012 },
                    { 123, 5, 3942.0, 4, 308, false, 3, 159966, 10, 5, 5, 1990 },
                    { 124, 3, 3270.0, 2, 411, false, 4, 40060, 14, 2, 2, 1996 },
                    { 125, 2, 2030.0, 1, 170, false, 8, 312256, 31, 1, 4, 2009 },
                    { 126, 7, 2419.0, 1, 393, false, 2, 349152, 6, 6, 1, 1991 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 127, 2, 3560.0, 6, 260, false, 18, 297289, 69, 5, 1, 1997 },
                    { 128, 2, 1120.0, 5, 445, false, 8, 72788, 30, 6, 5, 2017 },
                    { 129, 6, 2412.0, 3, 158, false, 12, 254592, 45, 4, 4, 2009 },
                    { 130, 2, 2178.0, 1, 154, false, 5, 331142, 19, 4, 6, 2009 },
                    { 131, 5, 1433.0, 2, 370, false, 8, 221651, 30, 6, 6, 2020 },
                    { 132, 7, 2995.0, 2, 189, false, 14, 103612, 55, 1, 6, 2003 },
                    { 133, 2, 2599.0, 3, 127, false, 18, 391145, 70, 1, 1, 2010 },
                    { 134, 5, 2059.0, 3, 209, false, 19, 265261, 73, 3, 4, 1994 },
                    { 135, 3, 1315.0, 5, 170, false, 18, 462704, 69, 2, 1, 2002 },
                    { 136, 6, 3408.0, 1, 418, false, 3, 348725, 10, 4, 6, 1997 },
                    { 137, 4, 1767.0, 4, 458, false, 8, 264001, 31, 5, 1, 1999 },
                    { 138, 5, 3705.0, 2, 194, false, 6, 302488, 23, 2, 2, 2021 },
                    { 139, 3, 1485.0, 2, 69, false, 14, 454081, 54, 4, 6, 1995 },
                    { 140, 1, 1013.0, 3, 446, false, 13, 309797, 50, 2, 4, 2002 },
                    { 141, 1, 3531.0, 6, 233, false, 2, 364756, 7, 4, 6, 2016 },
                    { 142, 8, 2322.0, 4, 403, false, 1, 71516, 2, 2, 5, 2002 },
                    { 143, 8, 3786.0, 5, 121, false, 6, 413187, 22, 4, 4, 2001 },
                    { 144, 6, 3248.0, 6, 354, false, 17, 105099, 65, 1, 6, 2000 },
                    { 145, 6, 1492.0, 1, 104, false, 19, 442464, 75, 4, 5, 1998 },
                    { 146, 6, 3753.0, 3, 263, false, 1, 451617, 1, 4, 2, 2004 },
                    { 147, 6, 2867.0, 6, 81, false, 14, 36008, 53, 5, 2, 2013 },
                    { 148, 2, 2850.0, 5, 420, false, 9, 108337, 33, 5, 2, 2001 },
                    { 149, 3, 3010.0, 4, 85, false, 19, 165776, 73, 4, 1, 1990 },
                    { 150, 6, 3954.0, 2, 68, false, 10, 36228, 37, 2, 6, 2000 },
                    { 151, 1, 3678.0, 5, 167, false, 1, 278540, 3, 2, 4, 2008 },
                    { 152, 8, 3532.0, 5, 490, false, 16, 448865, 62, 2, 4, 2013 },
                    { 153, 6, 1599.0, 1, 82, false, 12, 432714, 45, 5, 1, 2007 },
                    { 154, 7, 2577.0, 2, 245, false, 6, 130981, 22, 1, 6, 1997 },
                    { 155, 4, 2812.0, 5, 86, false, 4, 37237, 14, 2, 2, 1993 },
                    { 156, 8, 2204.0, 2, 234, false, 11, 268333, 42, 3, 4, 2012 },
                    { 157, 4, 2236.0, 1, 162, false, 5, 437438, 19, 5, 1, 1990 },
                    { 158, 2, 1082.0, 6, 395, false, 12, 32330, 47, 1, 1, 1996 },
                    { 159, 6, 1941.0, 3, 427, false, 9, 65309, 33, 5, 3, 2004 },
                    { 160, 4, 1784.0, 6, 320, false, 15, 325224, 57, 5, 6, 1998 },
                    { 161, 6, 1754.0, 5, 163, false, 9, 28910, 34, 2, 5, 2019 },
                    { 162, 6, 3583.0, 1, 423, false, 18, 493692, 70, 6, 2, 2017 },
                    { 163, 1, 2583.0, 3, 342, false, 9, 221290, 34, 5, 1, 2007 },
                    { 164, 8, 2427.0, 6, 404, false, 1, 404132, 3, 4, 2, 1994 },
                    { 165, 8, 3358.0, 1, 153, false, 17, 265803, 67, 6, 3, 2005 },
                    { 166, 1, 2819.0, 5, 298, false, 5, 279759, 19, 4, 1, 2013 },
                    { 167, 3, 1570.0, 3, 385, false, 3, 75108, 9, 4, 3, 2012 },
                    { 168, 2, 2846.0, 1, 193, false, 10, 131489, 37, 6, 1, 2014 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 169, 2, 3619.0, 1, 302, false, 9, 418724, 34, 1, 3, 2005 },
                    { 170, 1, 2549.0, 3, 168, false, 13, 160130, 49, 1, 1, 2014 },
                    { 171, 1, 3980.0, 6, 108, false, 6, 228837, 23, 5, 2, 2018 },
                    { 172, 8, 3027.0, 2, 300, false, 8, 207801, 29, 1, 3, 2002 },
                    { 173, 6, 3703.0, 1, 280, false, 7, 278560, 27, 4, 1, 2002 },
                    { 174, 6, 1224.0, 1, 152, false, 13, 54345, 50, 1, 2, 2010 },
                    { 175, 2, 1457.0, 5, 413, false, 14, 168265, 53, 3, 3, 1995 },
                    { 176, 5, 1352.0, 5, 287, false, 2, 59343, 7, 2, 2, 2009 },
                    { 177, 6, 1100.0, 1, 471, false, 18, 206402, 71, 4, 3, 2010 },
                    { 178, 6, 1837.0, 4, 107, false, 13, 111804, 50, 1, 5, 2005 },
                    { 179, 2, 3810.0, 3, 204, false, 10, 266743, 39, 5, 1, 2005 },
                    { 180, 2, 1996.0, 2, 144, false, 10, 183746, 38, 6, 4, 2016 },
                    { 181, 6, 3662.0, 1, 101, false, 3, 455046, 11, 6, 2, 2017 },
                    { 182, 4, 1255.0, 3, 79, false, 15, 293896, 57, 4, 4, 2002 },
                    { 183, 2, 2107.0, 6, 248, false, 7, 66179, 26, 2, 1, 2003 },
                    { 184, 4, 2246.0, 2, 330, false, 7, 168708, 25, 1, 3, 2005 },
                    { 185, 3, 2510.0, 3, 451, false, 6, 317928, 23, 5, 5, 2020 },
                    { 186, 7, 2254.0, 5, 396, false, 10, 430083, 38, 4, 5, 2003 },
                    { 187, 4, 3489.0, 2, 440, false, 2, 160909, 7, 5, 3, 2013 },
                    { 188, 1, 2414.0, 2, 129, false, 14, 466150, 54, 3, 5, 2002 },
                    { 189, 2, 2529.0, 6, 86, false, 13, 124544, 49, 5, 1, 1991 },
                    { 190, 5, 1068.0, 5, 388, false, 17, 334213, 67, 1, 6, 2011 },
                    { 191, 5, 2512.0, 5, 64, false, 7, 304185, 25, 1, 4, 2012 },
                    { 192, 1, 1713.0, 4, 168, false, 12, 118048, 45, 4, 6, 1996 },
                    { 193, 3, 1735.0, 2, 484, false, 1, 93310, 2, 6, 4, 2005 },
                    { 194, 8, 2411.0, 5, 224, false, 15, 47362, 58, 4, 5, 2019 },
                    { 195, 5, 3927.0, 1, 404, false, 19, 448537, 74, 6, 2, 1999 },
                    { 196, 3, 1283.0, 2, 422, false, 2, 86641, 5, 3, 6, 2009 },
                    { 197, 1, 2405.0, 1, 197, false, 10, 445589, 39, 2, 4, 2003 },
                    { 198, 6, 3219.0, 3, 188, false, 15, 28868, 58, 1, 1, 2012 },
                    { 199, 5, 3280.0, 4, 195, false, 8, 403747, 31, 4, 5, 2003 },
                    { 200, 1, 2788.0, 5, 91, false, 4, 88968, 13, 5, 3, 2021 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 1, "", 1, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1504), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1506), "SeedOffer #1", null, 23546m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 2, "", 2, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1514), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1515), "SeedOffer #2", null, 37087m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 3, "", 3, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1517), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1518), "SeedOffer #3", null, 36647m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 4, "", 4, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1520), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1520), "SeedOffer #4", null, 19318m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 5, "", 5, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1523), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1523), "SeedOffer #5", null, 12028m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 6, "", 6, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1526), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1527), "SeedOffer #6", null, 10319m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 7, "", 7, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1529), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1529), "SeedOffer #7", null, 23082m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 8, "", 8, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1531), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1531), "SeedOffer #8", null, 26322m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 9, "", 9, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1533), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1533), "SeedOffer #9", null, 9831m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 10, "", 10, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1536), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1536), "SeedOffer #10", null, 19901m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 11, "", 11, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1538), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1538), "SeedOffer #11", null, 28910m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 12, "", 12, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1540), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1541), "SeedOffer #12", null, 33867m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 13, "", 13, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1543), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1543), "SeedOffer #13", null, 34151m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 14, "", 14, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1545), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1545), "SeedOffer #14", null, 1527m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 15, "", 15, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1547), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1548), "SeedOffer #15", null, 21712m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 16, "", 16, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1582), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1583), "SeedOffer #16", null, 26297m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 17, "", 17, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1585), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1586), "SeedOffer #17", null, 20183m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 18, "", 18, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1588), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1589), "SeedOffer #18", null, 12840m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 19, "", 19, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1591), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1591), "SeedOffer #19", null, 12538m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 20, "", 20, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1593), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1593), "SeedOffer #20", null, 37960m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 21, "", 21, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1595), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1595), "SeedOffer #21", null, 12308m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 22, "", 22, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1597), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1597), "SeedOffer #22", null, 12442m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 23, "", 23, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1599), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1599), "SeedOffer #23", null, 3728m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 24, "", 24, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1601), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1601), "SeedOffer #24", null, 13162m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 25, "", 25, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1603), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1604), "SeedOffer #25", null, 15431m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 26, "", 26, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1605), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1605), "SeedOffer #26", null, 38417m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 27, "", 27, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1607), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1607), "SeedOffer #27", null, 15333m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 28, "", 28, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1609), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1610), "SeedOffer #28", null, 2936m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 29, "", 29, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1611), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1612), "SeedOffer #29", null, 38489m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 30, "", 30, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1613), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1614), "SeedOffer #30", null, 33733m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 31, "", 31, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1615), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1616), "SeedOffer #31", null, 39152m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 32, "", 32, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1618), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1618), "SeedOffer #32", null, 1869m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 33, "", 33, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1620), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1621), "SeedOffer #33", null, 15366m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 34, "", 34, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1623), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1624), "SeedOffer #34", null, 15586m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 35, "", 35, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1625), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1626), "SeedOffer #35", null, 38082m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 36, "", 36, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1627), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1628), "SeedOffer #36", null, 9369m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 37, "", 37, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1629), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1630), "SeedOffer #37", null, 16194m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 38, "", 38, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1632), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1632), "SeedOffer #38", null, 2468m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 39, "", 39, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1686), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1686), "SeedOffer #39", null, 23254m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 40, "", 40, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1689), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1689), "SeedOffer #40", null, 5898m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 41, "", 41, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1691), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1691), "SeedOffer #41", null, 19742m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 42, "", 42, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1693), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1693), "SeedOffer #42", null, 16147m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 43, "", 43, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1695), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1695), "SeedOffer #43", null, 36617m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 44, "", 44, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1697), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1697), "SeedOffer #44", null, 2319m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 45, "", 45, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1699), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1699), "SeedOffer #45", null, 24928m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 46, "", 46, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1701), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1702), "SeedOffer #46", null, 24441m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 47, "", 47, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1703), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1703), "SeedOffer #47", null, 18225m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 48, "", 48, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1705), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1706), "SeedOffer #48", null, 19795m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 49, "", 49, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1708), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1708), "SeedOffer #49", null, 35390m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 50, "", 50, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1710), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1710), "SeedOffer #50", null, 2480m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 51, "", 51, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1712), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1712), "SeedOffer #51", null, 38307m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 52, "", 52, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1714), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1714), "SeedOffer #52", null, 15575m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 53, "", 53, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1716), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1717), "SeedOffer #53", null, 34033m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 54, "", 54, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1719), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1719), "SeedOffer #54", null, 7293m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 55, "", 55, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1721), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1721), "SeedOffer #55", null, 11800m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 56, "", 56, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1723), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1723), "SeedOffer #56", null, 37897m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 57, "", 57, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1725), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1725), "SeedOffer #57", null, 11645m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 58, "", 58, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1727), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1727), "SeedOffer #58", null, 24473m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 59, "", 59, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1729), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1729), "SeedOffer #59", null, 17775m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 60, "", 60, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1731), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1731), "SeedOffer #60", null, 19728m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 61, "", 61, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1733), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1733), "SeedOffer #61", null, 26828m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 62, "", 62, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1735), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1735), "SeedOffer #62", null, 20229m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 63, "", 63, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1737), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1738), "SeedOffer #63", null, 38103m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 64, "", 64, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1739), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1740), "SeedOffer #64", null, 30929m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 65, "", 65, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1781), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1782), "SeedOffer #65", null, 26395m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 66, "", 66, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1784), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1785), "SeedOffer #66", null, 30419m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 67, "", 67, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1786), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1787), "SeedOffer #67", null, 8719m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 68, "", 68, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1789), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1789), "SeedOffer #68", null, 37384m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 69, "", 69, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1791), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1791), "SeedOffer #69", null, 28396m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 70, "", 70, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1793), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1794), "SeedOffer #70", null, 30573m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 71, "", 71, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1795), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1796), "SeedOffer #71", null, 4345m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 72, "", 72, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1798), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1798), "SeedOffer #72", null, 14262m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 73, "", 73, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1800), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1800), "SeedOffer #73", null, 9053m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 74, "", 74, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1802), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1802), "SeedOffer #74", null, 18006m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 75, "", 75, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1804), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1804), "SeedOffer #75", null, 6520m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 76, "", 76, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1806), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1806), "SeedOffer #76", null, 32114m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 77, "", 77, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1808), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1809), "SeedOffer #77", null, 29731m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 78, "", 78, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1810), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1811), "SeedOffer #78", null, 18378m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 79, "", 79, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1812), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1813), "SeedOffer #79", null, 20990m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 80, "", 80, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1814), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1815), "SeedOffer #80", null, 10891m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 81, "", 81, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1817), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1817), "SeedOffer #81", null, 22287m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 82, "", 82, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1819), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1819), "SeedOffer #82", null, 20544m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 83, "", 83, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1821), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1821), "SeedOffer #83", null, 7765m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 84, "", 84, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1823), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1823), "SeedOffer #84", null, 17740m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 85, "", 85, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1825), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1825), "SeedOffer #85", null, 24516m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 86, "", 86, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1827), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1827), "SeedOffer #86", null, 2462m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 87, "", 87, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1867), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1867), "SeedOffer #87", null, 39667m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 88, "", 88, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1869), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1870), "SeedOffer #88", null, 37416m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 89, "", 89, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1871), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1871), "SeedOffer #89", null, 34357m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 90, "", 90, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1873), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1873), "SeedOffer #90", null, 15123m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 91, "", 91, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1875), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1876), "SeedOffer #91", null, 21816m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 92, "", 92, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1878), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1878), "SeedOffer #92", null, 36481m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 93, "", 93, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1880), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1880), "SeedOffer #93", null, 9865m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 94, "", 94, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1882), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1882), "SeedOffer #94", null, 26480m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 95, "", 95, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1884), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1884), "SeedOffer #95", null, 6445m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 96, "", 96, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1886), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1886), "SeedOffer #96", null, 39694m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 97, "", 97, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1888), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1888), "SeedOffer #97", null, 3824m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 98, "", 98, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1890), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1890), "SeedOffer #98", null, 27547m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 99, "", 99, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1892), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1892), "SeedOffer #99", null, 31156m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 100, "", 100, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1894), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1895), "SeedOffer #100", null, 24754m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 101, "", 101, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1896), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1897), "SeedOffer #101", null, 6534m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 102, "", 102, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1898), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1898), "SeedOffer #102", null, 21335m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 103, "", 103, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1900), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1900), "SeedOffer #103", null, 13465m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 104, "", 104, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1902), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1902), "SeedOffer #104", null, 36987m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 105, "", 105, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1904), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1904), "SeedOffer #105", null, 8576m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 106, "", 106, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1906), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1906), "SeedOffer #106", null, 21031m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 107, "", 107, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1908), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1908), "SeedOffer #107", null, 32923m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 108, "", 108, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1910), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1910), "SeedOffer #108", null, 39164m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 109, "", 109, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1912), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1912), "SeedOffer #109", null, 14937m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 110, "", 110, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1914), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1915), "SeedOffer #110", null, 34887m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 111, "", 111, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1916), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1917), "SeedOffer #111", null, 13110m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 112, "", 112, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1943), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1944), "SeedOffer #112", null, 21867m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 113, "", 113, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1945), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1946), "SeedOffer #113", null, 32369m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 114, "", 114, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1948), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1948), "SeedOffer #114", null, 6234m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 115, "", 115, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1950), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1950), "SeedOffer #115", null, 1617m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 116, "", 116, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1952), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1952), "SeedOffer #116", null, 11634m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 117, "", 117, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1954), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1954), "SeedOffer #117", null, 38362m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 118, "", 118, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1956), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1956), "SeedOffer #118", null, 27534m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 119, "", 119, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1958), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1959), "SeedOffer #119", null, 6069m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 120, "", 120, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1961), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1961), "SeedOffer #120", null, 11984m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 121, "", 121, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1963), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1963), "SeedOffer #121", null, 25604m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 122, "", 122, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1965), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1966), "SeedOffer #122", null, 19144m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 123, "", 123, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1967), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1968), "SeedOffer #123", null, 3035m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 124, "", 124, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1969), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1969), "SeedOffer #124", null, 5457m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 125, "", 125, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1971), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1971), "SeedOffer #125", null, 18214m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 126, "", 126, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1973), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1974), "SeedOffer #126", null, 36005m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 127, "", 127, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1975), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1976), "SeedOffer #127", null, 38155m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 128, "", 128, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1977), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1978), "SeedOffer #128", null, 23859m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 129, "", 129, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1979), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1980), "SeedOffer #129", null, 39742m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 130, "", 130, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1983), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(1983), "SeedOffer #130", null, 3106m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 131, "", 131, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2012), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2012), "SeedOffer #131", null, 12467m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 132, "", 132, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2014), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2014), "SeedOffer #132", null, 2799m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 133, "", 133, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2016), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2016), "SeedOffer #133", null, 15146m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 134, "", 134, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2018), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2018), "SeedOffer #134", null, 22788m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 135, "", 135, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2020), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2021), "SeedOffer #135", null, 23010m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 136, "", 136, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2022), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2023), "SeedOffer #136", null, 894m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 137, "", 137, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2024), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2025), "SeedOffer #137", null, 25386m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 138, "", 138, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2026), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2027), "SeedOffer #138", null, 11760m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 139, "", 139, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2028), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2029), "SeedOffer #139", null, 30615m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 140, "", 140, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2030), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2031), "SeedOffer #140", null, 39997m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 141, "", 141, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2033), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2033), "SeedOffer #141", null, 20367m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 142, "", 142, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2034), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2035), "SeedOffer #142", null, 24187m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 143, "", 143, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2037), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2037), "SeedOffer #143", null, 6423m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 144, "", 144, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2038), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2039), "SeedOffer #144", null, 8681m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 145, "", 145, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2041), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2041), "SeedOffer #145", null, 10964m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 146, "", 146, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2042), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2043), "SeedOffer #146", null, 6256m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 147, "", 147, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2044), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2045), "SeedOffer #147", null, 3949m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 148, "", 148, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2047), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2047), "SeedOffer #148", null, 4368m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 149, "", 149, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2049), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2049), "SeedOffer #149", null, 37736m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 150, "", 150, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2051), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2051), "SeedOffer #150", null, 35988m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 151, "", 151, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2053), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2054), "SeedOffer #151", null, 5827m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 152, "", 152, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2055), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2056), "SeedOffer #152", null, 29884m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 153, "", 153, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2057), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2058), "SeedOffer #153", null, 16416m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 154, "", 154, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2060), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2060), "SeedOffer #154", null, 6611m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 155, "", 155, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2062), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2062), "SeedOffer #155", null, 7071m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 156, "", 156, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2088), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2089), "SeedOffer #156", null, 26475m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 157, "", 157, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2090), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2091), "SeedOffer #157", null, 7663m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 158, "", 158, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2093), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2093), "SeedOffer #158", null, 25148m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 159, "", 159, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2095), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2095), "SeedOffer #159", null, 31146m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 160, "", 160, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2096), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2097), "SeedOffer #160", null, 21552m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 161, "", 161, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2099), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2099), "SeedOffer #161", null, 12988m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 162, "", 162, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2101), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2101), "SeedOffer #162", null, 992m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 163, "", 163, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2103), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2103), "SeedOffer #163", null, 33828m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 164, "", 164, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2105), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2105), "SeedOffer #164", null, 23331m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 165, "", 165, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2107), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2108), "SeedOffer #165", null, 38955m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 166, "", 166, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2110), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2110), "SeedOffer #166", null, 27156m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 167, "", 167, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2112), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2112), "SeedOffer #167", null, 13292m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 168, "", 168, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2113), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2114), "SeedOffer #168", null, 17229m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 169, "", 169, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2116), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2116), "SeedOffer #169", null, 15992m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 170, "", 170, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2118), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2118), "SeedOffer #170", null, 16657m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 171, "", 171, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2120), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2120), "SeedOffer #171", null, 22135m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 172, "", 172, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2122), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2123), "SeedOffer #172", null, 16393m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 173, "", 173, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2124), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2125), "SeedOffer #173", null, 1640m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 174, "", 174, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2126), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2127), "SeedOffer #174", null, 8055m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 175, "", 175, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2128), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2129), "SeedOffer #175", null, 22209m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 176, "", 176, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2130), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2131), "SeedOffer #176", null, 22975m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 177, "", 177, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2132), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2133), "SeedOffer #177", null, 23358m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 178, "", 178, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2135), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2135), "SeedOffer #178", null, 24311m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 179, "", 179, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2137), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2137), "SeedOffer #179", null, 7506m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 180, "", 180, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2139), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2139), "SeedOffer #180", null, 39111m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 181, "", 181, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2165), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2165), "SeedOffer #181", null, 16067m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 182, "", 182, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2167), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2167), "SeedOffer #182", null, 18687m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 183, "", 183, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2169), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2169), "SeedOffer #183", null, 27285m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 184, "", 184, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2171), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2172), "SeedOffer #184", null, 25158m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 185, "", 185, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2174), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2174), "SeedOffer #185", null, 21423m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 186, "", 186, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2175), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2176), "SeedOffer #186", null, 21268m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 187, "", 187, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2177), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2178), "SeedOffer #187", null, 15748m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 188, "", 188, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2179), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2180), "SeedOffer #188", null, 19601m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 189, "", 189, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2181), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2181), "SeedOffer #189", null, 13332m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 190, "", 190, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2183), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2184), "SeedOffer #190", null, 27579m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 191, "", 191, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2185), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2185), "SeedOffer #191", null, 27595m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 192, "", 192, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2187), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2187), "SeedOffer #192", null, 6337m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 193, "", 193, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2189), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2190), "SeedOffer #193", null, 3378m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 194, "", 194, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2191), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2192), "SeedOffer #194", null, 11474m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 195, "", 195, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2193), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2193), "SeedOffer #195", null, 21417m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 196, "", 196, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2195), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2196), "SeedOffer #196", null, 33638m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 197, "", 197, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2198), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2198), "SeedOffer #197", null, 24728m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 198, "", 198, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2200), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2200), "SeedOffer #198", null, 38346m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 199, "", 199, null, 1, "0789789789", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2202), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2202), "SeedOffer #199", null, 15728m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 200, "", 200, null, 1, "0123123123", new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2204), true, new DateTime(2022, 12, 20, 21, 22, 12, 580, DateTimeKind.Utc).AddTicks(2204), "SeedOffer #200", null, 3455m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
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
                name: "IX_NewsArticleComments_CommenterId",
                table: "NewsArticleComments",
                column: "CommenterId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticleComments_NewsArticleId",
                table: "NewsArticleComments",
                column: "NewsArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsArticles_AuthorId",
                table: "NewsArticles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferComments_CarPortalProfileId",
                table: "OfferComments",
                column: "CarPortalProfileId");

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
                name: "NewsArticleComments");

            migrationBuilder.DropTable(
                name: "OfferComments");

            migrationBuilder.DropTable(
                name: "ProfilesInterestedOffers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "NewsArticles");

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
