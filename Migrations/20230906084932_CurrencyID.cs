﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTS_ApartBillingCheckList.Migrations
{
    /// <inheritdoc />
    public partial class CurrencyID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyID",
                table: "Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyID",
                table: "Registrations");
        }
    }
}
