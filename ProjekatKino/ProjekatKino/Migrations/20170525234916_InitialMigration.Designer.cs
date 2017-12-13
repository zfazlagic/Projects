using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProjekatKino.Models;

namespace ProjekatKinoMigrations
{
    [ContextType(typeof(KinoDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20170525234916_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ProjekatKino.Models.Film", b =>
                {
                    b.Property<int>("filmID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("duzinaTrajanja");

                    b.Property<string>("naziv");

                    b.Property<string>("opisFilma");

                    b.Property<string>("reziser");

                    b.Property<string>("zanr");

                    b.Key("filmID");
                });

            builder.Entity("ProjekatKino.Models.Karta", b =>
                {
                    b.Property<int>("kartaID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("cijenaKarte");

                    b.Property<int>("idProjekcije");

                    b.Key("kartaID");
                });

            builder.Entity("ProjekatKino.Models.KinoDvorana", b =>
                {
                    b.Property<int>("kinoDvoranaID")
                        .ValueGeneratedOnAdd();

                    b.Key("kinoDvoranaID");
                });

            builder.Entity("ProjekatKino.Models.Korisnik", b =>
                {
                    b.Property<int>("korisnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<long>("brojKreditneKartice");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("email");

                    b.Property<DateTime>("expDate");

                    b.Property<string>("ime")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("imeVlasnikaKartice");

                    b.Property<string>("password");

                    b.Property<string>("prezime");

                    b.Property<string>("prezimeVlasnikaKartice");

                    b.Property<string>("username");

                    b.Property<string>("vrstaKreditneKartice");

                    b.Key("korisnikID");
                });

            builder.Entity("ProjekatKino.Models.PosebnePonude", b =>
                {
                    b.Property<int>("posebnaPonudaID")
                        .ValueGeneratedOnAdd();

                    b.Key("posebnaPonudaID");
                });

            builder.Entity("ProjekatKino.Models.Proizvod", b =>
                {
                    b.Property<int>("proizvodID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("cijena");

                    b.Property<string>("naziv");

                    b.Property<string>("vrsta");

                    b.Key("proizvodID");
                });

            builder.Entity("ProjekatKino.Models.Projekcija", b =>
                {
                    b.Property<int>("projekcijaID")
                        .ValueGeneratedOnAdd();

                    b.Key("projekcijaID");
                });

            builder.Entity("ProjekatKino.Models.Uposlenik", b =>
                {
                    b.Property<int>("uposlenikID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adresa");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("email");

                    b.Property<string>("ime")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("maticniBroj");

                    b.Property<string>("password");

                    b.Property<string>("prezime");

                    b.Property<string>("username");

                    b.Key("uposlenikID");
                });
        }
    }
}
