﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class HouseandMedicalAllowance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HouseAllowanc",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MedicalAllowanc",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseAllowanc",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MedicalAllowanc",
                table: "Employee");
        }
    }
}
