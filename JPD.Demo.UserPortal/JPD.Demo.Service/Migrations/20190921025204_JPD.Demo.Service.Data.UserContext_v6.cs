using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("92618f3f-2e86-4135-b3ed-0b2747f1f11f"), (short)36, "Richard", "Bennett" },
                    { new Guid("94dcfc93-9560-4a63-b3c7-9f5e9b821229"), (short)47, "Martina", "Johnson" },
                    { new Guid("5bafc8c4-7526-4de2-a07f-f29210241b6a"), (short)24, "Sara", "Lee" },
                    { new Guid("3eee7d5a-10ab-4250-845d-5b5ccaf14414"), (short)34, "Catalina", "Washington" },
                    { new Guid("d1869d29-594f-4540-aded-5e096e4047b7"), (short)23, "Martina", "Rivera" },
                    { new Guid("3d0b2c13-5a68-4713-b49c-b7d9bde10cae"), (short)33, "Charles", "Reed" },
                    { new Guid("e346bd8e-c0f8-4202-a54d-1280ed8f723e"), (short)73, "Juan", "Hall" },
                    { new Guid("41e8b279-5993-41f7-a680-4a0aa6dab817"), (short)62, "Juan", "Collins" },
                    { new Guid("170b3b2a-4bf2-4fcb-8b54-e71f3b46ea20"), (short)48, "Patricia", "Martin" },
                    { new Guid("e2103de2-8ed8-43da-97d2-c35fdea1b861"), (short)71, "Pedro", "Johnson" },
                    { new Guid("3d569047-2e36-437b-8aad-5b15bcacf3fc"), (short)44, "William", "Reed" },
                    { new Guid("8e7deef3-f714-42e5-a58b-9387040b3da1"), (short)38, "Charles", "" },
                    { new Guid("243110f7-e75a-414f-8d92-bbe9fdb16b59"), (short)76, "Jennifer", "Collins" },
                    { new Guid("a6c737f0-fb14-43aa-b8c5-cce4ce2c389a"), (short)37, "Linda", "" },
                    { new Guid("8ba1e42c-c8a1-4e34-8efd-6e653c27a785"), (short)81, "Thomas", "Hayes" },
                    { new Guid("2990acb1-9b4f-46e6-a704-c0366c92ee6f"), (short)73, "Jessica", "Clark" },
                    { new Guid("fa8349d1-c01d-4987-b65c-927aa28b8ec0"), (short)43, "John", "" },
                    { new Guid("afc3a292-5c80-416f-80f6-15b2dca39d6f"), (short)81, "Charles", "Clark" },
                    { new Guid("6e05253a-3a54-4c03-8768-1f9b291d3f42"), (short)32, "Joseph", "Diaz" },
                    { new Guid("8399dbaa-8d75-4be8-9fe7-7c4505b96ebd"), (short)65, "Evan", "Watson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("170b3b2a-4bf2-4fcb-8b54-e71f3b46ea20"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("243110f7-e75a-414f-8d92-bbe9fdb16b59"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("2990acb1-9b4f-46e6-a704-c0366c92ee6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("3d0b2c13-5a68-4713-b49c-b7d9bde10cae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("3d569047-2e36-437b-8aad-5b15bcacf3fc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("3eee7d5a-10ab-4250-845d-5b5ccaf14414"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("41e8b279-5993-41f7-a680-4a0aa6dab817"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("5bafc8c4-7526-4de2-a07f-f29210241b6a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("6e05253a-3a54-4c03-8768-1f9b291d3f42"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("8399dbaa-8d75-4be8-9fe7-7c4505b96ebd"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("8ba1e42c-c8a1-4e34-8efd-6e653c27a785"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("8e7deef3-f714-42e5-a58b-9387040b3da1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("92618f3f-2e86-4135-b3ed-0b2747f1f11f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("94dcfc93-9560-4a63-b3c7-9f5e9b821229"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("a6c737f0-fb14-43aa-b8c5-cce4ce2c389a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("afc3a292-5c80-416f-80f6-15b2dca39d6f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("d1869d29-594f-4540-aded-5e096e4047b7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("e2103de2-8ed8-43da-97d2-c35fdea1b861"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("e346bd8e-c0f8-4202-a54d-1280ed8f723e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("fa8349d1-c01d-4987-b65c-927aa28b8ec0"));

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
    }
}
