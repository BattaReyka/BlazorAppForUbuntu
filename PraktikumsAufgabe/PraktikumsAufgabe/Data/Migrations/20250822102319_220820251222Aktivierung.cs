using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraktikumsAufgabe.Migrations
{
    /// <inheritdoc />
    public partial class _220820251222Aktivierung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktiv",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktiv",
                table: "AspNetUsers");
        }
    }
}
