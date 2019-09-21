using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "UserId", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("f59d81fb-92ec-4439-8b9e-71a9a755a3e4"), (short)54, "John", "Bennett" },
                    { new Guid("629b1824-1159-45aa-bdfd-f7afa1a3b16c"), (short)41, "Charles", "" },
                    { new Guid("0b29cee9-53d6-4799-b277-6fffad7b933e"), (short)73, "Mary", "Rivera" },
                    { new Guid("4d759f7a-7f53-454a-bf43-baf419aef94e"), (short)43, "William", "Martin" },
                    { new Guid("a15b4190-a27b-4e0e-9973-385d9320ae95"), (short)32, "Jennifer", "Anderson" },
                    { new Guid("e49521a7-32c2-44fe-9749-1ad418a1ec80"), (short)40, "Juan", "Lee" },
                    { new Guid("17edbab4-ae5a-45a3-aae2-b296802fd065"), (short)24, "Evan", "Anderson" },
                    { new Guid("961c78ab-f929-468d-8832-1c980888f1a1"), (short)67, "Thomas", "Garcia" },
                    { new Guid("1b51fee5-0a96-468b-ab38-f4f9e54b50b3"), (short)28, "Barbara", "Hall" },
                    { new Guid("af1c9989-4d63-4b1e-b004-3594c8b35369"), (short)19, "William", "Reed" },
                    { new Guid("3a3d2c28-cac1-46b2-8e35-4af209f47fca"), (short)71, "Barbara", "Lee" },
                    { new Guid("ecae1480-5d08-4d30-a697-94669be44e53"), (short)41, "William", "Collins" },
                    { new Guid("36b233ca-220e-4ca0-9d14-990bb2d09d29"), (short)63, "Jennifer", "Lee" },
                    { new Guid("9a393e36-7ffb-4b2d-9d6a-29c32f2dee60"), (short)54, "William", "Anderson" },
                    { new Guid("cd3de9f6-f465-4738-92d7-a89ed8514d25"), (short)34, "Pedro", "Roberts" },
                    { new Guid("bd3b3826-e476-4725-a8e6-1c379d939c81"), (short)34, "Evan", "Rivera" },
                    { new Guid("c76c83a1-b9a5-46a5-9c23-5b6b15b57874"), (short)31, "Sara", "Hayes" },
                    { new Guid("32f51d22-170f-45a3-b5cb-7991c6fbd5cd"), (short)79, "Charles", "Diaz" },
                    { new Guid("4f09315a-b0b6-474f-8094-f32b688e1c3f"), (short)41, "John", "Hayes" },
                    { new Guid("b35fc2eb-d202-4b3a-8cb2-39677a651bd3"), (short)27, "Patricia", "Rivera" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("0b29cee9-53d6-4799-b277-6fffad7b933e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("17edbab4-ae5a-45a3-aae2-b296802fd065"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("1b51fee5-0a96-468b-ab38-f4f9e54b50b3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("32f51d22-170f-45a3-b5cb-7991c6fbd5cd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("36b233ca-220e-4ca0-9d14-990bb2d09d29"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("3a3d2c28-cac1-46b2-8e35-4af209f47fca"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4d759f7a-7f53-454a-bf43-baf419aef94e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4f09315a-b0b6-474f-8094-f32b688e1c3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("629b1824-1159-45aa-bdfd-f7afa1a3b16c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("961c78ab-f929-468d-8832-1c980888f1a1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("9a393e36-7ffb-4b2d-9d6a-29c32f2dee60"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("a15b4190-a27b-4e0e-9973-385d9320ae95"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("af1c9989-4d63-4b1e-b004-3594c8b35369"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("b35fc2eb-d202-4b3a-8cb2-39677a651bd3"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("bd3b3826-e476-4725-a8e6-1c379d939c81"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("c76c83a1-b9a5-46a5-9c23-5b6b15b57874"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("cd3de9f6-f465-4738-92d7-a89ed8514d25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("e49521a7-32c2-44fe-9749-1ad418a1ec80"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("ecae1480-5d08-4d30-a697-94669be44e53"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("f59d81fb-92ec-4439-8b9e-71a9a755a3e4"));
        }
    }
}
