using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMSBO.Migrations
{
    public partial class AddedMark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamType",
                table: "AppMarks");

            migrationBuilder.DropColumn(
                name: "Mathmatics",
                table: "AppMarks");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "AppMarks",
                newName: "Maths");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Maths",
                table: "AppMarks",
                newName: "Total");

            migrationBuilder.AddColumn<int>(
                name: "ExamType",
                table: "AppMarks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mathmatics",
                table: "AppMarks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
