using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_AddressId",
                schema: "dbo",
                table: "User");

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

            migrationBuilder.RenameColumn(
                name: "AddressId",
                schema: "dbo",
                table: "User",
                newName: "MailingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_User_AddressId",
                schema: "dbo",
                table: "User",
                newName: "IX_User_MailingAddressId");

            migrationBuilder.AddColumn<Guid>(
                name: "BillingAddressId",
                schema: "dbo",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressType",
                schema: "dbo",
                table: "Address",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_BillingAddressId",
                schema: "dbo",
                table: "User",
                column: "BillingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_BillingAddressId",
                schema: "dbo",
                table: "User",
                column: "BillingAddressId",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_MailingAddressId",
                schema: "dbo",
                table: "User",
                column: "MailingAddressId",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_BillingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_MailingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_BillingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AddressType",
                schema: "dbo",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "MailingAddressId",
                schema: "dbo",
                table: "User",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_User_MailingAddressId",
                schema: "dbo",
                table: "User",
                newName: "IX_User_AddressId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_AddressId",
                schema: "dbo",
                table: "User",
                column: "AddressId",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
