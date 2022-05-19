using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMSBO.Migrations
{
    public partial class Updated_Mark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExamType",
                table: "AppMarks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamType",
                table: "AppMarks");
        }
    }
}
