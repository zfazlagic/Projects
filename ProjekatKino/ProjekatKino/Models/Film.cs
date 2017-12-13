using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Film
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string naziv { get; set; }
        public string zanr { get; set; }
        public int duzinaTrajanja { get; set; } //u minutama
        public string reziser { get; set; }
        public string opisFilma { get; set; }
        // public List<String> glavneUloge;

        public Film (string naziv, string zanr, int duzinaTrajanja, string reziser, string opisFilma)
            {
            this.naziv = naziv;
            this.zanr = zanr;
            this.duzinaTrajanja = duzinaTrajanja;
            this.reziser = reziser;
            this.opisFilma = opisFilma;
            }
        public Film ()
            { }
        }

    }
