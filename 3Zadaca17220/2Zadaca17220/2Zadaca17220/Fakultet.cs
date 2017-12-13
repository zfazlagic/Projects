using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Zadaca17220
{
    public static class Fakultet
    {
        public static List<Student> studenti;
        public static List<NastavnoOsoblje> nastavno;
        public static List<Radnici> nenastavno;
        public static List<Predmeti> predmetttt;
       
       static Fakultet()
        {
            studenti = new List<Student>();
            nastavno = new List<NastavnoOsoblje>();
            nenastavno = new List<Radnici>();
            predmetttt = new List<Predmeti>();
        }

       static void DodajBatchelora(string ime, string prezime, DateTime datumr, string maticni, DateTime datumz, DateTime datumup)
        {
            StudentBachelor studenb = new StudentBachelor(ime, prezime, datumr);
            if (studenb.ValidirajMaticni(maticni))
            {
                studenb.maticni = maticni;

                if (studenb.ValidirajDatumUpisa(datumz, datumup))
                {
                    studenb.DZavrsetka = datumz;
                    studenb.DatumUpisa = datumup;
                    studenti.Add(studenb);
                    studenb.index = studenb.DodijeliIndex(studenti.Count());
                }
            }
        }
        static void DodajMastera(string ime, string prezime, DateTime datumr, string maticni, DateTime datumz, DateTime datumup,string mjesto)
        {
            StudentMaster studentm=new StudentMaster(ime, prezime, datumr);
            if (studentm.ValidirajMaticni(maticni))
            {
                studentm.maticni = maticni;

                if (studentm.ValidirajDatumUpisa(datumz, datumup))
                {
                    studentm.DZavrsetka = datumz;
                    studentm.DatumUpisa = datumup;
                    studenti.Add(studentm);
                    studentm.index = studentm.DodijeliIndex(studenti.Count());
                }
            }
            
        }
        static public void ObrisiStudenta(string index)
        {
            for(int i = 0; i < studenti.Count(); i++)
            {
                if (studenti[i].index == index)
                    studenti.Remove(studenti[i]);
            }
        }
        static public void DodajStalnoNastavno(string ime, string prezime,string maticni, string pozicija, string strucna, string titula,int brp, DateTime datumRodja)
        {
            StalnoZaposleni stalniNastavni = new StalnoZaposleni(ime, prezime, pozicija, strucna, titula, datumRodja);
            if (stalniNastavni.ValidirajMaticni(maticni)) 
            {
                stalniNastavni.maticni = maticni;
                nastavno.Add(stalniNastavni);
               stalniNastavni.sifra= stalniNastavni.GenerisiSifru(nastavno.Count());
            }
            

        }
        static public void DodajPrivremenoNastavno(string ime, string prezime, string pozicija, string strucna, string titula, DateTime datumRodja, DateTime pocetak, DateTime kraj,string maticni,int brp)
        {
            PrivremenoZaposleni privremeniNastavni = new PrivremenoZaposleni(ime, prezime, pozicija, strucna, titula, datumRodja, pocetak, kraj);
            if (privremeniNastavni.ValidirajMaticni(maticni))
            {
                privremeniNastavni.maticni = maticni;
                nastavno.Add(privremeniNastavni);
               privremeniNastavni.sifra= privremeniNastavni.GenerisiSifru(nastavno.Count());
            }
        }
        static public void ObrisiNastavnoOsoblje(int sifra)
        {
            for(int i = 0; i < nastavno.Count(); i++)
            {
                if (nastavno[i].sifra == sifra) nastavno.Remove(nastavno[i]);
            }
        }
        static public void DodajNeNastavnoOsoblje(string ime, string prezime, DateTime datumRodj, string maticni, string strucna)
        {
            Radnici radnik = new Radnici(ime, prezime, datumRodj, strucna);
            if (radnik.ValidirajMaticni(maticni))
            {
                radnik.maticni = maticni;
                nenastavno.Add(radnik);
                radnik.sifra = radnik.GenerisiSifru(nenastavno.Count());
            }
        }
        static public void ObrisiNeNastavnoOsoblje(int sifra)
        {
            for (int i = 0; i < nenastavno.Count(); i++)
            {
                if (nenastavno[i].sifra == sifra) nenastavno.Remove(nenastavno[i]);
            }
        }
        static public void ObrisiPredmet(int sifra)
        {
            for(int i = 0; i < predmetttt.Count(); i++)
            {
                if (predmetttt[i].idp == sifra) predmetttt.Remove(predmetttt[i]);
            }
        }


    }
}
