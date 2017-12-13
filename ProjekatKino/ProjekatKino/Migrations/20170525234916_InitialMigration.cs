using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ProjekatKinoMigrations
    {
    public partial class InitialMigration : Migration
        {
        public override void Up (MigrationBuilder migration)
            {
            migration.CreateTable(
                name: "Film",
                columns: table => new
                    {
                    filmID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true),
                    duzinaTrajanja = table.Column(type: "INTEGER", nullable: false),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    opisFilma = table.Column(type: "TEXT", nullable: true),
                    reziser = table.Column(type: "TEXT", nullable: true),
                    zanr = table.Column(type: "TEXT", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.filmID);
                });
            migration.CreateTable(
                name: "Karta",
                columns: table => new
                    {
                    kartaID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true),
                    cijenaKarte = table.Column(type: "REAL", nullable: false),
                    idProjekcije = table.Column(type: "INTEGER", nullable: false)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karta", x => x.kartaID);
                });
            migration.CreateTable(
                name: "KinoDvorana",
                columns: table => new
                    {
                    kinoDvoranaID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinoDvorana", x => x.kinoDvoranaID);
                });
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                    {
                    korisnikID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    brojKreditneKartice = table.Column(type: "INTEGER", nullable: false),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    email = table.Column(type: "TEXT", nullable: true),
                    expDate = table.Column(type: "TEXT", nullable: false),
                    ime = table.Column(type: "TEXT", nullable: true),
                    imeVlasnikaKartice = table.Column(type: "TEXT", nullable: true),
                    password = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    prezimeVlasnikaKartice = table.Column(type: "TEXT", nullable: true),
                    username = table.Column(type: "TEXT", nullable: true),
                    vrstaKreditneKartice = table.Column(type: "TEXT", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.korisnikID);
                });
            migration.CreateTable(
                name: "PosebnePonude",
                columns: table => new
                    {
                    posebnaPonudaID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosebnePonude", x => x.posebnaPonudaID);
                });
            migration.CreateTable(
                name: "Proizvod",
                columns: table => new
                    {
                    proizvodID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true),
                    cijena = table.Column(type: "REAL", nullable: false),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    vrsta = table.Column(type: "TEXT", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.proizvodID);
                });
            migration.CreateTable(
                name: "Projekcija",
                columns: table => new
                    {
                    projekcijaID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcija", x => x.projekcijaID);
                });
            migration.CreateTable(
                name: "Uposlenik",
                columns: table => new
                    {
                    uposlenikID = table.Column(type: "INTEGER", nullable: false),
                    //.Annotation("Sqlite:Autoincrement", true),
                    adresa = table.Column(type: "TEXT", nullable: true),
                    datumRodjenja = table.Column(type: "TEXT", nullable: false),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    maticniBroj = table.Column(type: "INTEGER", nullable: false),
                    password = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true),
                    username = table.Column(type: "TEXT", nullable: true)
                    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.uposlenikID);
                });
            }

        public override void Down (MigrationBuilder migration)
            {
            migration.DropTable("Film");
            migration.DropTable("Karta");
            migration.DropTable("KinoDvorana");
            migration.DropTable("Korisnik");
            migration.DropTable("PosebnePonude");
            migration.DropTable("Proizvod");
            migration.DropTable("Projekcija");
            migration.DropTable("Uposlenik");
            }
        }
    }
