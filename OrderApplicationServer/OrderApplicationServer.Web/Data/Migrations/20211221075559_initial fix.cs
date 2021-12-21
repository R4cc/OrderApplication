using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderApplicationServer.Web.Data.Migrations
{
    public partial class initialfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "prod",
                table: "ProductProperties",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                schema: "prod",
                table: "ProductProperties",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rrrrrrrr-22b1-4479-j58g-rrrrrrrr",
                column: "ConcurrencyStamp",
                value: "6310e53a-a361-4bd5-bde6-f754c8914212");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr",
                column: "ConcurrencyStamp",
                value: "a4ee91d3-803e-422c-8f2f-a0bf456a70ff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435dbe81-22b1-4479-bea2-d730a7750aa1",
                columns: new[] { "ConcurrencyStamp", "Created", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c14f0af2-1f7b-4aee-9ef3-5d99f1fdf7d7", new DateTime(2021, 12, 21, 8, 55, 59, 240, DateTimeKind.Local).AddTicks(3043), "AQAAAAEAACcQAAAAEJ4sp6NMhb5cvWJ3Ib51GUMZl8Ax8Ox6vN6jn/KB0MwtvC5juBMJloJK3KNDNVWUCA==", "30cf95a9-e470-450f-9265-ba5569b66a98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "z65dbe81-22b1-4479-j58g-d730ap050aa1",
                columns: new[] { "ConcurrencyStamp", "Created", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bb6f4cc-8946-4082-a271-02f9bab27f98", new DateTime(2021, 12, 21, 8, 55, 59, 240, DateTimeKind.Local).AddTicks(3092), "AQAAAAEAACcQAAAAEH57Qfe2VuCBGGGTcpsPkykq3aCAYWFVeeJPIMScswgyeHFXxFT+OVLXtmBoxx0JQg==", "70f9975a-7c45-44ca-8606-60ee0bae71b4" });

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 12, 21, 8, 55, 59, 255, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2021, 12, 21, 8, 55, 59, 255, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2021, 12, 21, 8, 55, 59, 255, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2021, 12, 21, 8, 55, 59, 255, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2021, 12, 21, 8, 55, 59, 255, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2021, 12, 21, 8, 55, 59, 255, DateTimeKind.Local).AddTicks(3635));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "prod",
                table: "ProductProperties",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                schema: "prod",
                table: "ProductProperties",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rrrrrrrr-22b1-4479-j58g-rrrrrrrr",
                column: "ConcurrencyStamp",
                value: "03680d48-eae8-4e57-a44f-debde61e331f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "rrrrrrrr-l0w6-hhhh-jf84-rrrrrrrr",
                column: "ConcurrencyStamp",
                value: "51290a00-75c5-4f92-b3b3-92287205be54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435dbe81-22b1-4479-bea2-d730a7750aa1",
                columns: new[] { "ConcurrencyStamp", "Created", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8160ba0e-a346-43aa-8810-2ad9da93a4af", new DateTime(2021, 12, 20, 10, 4, 11, 609, DateTimeKind.Local).AddTicks(7890), "AQAAAAEAACcQAAAAEAm/R8BcByNqwzTp33CaVCcP1hZ5bxV2EJcuZxisZjADJUkHlF5u/toUsTvQwgMA4g==", "d04ee2db-7e93-430e-a7a5-e9c9a3f53e5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "z65dbe81-22b1-4479-j58g-d730ap050aa1",
                columns: new[] { "ConcurrencyStamp", "Created", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62699e39-c253-4548-b6a7-3cf608e595a6", new DateTime(2021, 12, 20, 10, 4, 11, 609, DateTimeKind.Local).AddTicks(7949), "AQAAAAEAACcQAAAAEArZjn8t2hPQ8soAO3h/fxvMStTLjMuFbhr45vmGGU+Bj+VcqwD9gxJiekup4th1fQ==", "f065ed62-ff97-4ef6-a49f-e16e587c63c4" });

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                schema: "ord",
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2021, 12, 20, 10, 4, 11, 628, DateTimeKind.Local).AddTicks(5922));
        }
    }
}
