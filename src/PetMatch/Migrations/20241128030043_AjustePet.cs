﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetMatch.Migrations
{
    /// <inheritdoc />
    public partial class AjustePet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Pets",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Pets");
        }
    }
}
