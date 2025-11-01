using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingColumnsOrTables3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "ClassRoom",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "ClassRoom");
        }
    }
}
