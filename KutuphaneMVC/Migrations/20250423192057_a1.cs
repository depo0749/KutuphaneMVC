using System;
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
                    AId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AAdi = table.Column<string>(type: "TEXT", nullable: true),
                    AEposta = table.Column<string>(type: "TEXT", nullable: true),
                    ATelefon = table.Column<string>(type: "TEXT", nullable: true),
                    ASifre = table.Column<string>(type: "TEXT", nullable: true),
                    AKapakFoto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AId);
                });

            migrationBuilder.CreateTable(
                name: "kitaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapTuruİd = table.Column<string>(type: "TEXT", nullable: true),
                    KitapAdi = table.Column<string>(type: "TEXT", nullable: true),
                    YazarAdi = table.Column<string>(type: "TEXT", nullable: true),
                    YayinEvi = table.Column<string>(type: "TEXT", nullable: true),
                    StokAdedi = table.Column<int>(type: "INTEGER", nullable: false),
                    SayfaSayisi = table.Column<string>(type: "TEXT", nullable: true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    EklemeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KapakFoto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kullaniciClasses",
                columns: table => new
                {
                    KId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KAdi = table.Column<string>(type: "TEXT", nullable: true),
                    KEposta = table.Column<string>(type: "TEXT", nullable: true),
                    KTelefon = table.Column<string>(type: "TEXT", nullable: true),
                    KSifre = table.Column<string>(type: "TEXT", nullable: true),
                    KKapakFoto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullaniciClasses", x => x.KId);
                });

            migrationBuilder.CreateTable(
                name: "yoneticis",
                columns: table => new
                {
                    YId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YAdi = table.Column<string>(type: "TEXT", nullable: true),
                    YEposta = table.Column<string>(type: "TEXT", nullable: true),
                    YTelefon = table.Column<string>(type: "TEXT", nullable: true),
                    YSifre = table.Column<string>(type: "TEXT", nullable: true),
                    YKapakFoto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yoneticis", x => x.YId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "kitaps");

            migrationBuilder.DropTable(
                name: "kullaniciClasses");

            migrationBuilder.DropTable(
                name: "yoneticis");
        }
    }
}
