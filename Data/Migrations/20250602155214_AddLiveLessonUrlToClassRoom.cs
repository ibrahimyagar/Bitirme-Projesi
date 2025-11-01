using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classroom.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLiveLessonUrlToClassRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LiveLessonUrl",
                table: "ClassRoom",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LiveLessonUrl",
                table: "ClassRoom");
        }
    }
}
