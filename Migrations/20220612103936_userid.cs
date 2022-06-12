using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tracerapi.Migrations
{
    public partial class userid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sujet",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "DateStart",
                table: "Users",
                newName: "TokenExpires");

            migrationBuilder.RenameColumn(
                name: "DateEnd",
                table: "Users",
                newName: "TokenCreated");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Sujet");

            migrationBuilder.RenameColumn(
                name: "TokenExpires",
                table: "Users",
                newName: "DateStart");

            migrationBuilder.RenameColumn(
                name: "TokenCreated",
                table: "Users",
                newName: "DateEnd");
        }
    }
}
