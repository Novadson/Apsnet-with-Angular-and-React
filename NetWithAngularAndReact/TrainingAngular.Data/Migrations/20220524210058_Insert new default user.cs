using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingAngular.Data.Migrations
{
    public partial class Insertnewdefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "user_id", "user_email", "user_name" },
                values: new object[] { new Guid("fa2a200a-4ad4-4b20-a568-46d50b137fc8"), "novadsonthelus@gmail.com", "Novadson Thelus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "user_id",
                keyValue: new Guid("fa2a200a-4ad4-4b20-a568-46d50b137fc8"));
        }
    }
}
