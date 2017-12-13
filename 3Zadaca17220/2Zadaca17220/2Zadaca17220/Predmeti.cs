using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zadaca17220
{
    [Serializable]
   public class Predmeti
    {
        public int idp, brP, brV, max, ects, ciklus;
        public string naziv;
        public string opis;
        public int godina;
        public List<NastavnoOsoblje> nastavnik { get; set; }
        public List<Student> studenti { get; set; }

        public Predmeti() { }
        public Predmeti(int idp, int brP, int brV, int max, int ects, string naziv)
        {
            this.idp = idp;
            this.brP = brP;
            this.brV = brV;
            this.max = max;
            this.ects = ects;
            nastavnik = new List<NastavnoOsoblje>();
            this.naziv = naziv;
            studenti = new List<Student>();
            
        }
        public int ECTSuSate()
        {
            return ects * 30;
        }
       

    }
}
