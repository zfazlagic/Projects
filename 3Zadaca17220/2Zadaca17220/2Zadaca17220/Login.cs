using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace _2Zadaca17220
{
    public partial class Login : Form
    {
        Random rdm;
        public Login()
        {
            InitializeComponent();
            rdm = new Random();
        }
        Thread t1;
     
        private void brišiUnesenePodatke()
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try

            {
                for (int i = 0; i < Fakultet.studenti.Count(); i++) {
                    
                        if (Fakultet.studenti[i].username == textBox1.Text) {
                            if(Fakultet.studenti[i].password == maskedTextBox1.Text) {
                                StatickeVarijable.varijabla = textBox1.Text;
                                Form2 form = new Form2();
                                form.Show();
                                this.Hide();
                                }
                            }
                            
                    }

                 for (int i = 0; i < Fakultet.nastavno.Count(); i++) {
                     if (Fakultet.nastavno[i].username == textBox1.Text) {
                         if (Fakultet.nastavno[i].password == maskedTextBox1.Text) {
                             StatickeVarijable.varijabla = textBox1.Text;
                             Nastavnik nast = new Nastavnik();
                             nast.Show();
                             this.Hide();

                             }
                         }
                     }
                if (Directory.Exists("Podaci"))
                {

                    // Za svaku tekstualnu datoteku u direktoriju Korisnici
                    foreach (String s in Directory.GetFiles("Podaci"))
                    {

                        // Provjera da li postoji tekstualna datoteka pod nazivom unesenog korisničkog imena
                        if (s.Contains(textBox1.Text))
                        {

                            // Kreiranje stream-a tekstualne datoteke (otvaranje tekstualne datoteke)
                            FileStream streamDatoteke = new FileStream(s, FileMode.Open);

                            // Kreiranje stream-a za čitanje sadržaja tekstualne datoteke
                            StreamReader streamČitač = new StreamReader(streamDatoteke);

                            // Čitanje sadržaja tektualne datoteke
                            List<string> korisničkiPodaci = new List<string>();
                            while (!streamČitač.EndOfStream)
                            {
                                korisničkiPodaci.Add(streamČitač.ReadLine());
                            }

                            // Zatvaranje stream-a za čitanje sadraja tekstualne datoteke
                            streamČitač.Close();

                            // Zatvaranje stream-a tekstualne datoteke
                            streamDatoteke.Close();

                            // Provjera da li je unesena korisnička šifra ista kao i sačuvana

                            if (korisničkiPodaci[0] == maskedTextBox1.Text)
                            {
                                Form1 forma = new Form1();
                                this.Hide();
                                forma.Show();
                            } 
                            
                         
                            else
                            {
                                MessageBox.Show("Unesena korisnička šifra nije ispravna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            return;
                        }

                    }
                    
                }
                t1.Abort();
                
            }
            catch (Exception izuzetak)
            {

                // Prikazivanje izuzetka
                MessageBox.Show(izuzetak.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
            {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

           

            Rectangle elipsaPravougaonik = new Rectangle(20, 20, 200, 200);
            Rectangle elipsa = new Rectangle(200, 200, 20, 20);
            Pen myPen = new Pen(System.Drawing.Color.Green, 5);
            Rectangle myRectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawEllipse(myPen, myRectangle);
            Rectangle Rectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawRectangle(myPen, Rectangle);

            }
      

          
        
     

        private void Login_Load(object sender, EventArgs e)
        {

            t1 = new Thread(Blink);
            t1.Start();

            List<Student> st=new List<Student>();
            FileStream fs = new FileStream("Neka.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            st = (List<Student>)bf.Deserialize(fs);
            fs.Close();

           List<Predmeti> pr=new List<Predmeti>();
            FileStream fp = new FileStream("Predmet.dat", FileMode.Open);
            BinaryFormatter bp = new BinaryFormatter();
            pr = (List<Predmeti>)bp.Deserialize(fp);
            fp.Close();

            List<NastavnoOsoblje> ns = new List<NastavnoOsoblje>();

         /* FileStream fn = new FileStream("Nastavnik.dat", FileMode.Open);
            BinaryFormatter bn = new BinaryFormatter();
            ns = (List<NastavnoOsoblje>)bn.Deserialize(fn);
            fn.Close();*/
            
            Fakultet.studenti = st;
            Fakultet.predmetttt = pr;
         //  Fakultet.nastavno = ns;
        }

       
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                label4.BackColor = label4.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }
    }
}

