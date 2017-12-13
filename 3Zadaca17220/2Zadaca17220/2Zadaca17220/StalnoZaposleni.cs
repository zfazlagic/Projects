using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zadaca17220
{
    [Serializable]
   public class StalnoZaposleni: NastavnoOsoblje
    {
        public StalnoZaposleni() { }
        
        public StalnoZaposleni(string ime, string prezime, string pozicija, string strucna, string titula, DateTime datumRodja) : base(ime, prezime, pozicija, strucna, titula, datumRodja){}



        public override double ObracunPlate(int a)
        {
            double plata = Convert.ToDouble(a) * 800;
            return plata;
        }
       
    }
}
