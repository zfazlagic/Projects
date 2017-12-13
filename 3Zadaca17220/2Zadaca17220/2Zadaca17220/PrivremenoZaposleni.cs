using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zadaca17220
{
    [Serializable]
    public class PrivremenoZaposleni : NastavnoOsoblje
    {
        public DateTime pocetak, kraj;

        public PrivremenoZaposleni() { }
        public PrivremenoZaposleni(string ime, string prezime, string pozicija, string strucna, string titula, DateTime datumRodja, DateTime pocetak, DateTime kraj) : base(ime, prezime, pozicija, strucna, titula, datumRodja)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;

        }
        
        public override double ObracunPlate(int a)
        {
            double plata = Convert.ToDouble(a) * 100;
            return plata;
        }
    }
}
