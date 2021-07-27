using Microsoft.EntityFrameworkCore.Migrations;

namespace EvolentHealth.Providers.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactEmails_Contacts_ContactsId",
                table: "ContactEmails");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPhones_Contacts_ContactsId",
                table: "ContactPhones");

            migrationBuilder.DropIndex(
                name: "IX_ContactPhones_ContactsId",
                table: "ContactPhones");

            migrationBuilder.DropIndex(
                name: "IX_ContactEmails_ContactsId",
                table: "ContactEmails");

            migrationBuilder.DropColumn(
                name: "ContactsId",
                table: "ContactPhones");

            migrationBuilder.DropColumn(
                name: "ContactsId",
                table: "ContactEmails");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<int>(
                name: "ContactsId",
                table: "ContactPhones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactsId",
                table: "ContactEmails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhones_ContactsId",
                table: "ContactPhones",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactEmails_ContactsId",
                table: "ContactEmails",
                column: "ContactsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactEmails_Contacts_ContactsId",
                table: "ContactEmails",
                column: "ContactsId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPhones_Contacts_ContactsId",
                table: "ContactPhones",
                column: "ContactsId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
