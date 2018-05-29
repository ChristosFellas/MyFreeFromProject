using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyFreeFrom.Migrations
{
    public partial class updateddietoptionentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DietType",
                table: "DietOptions",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DietType",
                table: "DietOptions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
