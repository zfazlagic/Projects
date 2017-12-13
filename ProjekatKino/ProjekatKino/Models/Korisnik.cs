using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Korisnik : Osoba
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }// primary key
        public Int64 brojKreditneKartice { get; set; }
        public DateTime expDate { get; set; }
        public string vrstaKreditneKartice { get; set; }
        public string imeVlasnikaKartice { get; set; }
        public string prezimeVlasnikaKartice { get; set; }
        public int telefon { get; set; }

        public Korisnik (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja, Int64 brojKreditneKartice, DateTime expDate, string imeVlasnikaKartice, string prezimeVlasnikaKartice, string vrstaKreditneKartice, int telefon)
                : base(ime, prezime, adresa, email, username, password, datumRodjenja)
            {
            this.brojKreditneKartice = brojKreditneKartice;
            this.expDate = expDate;
            this.imeVlasnikaKartice = imeVlasnikaKartice;
            this.prezimeVlasnikaKartice = prezimeVlasnikaKartice;
            this.vrstaKreditneKartice = vrstaKreditneKartice;
            this.telefon = telefon;
            }
        public Korisnik () { }

        }
    }
