using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderApplicationServer.Web.Data.Migrations
{
    public partial class iinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ord");

            migrationBuilder.EnsureSchema(
                name: "prod");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "ord",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperties",
                schema: "prod",
                columns: table => new
                {
                    ProductPropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperties", x => x.ProductPropertyId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "prod",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "OrderPositions",
                schema: "ord",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderPositionId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPositions", x => new { x.OrderId, x.OrderPositionId });
                    table.ForeignKey(
                        name: "FK_OrderPositions_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "prod",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductProperty",
                schema: "prod",
                columns: table => new
                {
                    ProductPropertiesProductPropertyId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductProperty", x => new { x.ProductPropertiesProductPropertyId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_ProductProductProperty_ProductProperties_ProductPropertiesProductPropertyId",
                        column: x => x.ProductPropertiesProductPropertyId,
                        principalSchema: "prod",
                        principalTable: "ProductProperties",
                        principalColumn: "ProductPropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductProperty_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalSchema: "prod",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "rrrrrrrr-22b1-4479-j58g-rrrrrrrr", "03680d48-eae8-4e57-a44f-debde61e331f", "User", "USER" },
                    { "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr", "51290a00-75c5-4f92-b3b3-92287205be54", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "435dbe81-22b1-4479-bea2-d730a7750aa1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8160ba0e-a346-43aa-8810-2ad9da93a4af", new DateTime(2021, 12, 20, 10, 4, 11, 609, DateTimeKind.Local).AddTicks(7890), "ddevito@gmail.com", true, "Danny", "Devito", false, null, "DDEVITO@GMAIL.COM", "DDEVITO", "AQAAAAEAACcQAAAAEAm/R8BcByNqwzTp33CaVCcP1hZ5bxV2EJcuZxisZjADJUkHlF5u/toUsTvQwgMA4g==", "+1111111111", true, "d04ee2db-7e93-430e-a7a5-e9c9a3f53e5b", false, "ddevito" },
                    { "z65dbe81-22b1-4479-j58g-d730ap050aa1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "62699e39-c253-4548-b6a7-3cf608e595a6", new DateTime(2021, 12, 20, 10, 4, 11, 609, DateTimeKind.Local).AddTicks(7949), "bbrot@gmail.com", true, "Bernd", "Brot", false, null, "BBROT@GMAIL.COM", "BBROT", "AQAAAAEAACcQAAAAEArZjn8t2hPQ8soAO3h/fxvMStTLjMuFbhr45vmGGU+Bj+VcqwD9gxJiekup4th1fQ==", "+222222222", true, "f065ed62-ff97-4ef6-a49f-e16e587c63c4", false, "bbrot" }
                });

            migrationBuilder.InsertData(
                schema: "prod",
                table: "ProductProperties",
                columns: new[] { "ProductPropertyId", "Notes", "Title" },
                values: new object[,]
                {
                    { 1, "Food, Snacks including Drinks", "Food" },
                    { 2, "Video Games", "Game" },
                    { 3, "Item can be consumed", "Consumable" },
                    { 4, "Toy Figure", "Toy" },
                    { 5, "Item can be used", "Utility" }
                });

            migrationBuilder.InsertData(
                schema: "prod",
                table: "Products",
                columns: new[] { "ProductId", "ImgPath", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "/Images/img1.jpg", 69.99m, "Very Far Away Horse for GAMECUBE" },
                    { 2, "/Images/img2.jpg", 9.99m, "Funeral Kazoo" },
                    { 3, "/Images/img3.jpg", 14.99m, "Muppet Screams" },
                    { 4, "/Images/img4.jpg", 2.50m, "Pre-Cracked Egg" },
                    { 5, "/Images/img5.jpg", 12m, "Shaq O'Neal's Pregnancy Test" },
                    { 6, "/Images/img6.jpg", 4.99m, "Defenetry-Not SNOOPY" },
                    { 7, "/Images/img7.jpg", 4.99m, "Weird Dogs" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "rrrrrrrr-22b1-4479-j58g-rrrrrrrr", "435dbe81-22b1-4479-bea2-d730a7750aa1" },
                    { "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr", "z65dbe81-22b1-4479-j58g-d730ap050aa1" }
                });

            migrationBuilder.InsertData(
                schema: "ord",
                table: "OrderPositions",
                columns: new[] { "OrderId", "OrderPositionId", "Amount", "Price", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 10, 12m, 1 },
                    { 1, 3, 10, 12m, 1 },
                    { 1, 5, 10, 12m, 1 },
                    { 1, 7, 10, 12m, 1 },
                    { 1, 9, 10, 12m, 1 },
                    { 1, 11, 10, 12m, 1 },
                    { 2, 2, 10, 12m, 2 },
                    { 2, 4, 10, 12m, 2 },
                    { 2, 6, 10, 12m, 2 },
                    { 2, 8, 10, 12m, 2 },
                    { 2, 10, 10, 12m, 2 }
                });

            migrationBuilder.InsertData(
                schema: "ord",
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5854), "z65dbe81-22b1-4479-j58g-d730ap050aa1" },
                    { 2, new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5911), "435dbe81-22b1-4479-bea2-d730a7750aa1" },
                    { 3, new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5914), "z65dbe81-22b1-4479-j58g-d730ap050aa1" },
                    { 4, new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5917), "z65dbe81-22b1-4479-j58g-d730ap050aa1" },
                    { 5, new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5920), "435dbe81-22b1-4479-bea2-d730a7750aa1" },
                    { 6, new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5922), "435dbe81-22b1-4479-bea2-d730a7750aa1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPositions_ProductId",
                schema: "ord",
                table: "OrderPositions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                schema: "ord",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductProperty_ProductsProductId",
                schema: "prod",
                table: "ProductProductProperty",
                column: "ProductsProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPositions",
                schema: "ord");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "ord");

            migrationBuilder.DropTable(
                name: "ProductProductProperty",
                schema: "prod");

            migrationBuilder.DropTable(
                name: "ProductProperties",
                schema: "prod");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "prod");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "rrrrrrrr-22b1-4479-j58g-rrrrrrrr", "435dbe81-22b1-4479-bea2-d730a7750aa1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr", "z65dbe81-22b1-4479-j58g-d730ap050aa1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rrrrrrrr-22b1-4479-j58g-rrrrrrrr");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435dbe81-22b1-4479-bea2-d730a7750aa1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "z65dbe81-22b1-4479-j58g-d730ap050aa1");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AspNetUsers");
        }
    }
}
