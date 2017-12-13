using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Projekcija
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int id { get; set; }
        public DateTime vrijemePrikazivanja { get; set; }
        public int idKinoDvorane { get; set; }
        public int idFilma { get; set; }
        public string nazivFilma { get; set; }
        public DateTime datumPrikazivanja { get; set; }


        public Projekcija (DateTime vrijemePrikazivanja, int idKinoDvorane, int idFilma,string nazivFilma,DateTime datumPrikazivanja)
            {

            this.vrijemePrikazivanja = vrijemePrikazivanja;
            this.idKinoDvorane = idKinoDvorane;
            this.nazivFilma = nazivFilma;
            this.datumPrikazivanja = datumPrikazivanja;

            }

        public Projekcija () { }
        }
    }
