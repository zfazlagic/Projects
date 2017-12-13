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
using System.Xml;
using System.Xml.Serialization;

namespace _2Zadaca17220
{
    public partial class DodajBatchelora : Form
    {
        private BindingList<Student> stud;
        private StudentiBaza baza;
       private List<Student> st;
        public DodajBatchelora()
        {
            InitializeComponent();
           
            stud = new BindingList<Student>();
            baza = new StudentiBaza();
            st = new List<Student>(Fakultet.studenti);
        }

        private StudentBachelor BuildStudenta()
        {
            StudentBachelor studenb = new StudentBachelor();

            if (imeB.Text == "")
            {
                errorProvider1.SetError(imeB, "Unesite ime studenta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (prezimeB.Text == "")
            {
                errorProvider1.SetError(prezimeB, "Unesite prezime studenta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else
            {
                studenb.ime = imeB.Text;
                studenb.prezime = prezimeB.Text;
                studenb.DatumRodjenja = datumRodj.Value;
               // StudentBachelor studenb = new StudentBachelor();
                studenb.foto = slika1.BackgroundImage;
                if (maticni.Text.Length < 13)

                {
                    errorProvider1.SetError(maticni, "Maticni broj nije validan");
                    toolStripStatusLabel1.Text = "Pogresan unos";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }
                else if (!studenb.ValidirajDatumUpisa(datumZav.Value, datumUp.Value))
                {
                    errorProvider1.SetError(datumUp, "Nemoguc datum upisa");
                    toolStripStatusLabel1.Text = "Pogresan unos";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }
                else if (!(radioButton1.Checked) && !(radioButton2.Checked) && !(radioButton3.Checked))
                {
                    toolStripStatusLabel1.Text = "ODABERITE GODINU STUDIJA!";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }


                else
                {
                    for (int i = 0; i < Fakultet.predmetttt.Count(); i++)
                    {
                        if (polozeni.Text == Fakultet.predmetttt[i].naziv)
                        {
                            studenb.polozeni.Add(Fakultet.predmetttt[i]);
                        }
                        else if (novi.Text == Fakultet.predmetttt[i].naziv)
                        {
                            studenb.aktivni.Add(Fakultet.predmetttt[i]);
                            Fakultet.predmetttt[i].studenti.Add(studenb);
                        }
                    }
                    studenb.maticni = maticni.Text;
                    studenb.DatumUpisa = datumUp.Value;
                    studenb.DZavrsetka = datumZav.Value;
                    Fakultet.studenti.Add(studenb);
                    studenb.index = studenb.DodijeliIndex(Fakultet.studenti.Count());
                    toolStripStatusLabel1.Text = "Uspjesno ste registrovali bachelor studenta";
                    toolStripStatusLabel1.BackColor = Color.Green;
                    
                   
                }
            }
           
            return studenb;
        }


        private void dodaj_Click(object sender, EventArgs e)
        {
            if (imeB.Text == "")
            {
                errorProvider1.SetError(imeB, "Unesite ime studenta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (prezimeB.Text == "")
            {
                errorProvider1.SetError(prezimeB, "Unesite prezime studenta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else
            {
                StudentBachelor studenb = new StudentBachelor(imeB.Text, prezimeB.Text, datumRodj.Value);
                studenb.foto = slika1.BackgroundImage;
                if (maticni.Text.Length < 13)

                {
                    errorProvider1.SetError(maticni, "Maticni broj nije validan");
                    toolStripStatusLabel1.Text = "Pogresan unos";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }
                else if (!studenb.ValidirajDatumUpisa(datumZav.Value, datumUp.Value))
                {
                    errorProvider1.SetError(datumUp, "Nemoguc datum upisa");
                    toolStripStatusLabel1.Text = "Pogresan unos";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }
                else if (!(radioButton1.Checked) && !(radioButton2.Checked) && !(radioButton3.Checked))
                {
                    toolStripStatusLabel1.Text = "ODABERITE GODINU STUDIJA!";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }
                
                
                else
                {
                    for(int i = 0; i < Fakultet.predmetttt.Count(); i++)
                    {
                        if (polozeni.Text == Fakultet.predmetttt[i].naziv)
                        {
                            studenb.polozeni.Add(Fakultet.predmetttt[i]);
                        }
                        else if (novi.Text == Fakultet.predmetttt[i].naziv)
                        {
                            studenb.aktivni.Add(Fakultet.predmetttt[i]);
                            Fakultet.predmetttt[i].studenti.Add(studenb);
                        }
                    }
                    studenb.maticni = maticni.Text;
                    studenb.DatumUpisa = datumUp.Value;
                    studenb.DZavrsetka = datumZav.Value;
                    Fakultet.studenti.Add(studenb);
                    studenb.index = studenb.DodijeliIndex(Fakultet.studenti.Count());
                    toolStripStatusLabel1.Text = "Uspjesno ste registrovali bachelor studenta";
                    toolStripStatusLabel1.BackColor = Color.Green;

                    //spasi u binarnu
                    st = Fakultet.studenti;
                    FileStream fk = new FileStream("Neka.dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fk, st);
                    fk.Close();

                }
            }
        }
        private void imeB_Validating(object sender, CancelEventArgs e)
        {
            if (imeB.Text == "")
            {
                errorProvider1.SetError(imeB, "Unesite ime studenta");
            }
        }

        private void prezimeB_Validating(object sender, CancelEventArgs e)
        {
            if (prezimeB.Text=="")
            {
                errorProvider1.SetError(prezimeB, "Unesite prezime studenta");
            }
        }

        private void maticni_Validating(object sender, CancelEventArgs e)
        {
            if (maticni.Text=="")
            {
                errorProvider1.SetError(maticni, "Unesite ime studenta");
            }
        }

        private void DodajBatchelora_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <Fakultet.predmetttt.Count; i++)
            {
                polozeni.Items.Add(Fakultet.predmetttt[i].naziv);
                novi.Items.Add(Fakultet.predmetttt[i].naziv);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            polozeni.Visible = true;
            polozenipredmet.Visible = true;
        }

        //upisiu bazu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                if (baza.spasiStudentaBachelora(BuildStudenta()) != 1) throw new Exception("Korisnik nije unesen!");
                baza.zatvoriKonekciju();
                MessageBox.Show("Uspjesno unesen korisnik");
                Controls.Clear();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void DodajBatchelora_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void DodajBatchelora_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
             
                baza.zatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  FileStream fs = new FileStream("Nesto.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
            xs.Serialize(fs, st.ToArray());
            fs.Close();*/
        }
    }
}
