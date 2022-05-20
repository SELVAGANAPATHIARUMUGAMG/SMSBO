using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMSBO.Migrations
{
    public partial class Added_StudentId_To_Mark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "AppMarks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppMarks_StudentId",
                table: "AppMarks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppMarks_AppStudents_StudentId",
                table: "AppMarks",
                column: "StudentId",
                principalTable: "AppStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppMarks_AppStudents_StudentId",
                table: "AppMarks");

            migrationBuilder.DropIndex(
                name: "IX_AppMarks_StudentId",
                table: "AppMarks");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AppMarks");
        }
    }
}
