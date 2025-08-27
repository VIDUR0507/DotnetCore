using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetCore_CrudProject.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstAddClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Standard",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "Students");
        }
    }
}
