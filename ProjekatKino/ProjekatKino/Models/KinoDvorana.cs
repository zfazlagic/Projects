using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class KinoDvorana
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }
        public string adresa { get; set; }
        public int brojMjesta { get; set; }

        public KinoDvorana (int kinoDvoranaID, string adresa, int brojMjesta)
            {
            this.adresa = adresa;
            this.brojMjesta = brojMjesta;
            }

        public KinoDvorana () { }

        }

    }
