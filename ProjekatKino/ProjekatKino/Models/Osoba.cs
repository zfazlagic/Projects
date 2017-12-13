using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public abstract class Osoba
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //idOsobe mozda potrebno dodati
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime datumRodjenja { get; set; }

        public Osoba ()
            { }

        public Osoba (string ime, string prezime, string adresa, string email, string username, string password, DateTime datumRodjenja)
            {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.email = email;
            this.username = username;
            this.password = password;
            this.datumRodjenja = datumRodjenja;
            }


        }
    }
