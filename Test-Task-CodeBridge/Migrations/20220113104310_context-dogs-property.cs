using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Task_CodeBridge.Migrations
{
    public partial class contextdogsproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dog",
                table: "Dog");

            migrationBuilder.DeleteData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: new Guid("8295254a-906d-4c62-9cd8-fa0376c0df19"));

            migrationBuilder.DeleteData(
                table: "Dog",
                keyColumn: "Id",
                keyValue: new Guid("a2924c0e-fc3f-4cc8-be62-b6487d04fa44"));

            migrationBuilder.RenameTable(
                name: "Dog",
                newName: "Dogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("56c154db-2d1f-495f-8768-c5eaa57d83e0"), "Red & amber", "Neo", 22.0, 32.0 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("67eeb7fa-e73c-40d9-b54a-71eca0f1a4df"), "black & white", "Jessy", 7.0, 14.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("56c154db-2d1f-495f-8768-c5eaa57d83e0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("67eeb7fa-e73c-40d9-b54a-71eca0f1a4df"));

            migrationBuilder.RenameTable(
                name: "Dogs",
                newName: "Dog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dog",
                table: "Dog",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Dog",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("a2924c0e-fc3f-4cc8-be62-b6487d04fa44"), "Red & amber", "Neo", 22.0, 32.0 });

            migrationBuilder.InsertData(
                table: "Dog",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("8295254a-906d-4c62-9cd8-fa0376c0df19"), "black & white", "Jessy", 7.0, 14.0 });
        }
    }
}
