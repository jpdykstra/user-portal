using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "UserId", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("882d359b-97d6-4e1f-8e38-26239734e132"), (short)76, "Jennifer", "Garcia" },
                    { new Guid("5dce7098-635a-4719-b155-4e95cbe7fe8c"), (short)20, "John", "Walker" },
                    { new Guid("daabab12-5c19-43fe-8be6-1cde9baaadcb"), (short)65, "Richard", "" },
                    { new Guid("ecc46080-4b48-404e-aecd-ad4a2a9da58f"), (short)68, "Patricia", "Garcia" },
                    { new Guid("65d024ef-1e91-4c26-93ec-d4e22a6b0c8c"), (short)75, "", "Johnson" },
                    { new Guid("98952330-d835-4867-b855-9471bfc134fc"), (short)79, "Richard", "Johnson" },
                    { new Guid("58a1c3ab-0a7f-49b6-8b02-62c6f2c081d1"), (short)35, "Elizabeth", "Collins" },
                    { new Guid("7ca6b6af-86b9-47c4-8110-e1ebe8de7bcd"), (short)77, "Jennifer", "Reed" },
                    { new Guid("c7898499-541e-4e17-b832-28658338a25e"), (short)26, "Michael", "Johnson" },
                    { new Guid("8928d192-6dae-42a8-bcf6-dd2a2f3acc6f"), (short)38, "Sara", "Walker" },
                    { new Guid("6be25e47-896b-4d21-823d-d755fec9056e"), (short)39, "Richard", "Watson" },
                    { new Guid("bdc1d503-00e7-42b5-bcec-2b93c023ed11"), (short)45, "Michael", "Anderson" },
                    { new Guid("965a59b6-ee6c-48cb-9897-72402bfab22a"), (short)46, "Martina", "Hall" },
                    { new Guid("86f35616-c8ab-4e93-a338-9539046d8361"), (short)81, "Elizabeth", "Clark" },
                    { new Guid("4fd8e3ea-c762-4a00-9f5a-8b4e0b9529e0"), (short)75, "Jessica", "Hall" },
                    { new Guid("a39cd005-878a-446e-b3d7-25f6ffc46437"), (short)72, "Juan", "Diaz" },
                    { new Guid("c3b2da91-e1b1-4e3a-8c48-fde7d09f39b0"), (short)59, "Elizabeth", "Collins" },
                    { new Guid("263e313b-e9f3-4afc-87d2-f008e6fda1f4"), (short)82, "Linda", "Reed" },
                    { new Guid("799aa134-1911-4fec-9c62-44bb14a7d9b6"), (short)23, "Martina", "Martin" },
                    { new Guid("e3032fcc-f08e-46f6-88dc-7d90c35033da"), (short)71, "Elizabeth", "Washington" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("263e313b-e9f3-4afc-87d2-f008e6fda1f4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4fd8e3ea-c762-4a00-9f5a-8b4e0b9529e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("58a1c3ab-0a7f-49b6-8b02-62c6f2c081d1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("5dce7098-635a-4719-b155-4e95cbe7fe8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("65d024ef-1e91-4c26-93ec-d4e22a6b0c8c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("6be25e47-896b-4d21-823d-d755fec9056e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("799aa134-1911-4fec-9c62-44bb14a7d9b6"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("7ca6b6af-86b9-47c4-8110-e1ebe8de7bcd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("86f35616-c8ab-4e93-a338-9539046d8361"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("882d359b-97d6-4e1f-8e38-26239734e132"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("8928d192-6dae-42a8-bcf6-dd2a2f3acc6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("965a59b6-ee6c-48cb-9897-72402bfab22a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("98952330-d835-4867-b855-9471bfc134fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("a39cd005-878a-446e-b3d7-25f6ffc46437"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("bdc1d503-00e7-42b5-bcec-2b93c023ed11"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("c3b2da91-e1b1-4e3a-8c48-fde7d09f39b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("c7898499-541e-4e17-b832-28658338a25e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("daabab12-5c19-43fe-8be6-1cde9baaadcb"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("e3032fcc-f08e-46f6-88dc-7d90c35033da"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("ecc46080-4b48-404e-aecd-ad4a2a9da58f"));

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
        }
    }
}
