using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zadaca17220
{
    [Serializable]
    public abstract class NastavnoOsoblje
    {
        public string ime, prezime, pozicija, strucna, titula;
        public DateTime datumRodj;
        public string maticni;
        public int sifra;
        public double plata;
        public bool musko;
        public int brojpredmeta;
        public List<Predmeti> predmet { get; set; }
        public string username { get; set; }
        public string password { get; set; }



        public NastavnoOsoblje() { }
        public NastavnoOsoblje(string ime, string prezime, string pozicija, string strucna, string titula, DateTime datumRodj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.pozicija = pozicija;
            this.strucna = strucna;
            this.titula = titula;
            this.datumRodj = datumRodj;
            predmet = new List<Predmeti>();
        }
        public bool ValidirajMaticni(string maticni)
        {
            if (maticni.Length != 13) return false;
            else if ((datumRodj.Day < 10 && maticni.Substring(0, 1) == "0" && maticni.Substring(1, 1) == Convert.ToString(datumRodj.Day) ||
                (datumRodj.Day > 9 && maticni.Substring(0, 2) == (Convert.ToString(datumRodj.Day)))) &&
                ((datumRodj.Month >= 10 && maticni.Substring(2, 2) == (Convert.ToString(datumRodj.Month)))
                || (datumRodj.Month < 10 && maticni.Substring(2, 1) == "0" &&
                maticni.Substring(3, 1) == Convert.ToString(datumRodj.Month)))
                && maticni.Substring(4, 3) == Convert.ToString(datumRodj.Year).Substring(1)
                && (Convert.ToInt32(maticni.Substring(7, 1)) >= 0 &&
                Convert.ToInt32(maticni.Substring(7, 1)) < 10) && (Convert.ToInt32(maticni.Substring(8, 1)) >= 0 &&
                Convert.ToInt32(maticni.Substring(8, 1)) < 10) && ((musko == true && Convert.ToInt32(maticni.Substring(9, 3)) >= 0 && Convert.ToInt32(maticni.Substring(9, 3)) <= 499)
                || (musko == false && Convert.ToInt32(maticni.Substring(9, 3)) >= 500 && Convert.ToInt32(maticni.Substring(9, 3)) <= 999)) && Convert.ToInt32(maticni.Substring(12, 1)) <= 9)
                return true;
            return false;
        }
        public abstract double ObracunPlate(int a);
        public override string ToString()
        {
            return ime + " " + prezime;
        }
        public int GenerisiSifru(int a)
        {
            int sifra = 100;
            sifra += a;
            return sifra;
        }
       
    }
}
