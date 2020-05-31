using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GirlPower.Migrations
{
    public partial class Migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    Primalac = table.Column<string>(nullable: true),
                    DatumSlanja = table.Column<DateTime>(nullable: false),
                    Posiljalac = table.Column<string>(nullable: true),
                    PorukaObavijesti = table.Column<string>(nullable: true),
                    Tip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Lozinka = table.Column<string>(nullable: true),
                    EMailTelefon = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Registrovan = table.Column<bool>(nullable: true),
                    IdKlijenta = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tretman",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaTretmanaId = table.Column<int>(nullable: true),
                    OpisTretmana = table.Column<string>(nullable: true),
                    CijenaTretmana = table.Column<double>(nullable: false),
                    TrajanjeTretmana = table.Column<int>(nullable: false),
                    Izvrsen = table.Column<bool>(nullable: false),
                    NazivTretmana = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tretman", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tretman_Kategorija_KategorijaTretmanaId",
                        column: x => x.KategorijaTretmanaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poruka",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Posiljalac = table.Column<string>(nullable: true),
                    Primlac = table.Column<string>(nullable: true),
                    TekstPoruke = table.Column<string>(nullable: true),
                    DatumSlanja = table.Column<DateTime>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poruka_Osoba_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_UposlenikId",
                table: "Poruka",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Tretman_KategorijaTretmanaId",
                table: "Tretman",
                column: "KategorijaTretmanaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "Poruka");

            migrationBuilder.DropTable(
                name: "Tretman");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Kategorija");
        }
    }
}
