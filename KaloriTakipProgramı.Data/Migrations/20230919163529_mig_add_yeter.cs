﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipProgramı.Data.Migrations
{
    public partial class mig_add_yeter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters");

            migrationBuilder.CreateIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters",
                column: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters");

            migrationBuilder.CreateIndex(
                name: "IX_Waters_AppUserID",
                table: "Waters",
                column: "AppUserID",
                unique: true);
        }
    }
}
