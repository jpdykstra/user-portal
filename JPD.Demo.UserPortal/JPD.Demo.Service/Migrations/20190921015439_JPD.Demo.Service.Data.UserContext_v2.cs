using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JPD.Demo.Service.Migrations
{
    public partial class JPDDemoServiceDataUserContext_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_User_MailingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MailingAddressId",
                schema: "dbo",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "dbo",
                table: "Address",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                schema: "dbo",
                table: "Address",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                schema: "dbo",
                table: "Address",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                schema: "dbo",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                schema: "dbo",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "dbo",
                table: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "BillingAddressId",
                schema: "dbo",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MailingAddressId",
                schema: "dbo",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_BillingAddressId",
                schema: "dbo",
                table: "User",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MailingAddressId",
                schema: "dbo",
                table: "User",
                column: "MailingAddressId");

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
    }
}
