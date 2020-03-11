﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FChat.DataAccess.Migrations
{
    public partial class MessageEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Messages",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Messages");
        }
    }
}
