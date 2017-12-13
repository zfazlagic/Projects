using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class Proizvod
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }
        public string naziv { get; set; }
        public double cijena { get; set; }
        public string vrsta { get; set; }

        public Proizvod (string naziv, double cijena, string vrsta)
            {

            this.naziv = naziv;
            this.cijena = cijena;
            this.vrsta = vrsta;

            }
        public Proizvod ()
            { }

        }
    }
