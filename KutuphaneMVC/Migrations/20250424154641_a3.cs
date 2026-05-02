using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneMVC.Migrations
{
    /// <inheritdoc />
    public partial class a3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitapTuruİd",
                table: "kitaps");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KitapTuruİd",
                table: "kitaps",
                type: "TEXT",
                nullable: true);
        }
    }
}
