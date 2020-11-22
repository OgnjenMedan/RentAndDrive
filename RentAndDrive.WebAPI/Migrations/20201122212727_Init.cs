using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAndDrive.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 500, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 500, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    ProizvodjacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.ProizvodjacId);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modeli",
                columns: table => new
                {
                    ModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    ProizvodjacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeli", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Modeli_Proizvodjaci",
                        column: x => x.ProizvodjacId,
                        principalTable: "Proizvodjaci",
                        principalColumn: "ProizvodjacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaId);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 500, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 500, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    GradId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KupacId);
                    table.ForeignKey(
                        name: "FK_Kupci_Gradovi",
                        column: x => x.GradId,
                        principalTable: "Gradovi",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Automobili",
                columns: table => new
                {
                    AutomobilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelId = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    GodinaProizvodnje = table.Column<int>(nullable: false),
                    Gorivo = table.Column<string>(maxLength: 15, nullable: false),
                    Snaga = table.Column<int>(nullable: false),
                    Transmisija = table.Column<string>(maxLength: 20, nullable: false),
                    BrojVrata = table.Column<int>(nullable: false),
                    BrojSjedista = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: false),
                    SlikaThumb = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobili", x => x.AutomobilId);
                    table.ForeignKey(
                        name: "FK_Automobili_Modeli",
                        column: x => x.ModelId,
                        principalTable: "Modeli",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutomobilId = table.Column<int>(nullable: false),
                    KupacId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjene_Automobili",
                        column: x => x.AutomobilId,
                        principalTable: "Automobili",
                        principalColumn: "AutomobilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_Kupci",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistracijeAutomobila",
                columns: table => new
                {
                    RegistracijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadnikId = table.Column<int>(nullable: false),
                    AutomobilId = table.Column<int>(nullable: false),
                    RegistarskeTablice = table.Column<string>(maxLength: 15, nullable: false),
                    PocetakRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    KrajRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistracijeAutomobila", x => x.RegistracijaId);
                    table.ForeignKey(
                        name: "FK_RegistracijeAutomobila_Automobili",
                        column: x => x.AutomobilId,
                        principalTable: "Automobili",
                        principalColumn: "AutomobilId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistracijeAutomobila_Korisnici",
                        column: x => x.RadnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<int>(nullable: false),
                    AutomobilId = table.Column<int>(nullable: false),
                    DatumPreuzimanja = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumPovrata = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumKreiranjaRezervacije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Napomena = table.Column<string>(maxLength: 500, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Automobili",
                        column: x => x.AutomobilId,
                        principalTable: "Automobili",
                        principalColumn: "AutomobilId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Kupci",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racuni",
                columns: table => new
                {
                    RacunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervacijaId = table.Column<int>(nullable: false),
                    BrojRacuna = table.Column<string>(maxLength: 50, nullable: false),
                    DatumKreiranjaRacuna = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrajanjeRerezvacije = table.Column<int>(nullable: false),
                    IznosRezervacijeAutomobila = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IznosSaPDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racuni", x => x.RacunId);
                    table.ForeignKey(
                        name: "FK_Racuni_Rezervacije",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobili_ModelId",
                table: "Automobili",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaId",
                table: "Gradovi",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_GradId",
                table: "Kupci",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Modeli_ProizvodjacId",
                table: "Modeli",
                column: "ProizvodjacId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_AutomobilId",
                table: "Ocjene",
                column: "AutomobilId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KupacId",
                table: "Ocjene",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_RezervacijaId",
                table: "Racuni",
                column: "RezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistracijeAutomobila_AutomobilId",
                table: "RegistracijeAutomobila",
                column: "AutomobilId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistracijeAutomobila_RadnikId",
                table: "RegistracijeAutomobila",
                column: "RadnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_AutomobilId",
                table: "Rezervacije",
                column: "AutomobilId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KupacId",
                table: "Rezervacije",
                column: "KupacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Racuni");

            migrationBuilder.DropTable(
                name: "RegistracijeAutomobila");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Automobili");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Modeli");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
