using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
    {
    public class PosebnePonude
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string naziv;
        public double cijena;
        public string velicina;
        public string sadrzaj1;
        public string sadrzaj2;
        public string kratakOpis;

        public PosebnePonude (string naziv, double cijena, string velicina, string sadrzaj1, string sadrzaj2, string kratakOpis)
            {

            this.naziv = naziv;
            this.cijena = cijena;
            this.velicina = velicina;
            this.sadrzaj1 = sadrzaj1;
            this.sadrzaj2 = sadrzaj2;
            this.kratakOpis = kratakOpis;

            }

        public PosebnePonude () { }


        }
    }
