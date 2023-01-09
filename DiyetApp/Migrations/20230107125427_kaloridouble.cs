﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetApp.Migrations
{
    public partial class kaloridouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Kalori",
                table: "BesinPorsiyonlar",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Kalori",
                table: "BesinPorsiyonlar",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
