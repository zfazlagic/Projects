using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Zadaca17220
{
    public partial class Glavna_forma : Form
    {
        public Glavna_forma()
        {
            InitializeComponent();
        }

        private void Glavna_forma_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();

            /////////////////////////////////////TEST OBJEKTI///////////////////////////////////////////////////////////
          /*  Predmeti p1 = new Predmeti(1023, 20, 10, 150, 7, "Razvoj programskih rjesenja");
            Predmeti p2 = new Predmeti(10124, 20, 10, 200, 5, "Osnove baza podataka");
            Predmeti p3 = new Predmeti(10125, 20, 10, 400, 7, "Osnove elektrotehnike");
            Predmeti p4 = new Predmeti(10126, 20, 10, 250, 6, "Tehnike programiranja");
            Predmeti probni = new Predmeti(10127, 20, 10, 250, 6, "Sistemsko programiranje");
            StalnoZaposleni s1 = new StalnoZaposleni("Selvedina", "Fazlagic", "Profesor", "Doktor nauka", "Redovni profesor doktor", new DateTime(1971, 01, 18));
            s1.username = "sfazlagic1";
            s1.password = "54321";
            StalnoZaposleni s2 = new StalnoZaposleni("Ademir", "Fazlagic", "Profesor", "Doktor nauka", "Redovni profesor doktor", new DateTime(1957, 07, 08));
            s2.username = "afazlagic1";
            s2.password = "54321";
            StalnoZaposleni s3 = new StalnoZaposleni("Samir", "Ribic", "Profesor", "Doktor nauka", "Redovni profesor doktor", new DateTime(1958, 12, 28));
            s3.username = "sribic1";
            s3.password = "54321";
            PrivremenoZaposleni p = new PrivremenoZaposleni("Faruk", "Mustafic", "Pomocno osoblje", "Magistar nauka", "Asistent", new DateTime(1993, 12, 23), new DateTime(2015, 12, 12), new DateTime(2017, 12, 12));
            p.username = "fmustafic1";
            p.password = "54321";
            //dodavanje nastavnika na predmet samo radi tesiranja
            p1.nastavnik.Add(s1);
            p1.nastavnik.Add(p);
            p2.nastavnik.Add(s2);
            p2.nastavnik.Add(p);
            p3.nastavnik.Add(s3);
            p3.nastavnik.Add(p);
            p4.nastavnik.Add(s1);
            probni.nastavnik.Add(s1);

            s1.predmet.Add(p1);
            s1.predmet.Add(p4);
            s1.predmet.Add(probni);
            p.predmet.Add(p1);
            s2.predmet.Add(p2);
            p.predmet.Add(p2);
            s3.predmet.Add(p3);
            p.predmet.Add(p3);
            StudentBachelor b1 = new StudentBachelor("Dino", "Cosic", new DateTime(1995, 08, 12));
            b1.username = "docic1";
            b1.password = "12345";
            b1.polozeni.Add(p3);
            b1.polozeni.Add(p4);
            b1.aktivni.Add(p1);
            b1.aktivni.Add(p2);
            p1.studenti.Add(b1);
            p2.studenti.Add(b1);
            StudentBachelor b2 = new StudentBachelor("Lusy", "Musinovic", new DateTime(1996, 02, 28));
            b2.username = "lmusinovic2";
            b2.password = "12345";
            b2.polozeni.Add(p3);
            b2.polozeni.Add(p4);
            b2.aktivni.Add(p1);
            b2.aktivni.Add(p2);
            p1.studenti.Add(b2);
            p2.studenti.Add(b2);
            StudentMaster m1 = new StudentMaster("Omar", "Sokolovic", new DateTime(1994, 12, 12));
            m1.username = "osokolovic1";
            m1.password = "12345";
            m1.polozeni.Add(p3);
            m1.polozeni.Add(p4);
            m1.aktivni.Add(p1);
            m1.aktivni.Add(p2);
            p1.studenti.Add(m1);
            p2.studenti.Add(m1);
            Fakultet.nastavno.Add(s1);
            Fakultet.nastavno.Add(s2);
            Fakultet.nastavno.Add(s3);
            Fakultet.nastavno.Add(p);
            s1.sifra = 10004;
            s2.sifra = s2.GenerisiSifru(Fakultet.nastavno.Count());
            s3.sifra = s3.GenerisiSifru(Fakultet.nastavno.Count());
            p.sifra = p.GenerisiSifru(Fakultet.nastavno.Count());
            Fakultet.predmetttt.Add(p1);
            Fakultet.predmetttt.Add(p2);
            Fakultet.predmetttt.Add(p3);
            Fakultet.predmetttt.Add(p4);
            Fakultet.predmetttt.Add(probni);
            Fakultet.studenti.Add(b1);
            Fakultet.studenti.Add(b2);
            Fakultet.studenti.Add(m1);
            b1.index = "17220";
            b2.index = b2.DodijeliIndex(Fakultet.nastavno.Count());

            m1.index = m1.DodijeliIndex(Fakultet.nastavno.Count());
            //////////////////////////////////////////////////////////////////////////////////////////////////////*/
        }

        private void button1_Click(object sender, EventArgs e)
            {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
            }
        }
}
