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
                name: "NewsArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    NewsArticleId = table.Column<int>(type: "int", nullable: false)
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
                    { "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", 10, "ac293375-5c89-42d5-ab5a-d0ac337805fb", "admin@carportal.com", true, false, null, "ADMIN@CARPORTAL.COM", "ADMIN", "AQAAAAEAACcQAAAAEM01/OI0M5HMkRV/YRz5sPp9x8YXc6ksrcu527JeXsTpjtM7h0NYgtxxlb8I13QN/A==", null, true, "b477be35-f36e-4986-91a4-2af08b8aace9", "550f99dc-373a-4f2c-b797-24e80ea1663c", false, "admin" },
                    { "1599b271-fc59-4726-a4a1-49e1ecc43b20", 10, "82e014d6-14b1-413d-96ee-4091cf56f02e", "dealer@carportal.com", true, false, null, "DEALER@CARPORTAL.COM", "DEALER", "AQAAAAEAACcQAAAAENSTpijXDSoMzjfEW7M1RePrSXQ2rI4siL/P7EegByAr6FF/dy+9XpeImLBz47jdlA==", null, true, "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "ec7b7d41-403a-4aea-976b-14b549806889", false, "dealer" },
                    { "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", 10, "3e4e2a48-0eb3-49f1-9bd8-96962812adb4", "newsWriter@carportal.com", true, false, null, "NEWSWRITER@CARPORTAL.COM", "NEWSWRITER", "AQAAAAEAACcQAAAAEGEygw7vvYikXs2Y6Y+fVRsfIg2H4loe9TRjZvq0mReLpKkwcVFULQEJURS81OpOUA==", null, true, "840f8101-dba1-4559-af43-a15af74d321c", "64976d79-2329-4be6-aa08-f417570b7431", false, "newsWriter" },
                    { "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", 10, "7dd98c6e-0ceb-4255-8467-14a4d49c8bdd", "regular@carportal.com", true, false, null, "REGULAR@CARPORTAL.COM", "REGULAR", "AQAAAAEAACcQAAAAEH+Zo9L1qEh76YMSqNJJaL13ITfW7bMVVwwtliS0ehSKfNMhh8RTmXE1j+Lfhag++w==", null, true, "243d758e-59b0-46bd-bc56-3b41c4adc264", "6cc8685f-6d78-4275-b10b-226c92260235", false, "regular" }
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
                    { "243d758e-59b0-46bd-bc56-3b41c4adc264", "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e", new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2284), false, null },
                    { "69f4e8cc-b668-4bdc-9822-c6be05dbdc07", "1599b271-fc59-4726-a4a1-49e1ecc43b20", new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2281), true, null },
                    { "840f8101-dba1-4559-af43-a15af74d321c", "6685d0bd-2872-4fb8-9ff9-8a6c0704c821", new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2278), false, null },
                    { "b477be35-f36e-4986-91a4-2af08b8aace9", "0f6ed7b5-ccd8-488b-a350-2aef1be56c0b", new DateTime(2022, 12, 20, 15, 12, 46, 742, DateTimeKind.Utc).AddTicks(2274), false, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 1, 1, 3319.0, 2, 456, false, 5, 158835, 18, 2, 2, 2002 },
                    { 2, 5, 3338.0, 5, 367, false, 3, 201184, 9, 2, 5, 2015 },
                    { 3, 1, 2489.0, 6, 437, false, 17, 485756, 65, 3, 1, 2011 },
                    { 4, 6, 3926.0, 3, 457, false, 19, 402875, 75, 2, 3, 2000 },
                    { 5, 1, 1286.0, 3, 201, false, 4, 392937, 13, 6, 2, 2017 },
                    { 6, 8, 1887.0, 2, 314, false, 11, 276946, 42, 5, 6, 1995 },
                    { 7, 2, 2033.0, 2, 406, false, 18, 254860, 69, 5, 1, 2012 },
                    { 8, 7, 1583.0, 6, 495, false, 16, 218659, 63, 2, 6, 2016 },
                    { 9, 8, 3321.0, 2, 413, false, 10, 343097, 37, 4, 1, 2000 },
                    { 10, 4, 1070.0, 4, 296, false, 8, 322774, 31, 1, 5, 2014 },
                    { 11, 3, 3598.0, 4, 390, false, 6, 324706, 22, 3, 2, 1995 },
                    { 12, 4, 3506.0, 3, 230, false, 16, 465892, 63, 5, 5, 2009 },
                    { 13, 8, 1575.0, 1, 192, false, 3, 249355, 9, 2, 4, 2010 },
                    { 14, 3, 1940.0, 2, 157, false, 18, 370089, 71, 2, 4, 2005 },
                    { 15, 5, 3763.0, 6, 450, false, 12, 204096, 46, 6, 4, 2005 },
                    { 16, 7, 3921.0, 1, 188, false, 14, 242771, 55, 5, 3, 2011 },
                    { 17, 4, 2236.0, 2, 228, false, 2, 228824, 6, 4, 1, 1998 },
                    { 18, 1, 1045.0, 6, 270, false, 3, 386799, 9, 3, 6, 1999 },
                    { 19, 3, 1287.0, 4, 291, false, 5, 350210, 18, 3, 1, 2005 },
                    { 20, 4, 1294.0, 6, 445, false, 7, 249594, 27, 1, 6, 1992 },
                    { 21, 5, 1617.0, 3, 403, false, 10, 484675, 37, 6, 1, 2010 },
                    { 22, 3, 2017.0, 6, 142, false, 5, 112411, 17, 4, 6, 1999 },
                    { 23, 8, 3259.0, 3, 344, false, 6, 113429, 23, 3, 6, 2008 },
                    { 24, 7, 2726.0, 1, 231, false, 10, 278071, 39, 2, 6, 2005 },
                    { 25, 1, 3572.0, 2, 410, false, 1, 130552, 1, 1, 3, 2007 },
                    { 26, 7, 2325.0, 5, 210, false, 6, 180799, 23, 1, 6, 2006 },
                    { 27, 1, 3573.0, 1, 147, false, 8, 213197, 31, 1, 6, 2014 },
                    { 28, 8, 1253.0, 5, 267, false, 13, 336074, 49, 1, 6, 1992 },
                    { 29, 5, 3251.0, 1, 201, false, 17, 58774, 67, 1, 4, 1999 },
                    { 30, 5, 1115.0, 5, 264, false, 19, 45726, 73, 1, 6, 2002 },
                    { 31, 1, 1586.0, 5, 79, false, 1, 404447, 1, 5, 1, 2021 },
                    { 32, 1, 2034.0, 1, 63, false, 11, 227111, 43, 5, 4, 2005 },
                    { 33, 4, 1806.0, 5, 161, false, 4, 263961, 14, 6, 4, 2007 },
                    { 34, 2, 2312.0, 2, 254, false, 1, 204705, 1, 2, 3, 2015 },
                    { 35, 6, 1070.0, 2, 464, false, 12, 170942, 45, 6, 1, 2015 },
                    { 36, 8, 2563.0, 6, 145, false, 14, 183299, 53, 6, 6, 2008 },
                    { 37, 7, 1545.0, 3, 172, false, 11, 371360, 41, 6, 2, 2018 },
                    { 38, 6, 3893.0, 5, 440, false, 6, 22700, 21, 5, 3, 2011 },
                    { 39, 6, 2559.0, 4, 245, false, 11, 265676, 43, 5, 2, 2004 },
                    { 40, 8, 3537.0, 6, 138, false, 12, 166537, 45, 4, 6, 1996 },
                    { 41, 4, 3310.0, 5, 454, false, 5, 469878, 19, 4, 1, 2016 },
                    { 42, 3, 1240.0, 3, 491, false, 9, 378121, 35, 4, 6, 1993 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 43, 7, 3904.0, 1, 460, false, 3, 72686, 11, 3, 5, 1993 },
                    { 44, 1, 2536.0, 2, 379, false, 9, 294425, 33, 6, 4, 2004 },
                    { 45, 4, 2549.0, 2, 273, false, 17, 154484, 66, 1, 4, 2000 },
                    { 46, 2, 1280.0, 4, 437, false, 2, 126522, 6, 3, 1, 2018 },
                    { 47, 7, 1563.0, 4, 220, false, 6, 416480, 23, 5, 4, 1996 },
                    { 48, 3, 2648.0, 4, 162, false, 8, 349841, 29, 3, 4, 2019 },
                    { 49, 8, 1837.0, 6, 212, false, 13, 433903, 51, 1, 3, 2013 },
                    { 50, 1, 1306.0, 1, 257, false, 12, 57003, 46, 6, 6, 2003 },
                    { 51, 5, 1049.0, 3, 62, false, 8, 422628, 29, 5, 6, 2008 },
                    { 52, 2, 3358.0, 6, 165, false, 10, 473271, 37, 6, 1, 2018 },
                    { 53, 3, 1565.0, 5, 333, false, 6, 415460, 23, 6, 4, 2000 },
                    { 54, 1, 3354.0, 5, 150, false, 12, 103909, 47, 6, 4, 2013 },
                    { 55, 2, 2522.0, 5, 387, false, 18, 176831, 71, 3, 1, 1992 },
                    { 56, 8, 3427.0, 2, 385, false, 3, 219806, 11, 6, 2, 2012 },
                    { 57, 3, 2125.0, 3, 173, false, 11, 499968, 43, 3, 1, 2002 },
                    { 58, 4, 1342.0, 3, 435, false, 5, 326376, 18, 3, 2, 1991 },
                    { 59, 1, 2015.0, 3, 91, false, 18, 103967, 71, 3, 6, 2014 },
                    { 60, 1, 1386.0, 6, 175, false, 14, 119834, 54, 5, 6, 2000 },
                    { 61, 2, 2735.0, 6, 289, false, 1, 275221, 3, 4, 1, 1997 },
                    { 62, 4, 2655.0, 6, 250, false, 14, 278328, 54, 6, 5, 2004 },
                    { 63, 1, 2038.0, 5, 249, false, 8, 325464, 30, 4, 1, 2017 },
                    { 64, 1, 1088.0, 2, 447, false, 5, 302866, 18, 2, 3, 1991 },
                    { 65, 3, 2130.0, 3, 460, false, 4, 160624, 14, 3, 1, 2001 },
                    { 66, 7, 3076.0, 1, 267, false, 19, 393522, 73, 6, 3, 2005 },
                    { 67, 8, 1235.0, 1, 225, false, 3, 443422, 9, 1, 6, 1990 },
                    { 68, 5, 2267.0, 3, 235, false, 19, 229727, 75, 4, 5, 1996 },
                    { 69, 7, 2499.0, 3, 101, false, 15, 199237, 58, 4, 5, 1994 },
                    { 70, 3, 1590.0, 2, 496, false, 11, 85451, 42, 6, 1, 2012 },
                    { 71, 6, 2251.0, 2, 128, false, 5, 196047, 18, 2, 2, 2012 },
                    { 72, 7, 2429.0, 2, 147, false, 10, 481536, 39, 1, 2, 1990 },
                    { 73, 5, 2957.0, 2, 492, false, 2, 358953, 7, 2, 6, 2004 },
                    { 74, 4, 1666.0, 2, 212, false, 19, 181938, 75, 1, 2, 2012 },
                    { 75, 1, 1821.0, 4, 395, false, 2, 209697, 5, 5, 6, 2000 },
                    { 76, 2, 3490.0, 4, 286, false, 9, 191901, 33, 5, 1, 1997 },
                    { 77, 6, 1336.0, 1, 214, false, 10, 305990, 39, 1, 6, 2012 },
                    { 78, 4, 2461.0, 3, 390, false, 10, 82470, 39, 5, 4, 2019 },
                    { 79, 3, 2178.0, 5, 131, false, 9, 453044, 33, 2, 6, 1997 },
                    { 80, 5, 3412.0, 2, 251, false, 8, 204186, 30, 5, 6, 2003 },
                    { 81, 1, 1111.0, 1, 153, false, 10, 103305, 39, 5, 6, 1990 },
                    { 82, 1, 1535.0, 5, 286, false, 1, 341027, 3, 3, 1, 2006 },
                    { 83, 5, 3464.0, 6, 344, false, 9, 176412, 33, 1, 6, 1997 },
                    { 84, 1, 2504.0, 3, 291, false, 4, 337660, 14, 2, 3, 1997 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 85, 6, 2343.0, 5, 330, false, 19, 61160, 74, 1, 5, 1995 },
                    { 86, 3, 3106.0, 5, 283, false, 10, 481151, 39, 6, 2, 1995 },
                    { 87, 2, 3145.0, 4, 491, false, 15, 494022, 57, 6, 2, 2003 },
                    { 88, 4, 2837.0, 6, 475, false, 12, 234760, 47, 1, 6, 1995 },
                    { 89, 5, 2824.0, 3, 448, false, 16, 219280, 62, 1, 5, 1998 },
                    { 90, 7, 3159.0, 3, 244, false, 4, 72067, 15, 3, 2, 2016 },
                    { 91, 2, 2880.0, 3, 226, false, 8, 271768, 31, 1, 3, 2019 },
                    { 92, 5, 1246.0, 1, 450, false, 7, 189407, 25, 2, 1, 1996 },
                    { 93, 7, 1759.0, 5, 306, false, 15, 157611, 58, 3, 4, 1994 },
                    { 94, 8, 3109.0, 4, 437, false, 7, 150540, 25, 2, 2, 2014 },
                    { 95, 4, 3152.0, 1, 129, false, 17, 254945, 66, 5, 1, 2021 },
                    { 96, 1, 3707.0, 5, 459, false, 18, 321775, 69, 4, 4, 2004 },
                    { 97, 7, 2805.0, 3, 227, false, 4, 264848, 14, 5, 3, 2017 },
                    { 98, 4, 3673.0, 1, 146, false, 9, 445449, 33, 4, 1, 2017 },
                    { 99, 2, 3791.0, 3, 184, false, 12, 55068, 45, 3, 5, 2018 },
                    { 100, 4, 3342.0, 3, 319, false, 12, 265576, 47, 4, 1, 2020 },
                    { 101, 3, 3084.0, 3, 469, false, 16, 205271, 62, 4, 5, 2012 },
                    { 102, 4, 1904.0, 5, 437, false, 2, 398267, 7, 5, 4, 1992 },
                    { 103, 8, 3608.0, 6, 385, false, 19, 351568, 74, 2, 1, 2018 },
                    { 104, 7, 1637.0, 4, 271, false, 2, 233988, 5, 6, 6, 2000 },
                    { 105, 8, 1776.0, 5, 115, false, 19, 123787, 73, 4, 6, 2015 },
                    { 106, 8, 1680.0, 1, 389, false, 12, 402099, 46, 2, 4, 2003 },
                    { 107, 2, 2688.0, 1, 495, false, 4, 320570, 15, 3, 2, 1993 },
                    { 108, 4, 2608.0, 6, 336, false, 10, 122000, 38, 3, 3, 2006 },
                    { 109, 2, 2112.0, 1, 473, false, 5, 398813, 19, 3, 2, 2012 },
                    { 110, 1, 3584.0, 6, 269, false, 5, 177061, 17, 1, 2, 2004 },
                    { 111, 8, 2126.0, 6, 179, false, 12, 225405, 45, 4, 6, 2021 },
                    { 112, 1, 2591.0, 2, 245, false, 19, 195306, 75, 2, 6, 1996 },
                    { 113, 4, 2205.0, 5, 401, false, 4, 444921, 13, 3, 5, 1993 },
                    { 114, 8, 1219.0, 4, 471, false, 12, 409161, 45, 6, 4, 2020 },
                    { 115, 3, 2456.0, 1, 161, false, 6, 164883, 22, 6, 5, 2011 },
                    { 116, 1, 1164.0, 4, 167, false, 17, 405323, 66, 5, 6, 1997 },
                    { 117, 8, 1152.0, 5, 271, false, 16, 457408, 62, 1, 2, 2002 },
                    { 118, 2, 3437.0, 4, 222, false, 6, 181947, 23, 1, 6, 2014 },
                    { 119, 7, 1693.0, 4, 447, false, 19, 444871, 73, 6, 4, 2004 },
                    { 120, 6, 1462.0, 3, 484, false, 4, 103391, 14, 4, 6, 1995 },
                    { 121, 2, 1978.0, 3, 466, false, 14, 416957, 54, 3, 6, 2013 },
                    { 122, 2, 2099.0, 5, 255, false, 18, 366452, 70, 4, 6, 2002 },
                    { 123, 8, 1275.0, 3, 169, false, 1, 263439, 3, 5, 3, 2020 },
                    { 124, 5, 1858.0, 1, 336, false, 5, 485389, 17, 6, 5, 2017 },
                    { 125, 2, 1444.0, 5, 309, false, 18, 329515, 69, 2, 5, 2016 },
                    { 126, 4, 3233.0, 6, 454, false, 4, 421771, 14, 4, 3, 2006 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 127, 8, 2250.0, 3, 258, false, 12, 291222, 46, 4, 1, 2019 },
                    { 128, 8, 2902.0, 5, 309, false, 19, 299903, 73, 4, 6, 1994 },
                    { 129, 3, 2662.0, 2, 364, false, 10, 263355, 39, 1, 4, 1997 },
                    { 130, 2, 2986.0, 4, 97, false, 13, 192166, 51, 6, 5, 2004 },
                    { 131, 8, 1514.0, 2, 126, false, 5, 394166, 19, 6, 2, 2020 },
                    { 132, 7, 1730.0, 2, 470, false, 2, 462054, 6, 2, 5, 1995 },
                    { 133, 5, 1371.0, 4, 171, false, 9, 363896, 34, 4, 3, 2004 },
                    { 134, 8, 1034.0, 1, 114, false, 9, 59436, 34, 4, 4, 2003 },
                    { 135, 2, 3889.0, 6, 360, false, 13, 207098, 51, 3, 5, 2020 },
                    { 136, 1, 1676.0, 3, 121, false, 7, 178307, 26, 3, 1, 2020 },
                    { 137, 7, 1006.0, 6, 279, false, 12, 313324, 47, 1, 4, 2015 },
                    { 138, 7, 1264.0, 3, 490, false, 3, 217606, 11, 4, 2, 2005 },
                    { 139, 8, 2202.0, 6, 397, false, 19, 166158, 75, 4, 2, 1994 },
                    { 140, 7, 3657.0, 2, 241, false, 15, 176865, 58, 3, 1, 1998 },
                    { 141, 2, 1077.0, 3, 387, false, 19, 467931, 74, 6, 3, 1993 },
                    { 142, 5, 2606.0, 3, 293, false, 8, 485819, 29, 5, 2, 2000 },
                    { 143, 6, 1429.0, 6, 94, false, 4, 281632, 14, 3, 6, 2017 },
                    { 144, 5, 3833.0, 3, 491, false, 9, 491607, 34, 2, 6, 1995 },
                    { 145, 1, 3781.0, 3, 452, false, 19, 132951, 74, 3, 5, 1992 },
                    { 146, 2, 1648.0, 3, 355, false, 9, 158967, 34, 2, 1, 1999 },
                    { 147, 4, 2252.0, 1, 303, false, 5, 351190, 19, 4, 5, 1993 },
                    { 148, 7, 2865.0, 4, 189, false, 10, 96555, 37, 1, 1, 1993 },
                    { 149, 3, 3619.0, 6, 228, false, 8, 215718, 31, 5, 2, 2019 },
                    { 150, 6, 1703.0, 2, 279, false, 14, 483661, 54, 3, 3, 2009 },
                    { 151, 3, 3755.0, 3, 178, false, 7, 233821, 25, 6, 6, 2001 },
                    { 152, 1, 3550.0, 6, 104, false, 5, 219614, 17, 2, 3, 2018 },
                    { 153, 7, 3805.0, 3, 332, false, 6, 163438, 21, 4, 1, 2016 },
                    { 154, 7, 1804.0, 2, 410, false, 2, 398431, 5, 3, 2, 2011 },
                    { 155, 2, 1090.0, 3, 404, false, 1, 399656, 3, 5, 3, 2012 },
                    { 156, 7, 1446.0, 5, 237, false, 19, 305277, 73, 1, 5, 2019 },
                    { 157, 6, 1704.0, 2, 317, false, 17, 282935, 65, 3, 3, 2021 },
                    { 158, 7, 2039.0, 2, 499, false, 10, 156474, 38, 2, 1, 2005 },
                    { 159, 7, 3163.0, 5, 371, false, 19, 40553, 74, 1, 5, 2016 },
                    { 160, 3, 2132.0, 6, 205, false, 7, 265063, 26, 1, 2, 1992 },
                    { 161, 5, 1613.0, 4, 448, false, 12, 93371, 46, 6, 6, 1998 },
                    { 162, 5, 3975.0, 6, 230, false, 8, 57704, 31, 2, 3, 2006 },
                    { 163, 8, 3026.0, 5, 140, false, 19, 449422, 75, 1, 3, 2009 },
                    { 164, 2, 1346.0, 4, 353, false, 10, 361818, 39, 5, 3, 2013 },
                    { 165, 1, 3027.0, 1, 308, false, 8, 481016, 30, 1, 5, 2018 },
                    { 166, 8, 3667.0, 2, 195, false, 17, 254927, 66, 2, 6, 2002 },
                    { 167, 4, 2778.0, 6, 364, false, 5, 319503, 18, 2, 4, 2001 },
                    { 168, 3, 3817.0, 4, 304, false, 15, 24800, 59, 3, 1, 2001 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "EngineDisplacement", "FuelTypeId", "HorsePower", "IsBrandNew", "ManufacturerId", "Mileage", "ModelId", "TransmissionTypeId", "VehicleCategoryId", "Year" },
                values: new object[,]
                {
                    { 169, 4, 1314.0, 1, 487, false, 11, 218730, 43, 4, 6, 2008 },
                    { 170, 4, 2427.0, 6, 121, false, 8, 437540, 30, 3, 5, 2006 },
                    { 171, 8, 2467.0, 6, 289, false, 4, 80898, 13, 1, 5, 2008 },
                    { 172, 8, 1050.0, 6, 205, false, 16, 262021, 63, 5, 6, 1995 },
                    { 173, 5, 3481.0, 2, 198, false, 4, 74256, 13, 5, 3, 1990 },
                    { 174, 4, 3101.0, 4, 136, false, 8, 175523, 30, 6, 6, 1993 },
                    { 175, 3, 2119.0, 6, 260, false, 15, 90896, 58, 3, 5, 2002 },
                    { 176, 6, 1004.0, 5, 145, false, 2, 499942, 5, 5, 2, 2002 },
                    { 177, 3, 1308.0, 3, 113, false, 6, 338021, 23, 6, 1, 1998 },
                    { 178, 8, 3475.0, 2, 234, false, 7, 133745, 25, 1, 2, 2021 },
                    { 179, 2, 2256.0, 1, 304, false, 18, 107500, 71, 4, 5, 2005 },
                    { 180, 8, 1858.0, 6, 428, false, 15, 54381, 59, 6, 5, 2018 },
                    { 181, 6, 2433.0, 6, 165, false, 12, 149601, 45, 3, 6, 2006 },
                    { 182, 7, 1113.0, 5, 345, false, 10, 302691, 38, 3, 4, 2014 },
                    { 183, 3, 2166.0, 4, 149, false, 17, 322515, 65, 4, 3, 2020 },
                    { 184, 6, 3116.0, 1, 168, false, 14, 65973, 53, 2, 3, 2001 },
                    { 185, 8, 3205.0, 1, 367, false, 11, 262230, 41, 3, 4, 2021 },
                    { 186, 1, 1866.0, 6, 104, false, 17, 43270, 66, 2, 2, 2009 },
                    { 187, 1, 2679.0, 2, 421, false, 13, 349092, 50, 3, 2, 2014 },
                    { 188, 5, 2519.0, 4, 135, false, 4, 447925, 15, 5, 6, 2021 },
                    { 189, 1, 3768.0, 5, 213, false, 4, 113149, 14, 2, 1, 1994 },
                    { 190, 3, 2810.0, 4, 263, false, 6, 292975, 23, 2, 3, 2008 },
                    { 191, 1, 3657.0, 6, 213, false, 6, 462994, 22, 5, 3, 2012 },
                    { 192, 1, 1115.0, 1, 86, false, 7, 460920, 26, 1, 4, 1994 },
                    { 193, 1, 2192.0, 5, 265, false, 1, 65288, 2, 5, 1, 2002 },
                    { 194, 8, 2606.0, 6, 429, false, 13, 252296, 49, 6, 2, 1997 },
                    { 195, 8, 3481.0, 3, 247, false, 16, 415326, 63, 5, 1, 2018 },
                    { 196, 8, 2682.0, 6, 360, false, 19, 469993, 75, 2, 6, 1998 },
                    { 197, 8, 1460.0, 5, 392, false, 6, 410858, 21, 5, 3, 2011 },
                    { 198, 2, 1596.0, 5, 434, false, 10, 123832, 39, 2, 4, 2018 },
                    { 199, 8, 2647.0, 1, 466, false, 2, 93997, 7, 2, 3, 2011 },
                    { 200, 1, 3778.0, 4, 311, false, 6, 249514, 21, 2, 5, 2018 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 1, "", 1, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2389), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2390), "SeedOffer #1", null, 25842m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 2, "", 2, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2400), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2400), "SeedOffer #2", null, 33228m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 3, "", 3, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2403), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2404), "SeedOffer #3", null, 31087m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 4, "", 4, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2406), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2406), "SeedOffer #4", null, 13267m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 5, "", 5, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2408), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2409), "SeedOffer #5", null, 14624m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 6, "", 6, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2412), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2412), "SeedOffer #6", null, 16033m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 7, "", 7, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2414), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2414), "SeedOffer #7", null, 5569m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 8, "", 8, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2416), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2417), "SeedOffer #8", null, 37048m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 9, "", 9, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2418), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2419), "SeedOffer #9", null, 5326m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 10, "", 10, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2421), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2422), "SeedOffer #10", null, 20051m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 11, "", 11, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2424), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2424), "SeedOffer #11", null, 19691m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 12, "", 12, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2426), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2426), "SeedOffer #12", null, 31489m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 13, "", 13, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2428), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2428), "SeedOffer #13", null, 15400m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 14, "", 14, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2430), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2431), "SeedOffer #14", null, 1476m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 15, "", 15, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2433), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2433), "SeedOffer #15", null, 18878m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 16, "", 16, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2435), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2435), "SeedOffer #16", null, 31427m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 17, "", 17, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2437), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2438), "SeedOffer #17", null, 25130m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 18, "", 18, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2440), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2440), "SeedOffer #18", null, 19538m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 19, "", 19, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2442), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2443), "SeedOffer #19", null, 23035m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 20, "", 20, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2445), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2445), "SeedOffer #20", null, 25260m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 21, "", 21, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2447), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2447), "SeedOffer #21", null, 30043m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 22, "", 22, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2449), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2449), "SeedOffer #22", null, 24471m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 23, "", 23, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2504), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2504), "SeedOffer #23", null, 4157m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 24, "", 24, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2506), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2506), "SeedOffer #24", null, 36487m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 25, "", 25, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2507), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2508), "SeedOffer #25", null, 30651m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 26, "", 26, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2510), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2510), "SeedOffer #26", null, 21493m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 27, "", 27, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2512), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2512), "SeedOffer #27", null, 3861m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 28, "", 28, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2514), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2514), "SeedOffer #28", null, 3389m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 29, "", 29, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2515), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2516), "SeedOffer #29", null, 36753m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 30, "", 30, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2517), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2518), "SeedOffer #30", null, 36676m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 31, "", 31, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2519), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2520), "SeedOffer #31", null, 15184m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 32, "", 32, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2521), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2521), "SeedOffer #32", null, 22012m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 33, "", 33, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2523), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2523), "SeedOffer #33", null, 38672m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 34, "", 34, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2526), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2526), "SeedOffer #34", null, 6745m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 35, "", 35, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2528), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2528), "SeedOffer #35", null, 18002m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 36, "", 36, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2530), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2530), "SeedOffer #36", null, 10164m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 37, "", 37, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2532), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2532), "SeedOffer #37", null, 32752m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 38, "", 38, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2534), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2534), "SeedOffer #38", null, 28707m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 39, "", 39, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2536), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2536), "SeedOffer #39", null, 1674m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 40, "", 40, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2538), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2538), "SeedOffer #40", null, 29242m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 41, "", 41, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2540), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2540), "SeedOffer #41", null, 1611m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 42, "", 42, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2542), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2543), "SeedOffer #42", null, 33451m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 43, "", 43, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2544), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2544), "SeedOffer #43", null, 8228m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 44, "", 44, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2546), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2546), "SeedOffer #44", null, 21992m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 45, "", 45, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2548), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2548), "SeedOffer #45", null, 5918m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 46, "", 46, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2550), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2550), "SeedOffer #46", null, 31837m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 47, "", 47, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2551), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2552), "SeedOffer #47", null, 25731m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 48, "", 48, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2553), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2553), "SeedOffer #48", null, 2928m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 49, "", 49, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2555), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2555), "SeedOffer #49", null, 16133m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 50, "", 50, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2581), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2581), "SeedOffer #50", null, 8992m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 51, "", 51, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2583), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2583), "SeedOffer #51", null, 8681m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 52, "", 52, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2584), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2585), "SeedOffer #52", null, 17863m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 53, "", 53, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2586), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2586), "SeedOffer #53", null, 31179m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 54, "", 54, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2588), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2588), "SeedOffer #54", null, 1212m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 55, "", 55, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2590), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2590), "SeedOffer #55", null, 5946m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 56, "", 56, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2591), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2592), "SeedOffer #56", null, 28859m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 57, "", 57, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2593), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2594), "SeedOffer #57", null, 3246m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 58, "", 58, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2596), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2596), "SeedOffer #58", null, 1106m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 59, "", 59, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2597), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2598), "SeedOffer #59", null, 21880m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 60, "", 60, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2599), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2600), "SeedOffer #60", null, 3391m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 61, "", 61, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2601), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2601), "SeedOffer #61", null, 9868m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 62, "", 62, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2603), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2603), "SeedOffer #62", null, 9986m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 63, "", 63, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2605), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2605), "SeedOffer #63", null, 6188m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 64, "", 64, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2607), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2607), "SeedOffer #64", null, 1819m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 65, "", 65, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2609), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2609), "SeedOffer #65", null, 20600m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 66, "", 66, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2612), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2612), "SeedOffer #66", null, 19745m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 67, "", 67, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2613), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2614), "SeedOffer #67", null, 3294m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 68, "", 68, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2615), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2615), "SeedOffer #68", null, 3455m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 69, "", 69, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2617), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2617), "SeedOffer #69", null, 35487m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 70, "", 70, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2619), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2620), "SeedOffer #70", null, 3631m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 71, "", 71, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2621), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2621), "SeedOffer #71", null, 31216m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 72, "", 72, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2623), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2623), "SeedOffer #72", null, 1261m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 73, "", 73, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2625), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2625), "SeedOffer #73", null, 27312m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 74, "", 74, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2627), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2627), "SeedOffer #74", null, 27661m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 75, "", 75, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2629), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2629), "SeedOffer #75", null, 6536m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 76, "", 76, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2654), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2655), "SeedOffer #76", null, 736m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 77, "", 77, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2656), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2657), "SeedOffer #77", null, 36980m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 78, "", 78, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2658), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2659), "SeedOffer #78", null, 14414m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 79, "", 79, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2661), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2661), "SeedOffer #79", null, 33758m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 80, "", 80, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2662), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2663), "SeedOffer #80", null, 13680m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 81, "", 81, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2664), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2665), "SeedOffer #81", null, 23361m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 82, "", 82, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2666), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2667), "SeedOffer #82", null, 4090m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 83, "", 83, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2668), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2669), "SeedOffer #83", null, 32100m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 84, "", 84, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2671), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2671), "SeedOffer #84", null, 21862m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 85, "", 85, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2673), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2673), "SeedOffer #85", null, 17153m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 86, "", 86, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2675), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2675), "SeedOffer #86", null, 27170m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 87, "", 87, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2676), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2677), "SeedOffer #87", null, 38347m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 88, "", 88, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2678), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2678), "SeedOffer #88", null, 11657m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 89, "", 89, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2680), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2680), "SeedOffer #89", null, 19007m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 90, "", 90, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2682), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2682), "SeedOffer #90", null, 13538m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 91, "", 91, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2684), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2684), "SeedOffer #91", null, 2275m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 92, "", 92, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2686), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2686), "SeedOffer #92", null, 20643m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 93, "", 93, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2688), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2688), "SeedOffer #93", null, 8979m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 94, "", 94, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2690), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2690), "SeedOffer #94", null, 23925m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 95, "", 95, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2692), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2692), "SeedOffer #95", null, 33971m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 96, "", 96, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2694), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2694), "SeedOffer #96", null, 14641m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 97, "", 97, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2696), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2696), "SeedOffer #97", null, 13520m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 98, "", 98, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2697), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2698), "SeedOffer #98", null, 21576m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 99, "", 99, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2699), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2700), "SeedOffer #99", null, 19665m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 100, "", 100, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2702), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2702), "SeedOffer #100", null, 20358m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 101, "", 101, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2704), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2704), "SeedOffer #101", null, 8584m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 102, "", 102, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2706), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2706), "SeedOffer #102", null, 27275m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 103, "", 103, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2708), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2708), "SeedOffer #103", null, 4560m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 104, "", 104, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2709), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2710), "SeedOffer #104", null, 30677m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 105, "", 105, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2735), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2735), "SeedOffer #105", null, 22723m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 106, "", 106, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2737), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2737), "SeedOffer #106", null, 10960m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 107, "", 107, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2739), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2739), "SeedOffer #107", null, 12078m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 108, "", 108, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2741), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2741), "SeedOffer #108", null, 33440m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 109, "", 109, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2743), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2743), "SeedOffer #109", null, 6306m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 110, "", 110, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2745), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2745), "SeedOffer #110", null, 8318m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 111, "", 111, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2747), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2747), "SeedOffer #111", null, 10830m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 112, "", 112, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2749), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2749), "SeedOffer #112", null, 10948m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 113, "", 113, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2751), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2751), "SeedOffer #113", null, 36714m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 114, "", 114, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2753), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2753), "SeedOffer #114", null, 20525m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 115, "", 115, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2755), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2755), "SeedOffer #115", null, 21983m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 116, "", 116, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2757), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2757), "SeedOffer #116", null, 22061m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 117, "", 117, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2759), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2759), "SeedOffer #117", null, 25800m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 118, "", 118, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2760), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2761), "SeedOffer #118", null, 31232m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 119, "", 119, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2762), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2762), "SeedOffer #119", null, 5955m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 120, "", 120, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2764), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2764), "SeedOffer #120", null, 34219m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 121, "", 121, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2766), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2766), "SeedOffer #121", null, 22254m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 122, "", 122, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2768), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2768), "SeedOffer #122", null, 14555m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 123, "", 123, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2770), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2771), "SeedOffer #123", null, 5005m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 124, "", 124, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2772), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2773), "SeedOffer #124", null, 35458m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 125, "", 125, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2774), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2775), "SeedOffer #125", null, 37439m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 126, "", 126, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2776), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2776), "SeedOffer #126", null, 5463m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 127, "", 127, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2778), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2778), "SeedOffer #127", null, 11602m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 128, "", 128, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2780), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2780), "SeedOffer #128", null, 29751m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 129, "", 129, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2782), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2782), "SeedOffer #129", null, 6546m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 130, "", 130, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2810), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2810), "SeedOffer #130", null, 9422m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 131, "", 131, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2812), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2813), "SeedOffer #131", null, 4381m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 132, "", 132, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2814), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2814), "SeedOffer #132", null, 30906m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 133, "", 133, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2816), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2817), "SeedOffer #133", null, 21093m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 134, "", 134, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2818), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2818), "SeedOffer #134", null, 4478m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 135, "", 135, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2820), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2820), "SeedOffer #135", null, 15500m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 136, "", 136, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2822), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2822), "SeedOffer #136", null, 12043m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 137, "", 137, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2824), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2824), "SeedOffer #137", null, 27382m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 138, "", 138, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2826), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2826), "SeedOffer #138", null, 892m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 139, "", 139, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2828), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2828), "SeedOffer #139", null, 5413m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 140, "", 140, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2829), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2830), "SeedOffer #140", null, 3346m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 141, "", 141, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2831), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2831), "SeedOffer #141", null, 33119m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 142, "", 142, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2833), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2833), "SeedOffer #142", null, 15190m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 143, "", 143, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2835), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2835), "SeedOffer #143", null, 12540m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 144, "", 144, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2836), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2837), "SeedOffer #144", null, 32930m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 145, "", 145, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2838), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2839), "SeedOffer #145", null, 18245m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 146, "", 146, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2840), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2840), "SeedOffer #146", null, 4369m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 147, "", 147, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2842), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2843), "SeedOffer #147", null, 26798m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 148, "", 148, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2844), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2844), "SeedOffer #148", null, 15154m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 149, "", 149, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2846), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2846), "SeedOffer #149", null, 22408m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 150, "", 150, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2848), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2848), "SeedOffer #150", null, 24391m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 151, "", 151, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2850), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2850), "SeedOffer #151", null, 14706m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 152, "", 152, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2852), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2852), "SeedOffer #152", null, 1840m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 153, "", 153, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2853), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2854), "SeedOffer #153", null, 3348m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 154, "", 154, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2881), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2881), "SeedOffer #154", null, 13857m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 155, "", 155, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2882), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2883), "SeedOffer #155", null, 3507m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 156, "", 156, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2884), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2885), "SeedOffer #156", null, 22291m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 157, "", 157, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2886), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2887), "SeedOffer #157", null, 32262m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 158, "", 158, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2888), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2888), "SeedOffer #158", null, 19672m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 159, "", 159, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2890), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2890), "SeedOffer #159", null, 13584m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 160, "", 160, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2891), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2892), "SeedOffer #160", null, 26106m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 161, "", 161, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2893), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2894), "SeedOffer #161", null, 9357m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 162, "", 162, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2895), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2895), "SeedOffer #162", null, 31175m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 163, "", 163, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2897), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2897), "SeedOffer #163", null, 11154m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 164, "", 164, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2899), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2899), "SeedOffer #164", null, 2365m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 165, "", 165, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2900), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2901), "SeedOffer #165", null, 20975m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 166, "", 166, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2902), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2902), "SeedOffer #166", null, 18047m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 167, "", 167, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2904), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2904), "SeedOffer #167", null, 36395m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 168, "", 168, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2906), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2906), "SeedOffer #168", null, 34020m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "AdditionalInfo", "CarId", "CarPortalProfileId", "CityId", "ContactPhoneNumber", "CreatedOn", "IsActive", "LastEdited", "Name", "OfferThumbnailId", "Price", "RegionId", "SellerId" },
                values: new object[,]
                {
                    { 169, "", 169, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2908), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2908), "SeedOffer #169", null, 37248m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 170, "", 170, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2909), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2910), "SeedOffer #170", null, 30036m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 171, "", 171, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2911), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2912), "SeedOffer #171", null, 27584m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 172, "", 172, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2913), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2913), "SeedOffer #172", null, 33249m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 173, "", 173, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2915), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2915), "SeedOffer #173", null, 5746m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 174, "", 174, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2917), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2917), "SeedOffer #174", null, 37929m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 175, "", 175, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2918), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2919), "SeedOffer #175", null, 6742m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 176, "", 176, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2920), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2921), "SeedOffer #176", null, 29590m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 177, "", 177, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2922), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2922), "SeedOffer #177", null, 31313m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 178, "", 178, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2924), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2924), "SeedOffer #178", null, 883m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 179, "", 179, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2925), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2926), "SeedOffer #179", null, 19554m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 180, "", 180, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2927), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2928), "SeedOffer #180", null, 36006m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 181, "", 181, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2929), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2929), "SeedOffer #181", null, 7798m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 182, "", 182, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2955), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2956), "SeedOffer #182", null, 4000m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 183, "", 183, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2957), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2958), "SeedOffer #183", null, 13985m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 184, "", 184, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2959), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2960), "SeedOffer #184", null, 7491m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 185, "", 185, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2961), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2961), "SeedOffer #185", null, 38049m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 186, "", 186, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2963), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2963), "SeedOffer #186", null, 29102m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 187, "", 187, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2965), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2965), "SeedOffer #187", null, 23029m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 188, "", 188, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2967), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2967), "SeedOffer #188", null, 19985m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 189, "", 189, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2969), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2969), "SeedOffer #189", null, 31949m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 190, "", 190, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2971), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2971), "SeedOffer #190", null, 26699m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 191, "", 191, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2973), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2973), "SeedOffer #191", null, 38389m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 192, "", 192, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2975), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2975), "SeedOffer #192", null, 18965m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 193, "", 193, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2977), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2977), "SeedOffer #193", null, 31968m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 194, "", 194, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2978), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2979), "SeedOffer #194", null, 8009m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 195, "", 195, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2980), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2980), "SeedOffer #195", null, 21860m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 196, "", 196, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2982), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2982), "SeedOffer #196", null, 38397m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 197, "", 197, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2984), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2984), "SeedOffer #197", null, 1013m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 198, "", 198, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2985), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2986), "SeedOffer #198", null, 33953m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" },
                    { 199, "", 199, null, 1, "0789789789", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2987), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2988), "SeedOffer #199", null, 1653m, 1, "f0ee2dbc-6f89-4177-8c5d-5503d717ff2e" },
                    { 200, "", 200, null, 1, "0123123123", new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2989), true, new DateTime(2022, 12, 20, 15, 12, 46, 744, DateTimeKind.Utc).AddTicks(2989), "SeedOffer #200", null, 1921m, 1, "1599b271-fc59-4726-a4a1-49e1ecc43b20" }
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
