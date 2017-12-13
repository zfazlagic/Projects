using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Xml.Serialization;

namespace _2Zadaca17220
{
    [Serializable]
    
    public abstract class Student
    {
        public string ime { get; set; }
        public string prezime { get; set; }

  [XmlIgnore]  public DateTime DatumRodjenja { get; set; }

        [XmlIgnore]
        public DateTime DZavrsetka { get; set; }
        public string maticni { get; set; }
        [XmlIgnore]
        public DateTime DatumUpisa { get; set; }
        public string index { get; set; }
        public int brpredmeta { get; set; }
        public bool musko, zensko;
        public string rodnjenjepomocna
        {
            get { return DatumRodjenja.ToString("dd.mm.yyyy"); }

            set { DatumRodjenja = DateTime.Parse(value); }
        }

        public string upispomocna
        {
            get { return DatumUpisa.ToString("dd.mm.yyyy"); }

            set { DatumUpisa = DateTime.Parse(value); }
        }
        public string zavrsetakpomocna
        {
            get { return DZavrsetka.ToString("dd.mm.yyyy"); }

            set { DZavrsetka = DateTime.Parse(value); }
        }
        [XmlIgnore]   public Image foto { get; set; }
        public string username, password;
      
       [XmlIgnore] public List<Predmeti> polozeni { get; set; }
       [XmlIgnore]  public List<Predmeti> aktivni { get; set; }

        public Student() { }
        public Student(string ime, string prezime, DateTime datumr)
        {
            this.ime = ime;
            this.prezime = prezime;
            DatumRodjenja = datumr.Date;
            polozeni = new List<Predmeti>();
            aktivni = new List<Predmeti>();


        }



        public bool ValidirajMaticni(string maticni)
        {
            if (maticni.Length != 13) return false;
            else if ((DatumRodjenja.Day < 10 && maticni.Substring(0, 1) == "0" && maticni.Substring(1, 1) == Convert.ToString(DatumRodjenja.Day) ||
                (DatumRodjenja.Day > 9 && maticni.Substring(0, 2) == (Convert.ToString(DatumRodjenja.Day)))) &&
                ((DatumRodjenja.Month >= 10 && maticni.Substring(2, 2) == (Convert.ToString(DatumRodjenja.Month)))
                || (DatumRodjenja.Month < 10 && maticni.Substring(2, 1) == "0" &&
                maticni.Substring(3, 1) == Convert.ToString(DatumRodjenja.Month)))
                && maticni.Substring(4, 3) == Convert.ToString(DatumRodjenja.Year).Substring(1)
                && (Convert.ToInt32(maticni.Substring(7, 1)) >= 0 &&
                Convert.ToInt32(maticni.Substring(7, 1)) < 10) && (Convert.ToInt32(maticni.Substring(8, 1)) >= 0 &&
                Convert.ToInt32(maticni.Substring(8, 1)) < 10) && ((musko == true && Convert.ToInt32(maticni.Substring(9, 3)) >= 0 && Convert.ToInt32(maticni.Substring(9, 3)) <= 499)
                || (musko == false && Convert.ToInt32(maticni.Substring(9, 3)) >= 500 && Convert.ToInt32(maticni.Substring(9, 3)) <= 999)) && Convert.ToInt32(maticni.Substring(12, 1)) <= 9)
                return true;
            return false;
        }
        public abstract string DodijeliIndex(int n);


        public bool ValidirajDatumUpisa(DateTime datumz, DateTime datumup)
        {
            if (datumz.Year > datumup.Year) return false;
            if (datumz.Year == datumup.Year)
            {
                if (datumz.Month < datumup.Month) return true;
                if (datumz.Month == datumup.Month)
                {
                    if (datumz.Day <= datumup.Day)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
             return true;
        }

        public override string ToString()
        {
            return ime + prezime;
        }
    }
}
