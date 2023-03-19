using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_SirketApp.Model.Migrations
{
    /// <inheritdoc />
    public partial class InitialCrated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cocuks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocuks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gorevlendirmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeId = table.Column<int>(type: "int", nullable: false),
                    PersonelNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevlendirmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAdi = table.Column<int>(type: "int", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirimNo = table.Column<int>(type: "int", nullable: false),
                    UnvanNo = table.Column<int>(type: "int", nullable: false),
                    CalismaSaati = table.Column<byte>(type: "tinyint", nullable: false),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prim = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjeBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unvans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birims");

            migrationBuilder.DropTable(
                name: "Cocuks");

            migrationBuilder.DropTable(
                name: "Gorevlendirmes");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "Ils");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Projes");

            migrationBuilder.DropTable(
                name: "Unvans");
        }
    }
}
