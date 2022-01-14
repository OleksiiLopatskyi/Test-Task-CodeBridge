using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Task_CodeBridge.Migrations
{
    public partial class renamedogtailheightproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("56c154db-2d1f-495f-8768-c5eaa57d83e0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("67eeb7fa-e73c-40d9-b54a-71eca0f1a4df"));

            migrationBuilder.RenameColumn(
                name: "Tail_Length",
                table: "Dogs",
                newName: "Tail_Height");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Color", "Name", "Tail_Height", "Weight" },
                values: new object[] { new Guid("3d0f6d45-b5b1-4813-b9c9-a61be6193c5b"), "Red & amber", "Neo", 22.0, 32.0 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Color", "Name", "Tail_Height", "Weight" },
                values: new object[] { new Guid("c89cac13-821d-44c2-a429-ac14d72c91aa"), "black & white", "Jessy", 7.0, 14.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("3d0f6d45-b5b1-4813-b9c9-a61be6193c5b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c89cac13-821d-44c2-a429-ac14d72c91aa"));

            migrationBuilder.RenameColumn(
                name: "Tail_Height",
                table: "Dogs",
                newName: "Tail_Length");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("56c154db-2d1f-495f-8768-c5eaa57d83e0"), "Red & amber", "Neo", 22.0, 32.0 });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("67eeb7fa-e73c-40d9-b54a-71eca0f1a4df"), "black & white", "Jessy", 7.0, 14.0 });
        }
    }
}
