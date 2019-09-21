using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interest_User_UserId",
                schema: "dbo",
                table: "Interest");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "dbo",
                table: "Interest",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "UserId", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("52546bc8-c85e-4bf1-b573-b00b6ecbeca2"), (short)78, "Evan", "Watson" },
                    { new Guid("d1c6c8f5-fbdf-41b3-a00e-333147487783"), (short)71, "John", "Anderson" },
                    { new Guid("46f0a694-26e0-40aa-a545-12c0d978ce9c"), (short)69, "Jennifer", "Reed" },
                    { new Guid("dee91e49-bd8e-483e-a696-f7fa85e2d12d"), (short)62, "Martina", "Bailey" },
                    { new Guid("58416c95-7231-41f4-977d-092d82eddd50"), (short)27, "Mary", "Collins" },
                    { new Guid("bcd9c6a5-4d72-4b74-91ad-1278fbe7537f"), (short)78, "Jessica", "Anderson" },
                    { new Guid("71e15640-74e2-4227-b47f-bfd28a7f7f57"), (short)63, "Pedro", "Watson" },
                    { new Guid("9330c9c8-f638-400f-9363-700bb16e613c"), (short)29, "Jennifer", "Anderson" },
                    { new Guid("4fce29f6-21c5-4f07-85f4-113181c01a5a"), (short)70, "Evan", "Lee" },
                    { new Guid("adcd15fd-005b-4693-a90c-c9d12bf7e1ad"), (short)79, "Michael", "Bennett" },
                    { new Guid("9ca06030-5753-4c14-9126-de46cf394a04"), (short)56, "William", "Reed" },
                    { new Guid("97cd9267-9dba-4f0f-bb5e-68bcc4a84a64"), (short)46, "John", "Johnson" },
                    { new Guid("c66eb1eb-6196-46d1-8e9f-d9350d39f1b8"), (short)68, "Richard", "Watson" },
                    { new Guid("ad90f13e-31d0-4dab-8ed1-25b55f455acd"), (short)49, "Sara", "Powell" },
                    { new Guid("4b8b5f47-1640-4db1-954f-9c4c6e764d8f"), (short)38, "Richard", "" },
                    { new Guid("c2e80493-6eea-4e86-a45c-34ee91349da9"), (short)51, "Evan", "Roberts" },
                    { new Guid("4153b8df-5783-4b29-89bd-2bae75427d19"), (short)32, "Michael", "Collins" },
                    { new Guid("330df43a-229c-47ee-a407-99ec1cdb096e"), (short)74, "Pedro", "Walker" },
                    { new Guid("57f75d45-7afa-485a-8996-8a0d9831736d"), (short)45, "Jennifer", "Roberts" },
                    { new Guid("9e802fb0-b3db-4282-91bd-22600d42f311"), (short)43, "Elizabeth", "Collins" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_User_UserId",
                schema: "dbo",
                table: "Interest",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interest_User_UserId",
                schema: "dbo",
                table: "Interest");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("330df43a-229c-47ee-a407-99ec1cdb096e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4153b8df-5783-4b29-89bd-2bae75427d19"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("46f0a694-26e0-40aa-a545-12c0d978ce9c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4b8b5f47-1640-4db1-954f-9c4c6e764d8f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4fce29f6-21c5-4f07-85f4-113181c01a5a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("52546bc8-c85e-4bf1-b573-b00b6ecbeca2"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("57f75d45-7afa-485a-8996-8a0d9831736d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("58416c95-7231-41f4-977d-092d82eddd50"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("71e15640-74e2-4227-b47f-bfd28a7f7f57"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("9330c9c8-f638-400f-9363-700bb16e613c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("97cd9267-9dba-4f0f-bb5e-68bcc4a84a64"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("9ca06030-5753-4c14-9126-de46cf394a04"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("9e802fb0-b3db-4282-91bd-22600d42f311"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("ad90f13e-31d0-4dab-8ed1-25b55f455acd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("adcd15fd-005b-4693-a90c-c9d12bf7e1ad"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("bcd9c6a5-4d72-4b74-91ad-1278fbe7537f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("c2e80493-6eea-4e86-a45c-34ee91349da9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("c66eb1eb-6196-46d1-8e9f-d9350d39f1b8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("d1c6c8f5-fbdf-41b3-a00e-333147487783"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("dee91e49-bd8e-483e-a696-f7fa85e2d12d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "dbo",
                table: "Interest",
                nullable: true,
                oldClrType: typeof(Guid));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_User_UserId",
                schema: "dbo",
                table: "Interest",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
