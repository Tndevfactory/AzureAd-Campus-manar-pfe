using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tracerapi.Migrations
{
    public partial class createeventdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTache",
                table: "Events",
                newName: "DateStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "DateStart",
                table: "Events",
                newName: "DateTache");
        }
    }
}
