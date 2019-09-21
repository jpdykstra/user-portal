using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("286b979d-cff1-46de-a2ab-bba38ec8b675"), (short)69, "Charles", "Powell" },
                    { new Guid("8d8ad1f6-42c9-4b7d-938d-38147ccbe8e0"), (short)28, "Thomas", "Diaz" },
                    { new Guid("82a77a7b-eb63-4d87-aa9c-7ea637973823"), (short)27, "John", "Collins" },
                    { new Guid("34ef965e-8339-4c53-86b1-1d3d9f428de4"), (short)84, "John", "Hayes" },
                    { new Guid("772c4277-8c6e-4c06-ae8e-1d06753c70c9"), (short)27, "Jessica", "Hall" },
                    { new Guid("4b2358e1-8293-4789-9113-0c01d30a8820"), (short)33, "Jennifer", "Walker" },
                    { new Guid("708e98ab-5375-4013-8d25-fd7fc0c87eea"), (short)37, "Evan", "Lee" },
                    { new Guid("f09707a4-83f8-4f16-8147-e9a6e8b819f9"), (short)76, "Martina", "Bennett" },
                    { new Guid("fe499d5f-6958-490e-a17f-ca9783e11d68"), (short)81, "Linda", "Walker" },
                    { new Guid("c8c10d8d-a3e2-47cc-930d-5fa6f7e9490a"), (short)75, "Juan", "Clark" },
                    { new Guid("1016b697-b91c-48b8-a3d7-614a633a7f0c"), (short)44, "Sara", "Garcia" },
                    { new Guid("6f95f72d-e4e1-4b44-835b-a0ad34dfb57b"), (short)55, "William", "Clark" },
                    { new Guid("150547b9-edf6-4811-afd2-66dae55eb279"), (short)42, "Richard", "Rivera" },
                    { new Guid("a97614fc-48cd-4343-901c-dc9c9ed38b6d"), (short)48, "Mary", "Garcia" },
                    { new Guid("420bdd5e-b7cc-449a-85cd-379a84625c8d"), (short)39, "Michael", "Lee" },
                    { new Guid("38820f66-b59a-4b5e-875a-45c0ade7a513"), (short)77, "John", "Johnson" },
                    { new Guid("2c29d6af-4baf-4160-9a2f-77f7c3f133c8"), (short)73, "Catalina", "" },
                    { new Guid("eac5a25b-a9e1-4857-a005-812ca35a53e8"), (short)62, "Barbara", "Diaz" },
                    { new Guid("300adbce-d6ed-4414-ae27-bdab4386f37c"), (short)42, "", "Watson" },
                    { new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45"), (short)30, "Pedro", "Hayes" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Interest",
                columns: new[] { "InterestId", "Description", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("3e4e8199-9126-4bb1-afa8-593ee05e1b35"), "Reading is my favorite thing to do.", "Reading", new Guid("286b979d-cff1-46de-a2ab-bba38ec8b675") },
                    { new Guid("823ce0e0-e75c-4b8a-b72e-99fb0ee12630"), "I wish I was better at Painting.", "Painting", new Guid("fe499d5f-6958-490e-a17f-ca9783e11d68") },
                    { new Guid("239c6732-809f-42b3-84eb-4c0dbfff165b"), "I enjoy Singing Out Loud.", "Singing Out Loud", new Guid("fe499d5f-6958-490e-a17f-ca9783e11d68") },
                    { new Guid("53a577f3-0d83-46c7-b07d-5e1a234806ba"), "I wish I was better at Music.", "Music", new Guid("f09707a4-83f8-4f16-8147-e9a6e8b819f9") },
                    { new Guid("3937fbe8-6dae-40d6-a49d-2ebcd60950be"), "Theater, nuff said.", "Theater", new Guid("f09707a4-83f8-4f16-8147-e9a6e8b819f9") },
                    { new Guid("2f279356-c396-468b-b0ad-49c04df83211"), "I wish I could do more Space Exploration.", "Space Exploration", new Guid("f09707a4-83f8-4f16-8147-e9a6e8b819f9") },
                    { new Guid("508d1f50-dddb-4cd4-84d0-bcb1e6778d45"), "I wish I was better at Singing Out Loud.", "Singing Out Loud", new Guid("708e98ab-5375-4013-8d25-fd7fc0c87eea") },
                    { new Guid("f90f2466-b107-4821-b6e7-e9911d50dd3f"), "Painting, nuff said.", "Painting", new Guid("708e98ab-5375-4013-8d25-fd7fc0c87eea") },
                    { new Guid("08dabf3b-2b3b-401e-9d1d-e88c924fd9ec"), "I enjoy Caligraphy.", "Caligraphy", new Guid("708e98ab-5375-4013-8d25-fd7fc0c87eea") },
                    { new Guid("a953da57-b0ef-492e-9ce2-04987da51db5"), "Mountain Climbing, nuff said.", "Mountain Climbing", new Guid("4b2358e1-8293-4789-9113-0c01d30a8820") },
                    { new Guid("18e64788-5432-4702-8da3-d247ecbbaa18"), "I not a big fan of Traveling.", "Traveling", new Guid("772c4277-8c6e-4c06-ae8e-1d06753c70c9") },
                    { new Guid("c476cb0c-b1c3-461a-b2db-277bf5b8ebc0"), "Traveling is my favorite thing to do.", "Traveling", new Guid("34ef965e-8339-4c53-86b1-1d3d9f428de4") },
                    { new Guid("acc4217a-9515-4432-8d6c-7e3605de8a3a"), "I enjoy Singing Out Loud.", "Singing Out Loud", new Guid("34ef965e-8339-4c53-86b1-1d3d9f428de4") },
                    { new Guid("70cf9a32-5934-4f6b-ad52-176f78fb4f2a"), "Singing Out Loud is the best.", "Singing Out Loud", new Guid("34ef965e-8339-4c53-86b1-1d3d9f428de4") },
                    { new Guid("ef9ff377-2799-43b2-ace2-1a5978beb533"), "I wish I was better at Traveling.", "Traveling", new Guid("82a77a7b-eb63-4d87-aa9c-7ea637973823") },
                    { new Guid("2f5a7bd8-6b0e-413c-ab93-607661ab180f"), "I enjoy Skiing.", "Skiing", new Guid("82a77a7b-eb63-4d87-aa9c-7ea637973823") },
                    { new Guid("99f9eda0-56de-4cf7-ba2c-892e5333587f"), "I enjoy Mountain Climbing.", "Mountain Climbing", new Guid("82a77a7b-eb63-4d87-aa9c-7ea637973823") },
                    { new Guid("2ec386cb-9aec-4e3a-acc5-63d30c477f3c"), "I wish I could do more .", "", new Guid("8d8ad1f6-42c9-4b7d-938d-38147ccbe8e0") },
                    { new Guid("6897bb14-45ae-46f5-bfbf-85f2ff2f2e88"), "I not a big fan of Skiing.", "Skiing", new Guid("300adbce-d6ed-4414-ae27-bdab4386f37c") },
                    { new Guid("0ceacdb8-281b-4696-9f97-26da3c5f68cf"), "Bicycling is the best.", "Bicycling", new Guid("300adbce-d6ed-4414-ae27-bdab4386f37c") },
                    { new Guid("3f7e7185-fdce-4f92-a3be-b95103384e58"), "Fishing is my favorite thing to do.", "Fishing", new Guid("300adbce-d6ed-4414-ae27-bdab4386f37c") },
                    { new Guid("c75b9c94-db9d-433a-906e-6a5de542a4c7"), "Painting, nuff said.", "Painting", new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45") },
                    { new Guid("253edbc5-6352-46cb-a61c-c521998c43d8"), "I not a big fan of Mountain Climbing.", "Mountain Climbing", new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45") },
                    { new Guid("71049110-490f-45c1-a534-1eb31e7b42d0"), "I wish I could do more Skiing.", "Skiing", new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45") },
                    { new Guid("13729409-0eba-41aa-89ef-ef2a23f02a62"), " is my favorite thing to do.", "", new Guid("fe499d5f-6958-490e-a17f-ca9783e11d68") },
                    { new Guid("cf2204fd-11df-48c1-80e6-2b4d2b9e760d"), "I wish I could do more Mountain Climbing.", "Mountain Climbing", new Guid("fe499d5f-6958-490e-a17f-ca9783e11d68") },
                    { new Guid("73df6f40-7f9c-4c3c-913c-51689dc6d018"), "Traveling is my favorite thing to do.", "Traveling", new Guid("c8c10d8d-a3e2-47cc-930d-5fa6f7e9490a") },
                    { new Guid("6e9ef1aa-6989-42e3-879e-6631eab741b0"), "I wish I was better at Traveling.", "Traveling", new Guid("c8c10d8d-a3e2-47cc-930d-5fa6f7e9490a") },
                    { new Guid("2dc91b02-3b18-4004-bd9b-9c18d8660fbe"), "Singing Out Loud, nuff said.", "Singing Out Loud", new Guid("286b979d-cff1-46de-a2ab-bba38ec8b675") },
                    { new Guid("03f33dac-62ca-4103-9798-494f77b3da2c"), "Mountain Climbing is the best.", "Mountain Climbing", new Guid("eac5a25b-a9e1-4857-a005-812ca35a53e8") },
                    { new Guid("3da2ce42-8e89-4be3-98d7-cf3beb34181b"), "I wish I was better at Dancing.", "Dancing", new Guid("eac5a25b-a9e1-4857-a005-812ca35a53e8") },
                    { new Guid("e530548b-b40b-471f-ac9c-97a676cb08c0"), "I enjoy Skiing.", "Skiing", new Guid("eac5a25b-a9e1-4857-a005-812ca35a53e8") },
                    { new Guid("a413e081-9d3e-469e-aff0-7fbdd5b30e52"), "Painting is the best.", "Painting", new Guid("2c29d6af-4baf-4160-9a2f-77f7c3f133c8") },
                    { new Guid("3540bd9c-7b6e-4744-bb2d-e20491c62580"), "Gardening, nuff said.", "Gardening", new Guid("38820f66-b59a-4b5e-875a-45c0ade7a513") },
                    { new Guid("641442fe-68af-4abc-8d3d-f72663b8c214"), "Music, nuff said.", "Music", new Guid("420bdd5e-b7cc-449a-85cd-379a84625c8d") },
                    { new Guid("78426650-383e-4338-ba97-25c969900289"), "I wish I could do more Reading.", "Reading", new Guid("420bdd5e-b7cc-449a-85cd-379a84625c8d") },
                    { new Guid("19424d44-442b-4aa8-b53a-3bb7ab4c2e7c"), "Golf, nuff said.", "Golf", new Guid("420bdd5e-b7cc-449a-85cd-379a84625c8d") },
                    { new Guid("40d035b8-1e6b-4ff4-9924-a45169910c2c"), "Mountain Climbing, nuff said.", "Mountain Climbing", new Guid("a97614fc-48cd-4343-901c-dc9c9ed38b6d") },
                    { new Guid("701423a1-367e-41fa-bc82-e5678357dcdc"), "Hiking, nuff said.", "Hiking", new Guid("a97614fc-48cd-4343-901c-dc9c9ed38b6d") },
                    { new Guid("85eacfc1-af1f-44c7-95ba-23e55a973197"), "I wish I could do more Traveling.", "Traveling", new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45") },
                    { new Guid("dc9ad9cb-2543-4d3d-a223-71a7be8c3887"), "Tennis, nuff said.", "Tennis", new Guid("a97614fc-48cd-4343-901c-dc9c9ed38b6d") },
                    { new Guid("0f6da3a9-2f08-42b8-a1ee-36a2f16c98c8"), "I not a big fan of Fishing.", "Fishing", new Guid("150547b9-edf6-4811-afd2-66dae55eb279") },
                    { new Guid("804fb163-0d6f-4b37-b81b-a1304b609ec0"), "I wish I could do more Space Exploration.", "Space Exploration", new Guid("150547b9-edf6-4811-afd2-66dae55eb279") },
                    { new Guid("68c4c14e-db41-4ef4-9c75-6b8ee55b2177"), "I not a big fan of Gardening.", "Gardening", new Guid("150547b9-edf6-4811-afd2-66dae55eb279") },
                    { new Guid("114df06e-7aff-431c-b9ba-52a4ef5c8a07"), " is the best.", "", new Guid("150547b9-edf6-4811-afd2-66dae55eb279") },
                    { new Guid("67905a06-6cfe-4f12-b93d-a35fb4d8dd4a"), "I not a big fan of Space Exploration.", "Space Exploration", new Guid("6f95f72d-e4e1-4b44-835b-a0ad34dfb57b") },
                    { new Guid("5e1dbedb-341d-4ac4-adc4-865535e0a671"), "I wish I could do more Hiking.", "Hiking", new Guid("6f95f72d-e4e1-4b44-835b-a0ad34dfb57b") },
                    { new Guid("09694575-3f67-40f5-be7f-fd46a3f41c25"), "Sofware Engineering Rocks!", "Sofware Engineering", new Guid("6f95f72d-e4e1-4b44-835b-a0ad34dfb57b") },
                    { new Guid("b9f7a556-52a7-4112-9872-f0091b23a9e0"), "Caligraphy, nuff said.", "Caligraphy", new Guid("6f95f72d-e4e1-4b44-835b-a0ad34dfb57b") },
                    { new Guid("2a941004-01a2-405d-bd3c-146640a5d915"), "I enjoy Space Exploration.", "Space Exploration", new Guid("1016b697-b91c-48b8-a3d7-614a633a7f0c") },
                    { new Guid("641214db-78a1-4f71-af2c-37ff16314bae"), "Painting, nuff said.", "Painting", new Guid("1016b697-b91c-48b8-a3d7-614a633a7f0c") },
                    { new Guid("6a6fe07f-e672-4033-951c-144283ed40ab"), "I enjoy .", "", new Guid("1016b697-b91c-48b8-a3d7-614a633a7f0c") },
                    { new Guid("96e1841a-31a0-4080-bdeb-88ffd52cbfaa"), "Skiing is my favorite thing to do.", "Skiing", new Guid("150547b9-edf6-4811-afd2-66dae55eb279") },
                    { new Guid("4b8c32e7-0872-4a9a-ad28-295cfb830e6d"), "I wish I could do more Music.", "Music", new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("03f33dac-62ca-4103-9798-494f77b3da2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("08dabf3b-2b3b-401e-9d1d-e88c924fd9ec"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("09694575-3f67-40f5-be7f-fd46a3f41c25"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("0ceacdb8-281b-4696-9f97-26da3c5f68cf"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("0f6da3a9-2f08-42b8-a1ee-36a2f16c98c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("114df06e-7aff-431c-b9ba-52a4ef5c8a07"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("13729409-0eba-41aa-89ef-ef2a23f02a62"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("18e64788-5432-4702-8da3-d247ecbbaa18"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("19424d44-442b-4aa8-b53a-3bb7ab4c2e7c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("239c6732-809f-42b3-84eb-4c0dbfff165b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("253edbc5-6352-46cb-a61c-c521998c43d8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("2a941004-01a2-405d-bd3c-146640a5d915"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("2dc91b02-3b18-4004-bd9b-9c18d8660fbe"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("2ec386cb-9aec-4e3a-acc5-63d30c477f3c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("2f279356-c396-468b-b0ad-49c04df83211"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("2f5a7bd8-6b0e-413c-ab93-607661ab180f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("3540bd9c-7b6e-4744-bb2d-e20491c62580"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("3937fbe8-6dae-40d6-a49d-2ebcd60950be"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("3da2ce42-8e89-4be3-98d7-cf3beb34181b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("3e4e8199-9126-4bb1-afa8-593ee05e1b35"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("3f7e7185-fdce-4f92-a3be-b95103384e58"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("40d035b8-1e6b-4ff4-9924-a45169910c2c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("4b8c32e7-0872-4a9a-ad28-295cfb830e6d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("508d1f50-dddb-4cd4-84d0-bcb1e6778d45"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("53a577f3-0d83-46c7-b07d-5e1a234806ba"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("5e1dbedb-341d-4ac4-adc4-865535e0a671"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("641214db-78a1-4f71-af2c-37ff16314bae"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("641442fe-68af-4abc-8d3d-f72663b8c214"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("67905a06-6cfe-4f12-b93d-a35fb4d8dd4a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("6897bb14-45ae-46f5-bfbf-85f2ff2f2e88"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("68c4c14e-db41-4ef4-9c75-6b8ee55b2177"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("6a6fe07f-e672-4033-951c-144283ed40ab"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("6e9ef1aa-6989-42e3-879e-6631eab741b0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("701423a1-367e-41fa-bc82-e5678357dcdc"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("70cf9a32-5934-4f6b-ad52-176f78fb4f2a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("71049110-490f-45c1-a534-1eb31e7b42d0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("73df6f40-7f9c-4c3c-913c-51689dc6d018"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("78426650-383e-4338-ba97-25c969900289"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("804fb163-0d6f-4b37-b81b-a1304b609ec0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("823ce0e0-e75c-4b8a-b72e-99fb0ee12630"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("85eacfc1-af1f-44c7-95ba-23e55a973197"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("96e1841a-31a0-4080-bdeb-88ffd52cbfaa"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("99f9eda0-56de-4cf7-ba2c-892e5333587f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("a413e081-9d3e-469e-aff0-7fbdd5b30e52"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("a953da57-b0ef-492e-9ce2-04987da51db5"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("acc4217a-9515-4432-8d6c-7e3605de8a3a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("b9f7a556-52a7-4112-9872-f0091b23a9e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("c476cb0c-b1c3-461a-b2db-277bf5b8ebc0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("c75b9c94-db9d-433a-906e-6a5de542a4c7"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("cf2204fd-11df-48c1-80e6-2b4d2b9e760d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("dc9ad9cb-2543-4d3d-a223-71a7be8c3887"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("e530548b-b40b-471f-ac9c-97a676cb08c0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("ef9ff377-2799-43b2-ace2-1a5978beb533"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Interest",
                keyColumn: "InterestId",
                keyValue: new Guid("f90f2466-b107-4821-b6e7-e9911d50dd3f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("1016b697-b91c-48b8-a3d7-614a633a7f0c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("150547b9-edf6-4811-afd2-66dae55eb279"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("286b979d-cff1-46de-a2ab-bba38ec8b675"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("2c29d6af-4baf-4160-9a2f-77f7c3f133c8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("300adbce-d6ed-4414-ae27-bdab4386f37c"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("34ef965e-8339-4c53-86b1-1d3d9f428de4"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("38820f66-b59a-4b5e-875a-45c0ade7a513"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("420bdd5e-b7cc-449a-85cd-379a84625c8d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("4b2358e1-8293-4789-9113-0c01d30a8820"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("6f95f72d-e4e1-4b44-835b-a0ad34dfb57b"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("708e98ab-5375-4013-8d25-fd7fc0c87eea"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("772c4277-8c6e-4c06-ae8e-1d06753c70c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("82a77a7b-eb63-4d87-aa9c-7ea637973823"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("8d8ad1f6-42c9-4b7d-938d-38147ccbe8e0"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("a97614fc-48cd-4343-901c-dc9c9ed38b6d"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("b5a4c1d4-ec86-49d0-92c1-90b268ae1a45"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("c8c10d8d-a3e2-47cc-930d-5fa6f7e9490a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("eac5a25b-a9e1-4857-a005-812ca35a53e8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("f09707a4-83f8-4f16-8147-e9a6e8b819f9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("fe499d5f-6958-490e-a17f-ca9783e11d68"));

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
    }
}
