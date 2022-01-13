using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Task_CodeBridge.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tail_Length = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dog", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Dog",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("a2924c0e-fc3f-4cc8-be62-b6487d04fa44"), "Red & amber", "Neo", 22.0, 32.0 });

            migrationBuilder.InsertData(
                table: "Dog",
                columns: new[] { "Id", "Color", "Name", "Tail_Length", "Weight" },
                values: new object[] { new Guid("8295254a-906d-4c62-9cd8-fa0376c0df19"), "black & white", "Jessy", 7.0, 14.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dog");
        }
    }
}
