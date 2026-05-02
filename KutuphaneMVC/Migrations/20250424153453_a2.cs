using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneMVC.Migrations
{
    /// <inheritdoc />
    public partial class a2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "yoneticis");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "kitaps",
                newName: "Tur");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tur",
                table: "kitaps",
                newName: "Aciklama");

            migrationBuilder.CreateTable(
                name: "yoneticis",
                columns: table => new
                {
                    YId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YAdi = table.Column<string>(type: "TEXT", nullable: true),
                    YEposta = table.Column<string>(type: "TEXT", nullable: true),
                    YKapakFoto = table.Column<string>(type: "TEXT", nullable: true),
                    YSifre = table.Column<string>(type: "TEXT", nullable: true),
                    YTelefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yoneticis", x => x.YId);
                });
        }
    }
}
