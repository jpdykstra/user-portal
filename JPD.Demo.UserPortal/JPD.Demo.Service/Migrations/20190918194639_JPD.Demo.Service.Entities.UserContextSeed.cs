using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceEntitiesUserContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Interest",
                columns: new[] { "InterestId", "Description", "Name", "UserId" },
                values: new object[] { new Guid("328f86ca-07e2-475f-a730-a5ae18690034"), "Going for long walks in the country or woods.", "Hiking", null });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Interest",
                columns: new[] { "InterestId", "Description", "Name", "UserId" },
                values: new object[] { new Guid("3e7dc337-81d6-4c06-88c5-f15a9302f6f6"), "Traveling over the snow on skis.", "Skiing", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("328f86ca-07e2-475f-a730-a5ae18690034"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("3e7dc337-81d6-4c06-88c5-f15a9302f6f6"));
        }
    }
}
