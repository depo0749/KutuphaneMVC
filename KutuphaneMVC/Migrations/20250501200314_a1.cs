using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneMVC.Migrations
{
    /// <inheritdoc />
    public partial class a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AAd = table.Column<string>(type: "TEXT", nullable: true),
                    AEposta = table.Column<string>(type: "TEXT", nullable: true),
                    ATelefon = table.Column<string>(type: "TEXT", nullable: true),
                    ASifre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "emanetKitaps",
                columns: table => new
                {
                    EKitapId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EKullaniciAD = table.Column<string>(type: "TEXT", nullable: true),
                    EKitapAdi = table.Column<string>(type: "TEXT", nullable: true),
                    EYazar = table.Column<string>(type: "TEXT", nullable: true),
                    EKitapAdiSayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    ETur = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emanetKitaps", x => x.EKitapId);
                });

            migrationBuilder.CreateTable(
                name: "EntityNames",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KAd = table.Column<string>(type: "TEXT", nullable: true),
                    KEposta = table.Column<string>(type: "TEXT", nullable: true),
                    KTelefon = table.Column<string>(type: "TEXT", nullable: true),
                    KSifre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityNames", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "kitaps",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapAdi = table.Column<string>(type: "TEXT", nullable: true),
                    Yazar = table.Column<string>(type: "TEXT", nullable: true),
                    SayfaSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    Tur = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaps", x => x.KitapId);
                });

            migrationBuilder.CreateTable(
                name: "mesajs",
                columns: table => new
                {
                    MId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MKAd = table.Column<string>(type: "TEXT", nullable: true),
                    MMesaj = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesajs", x => x.MId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "emanetKitaps");

            migrationBuilder.DropTable(
                name: "EntityNames");

            migrationBuilder.DropTable(
                name: "kitaps");

            migrationBuilder.DropTable(
                name: "mesajs");
        }
    }
}
