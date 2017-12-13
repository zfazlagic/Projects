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

namespace _2Zadaca17220
{
    public partial class DodajPredmet : Form
    {
       private List<Predmeti> pr;
        private BindingList<Predmeti> p;
        private PredmetiBaza pb;
        public DodajPredmet()
        {
            InitializeComponent();
            pr = new List<Predmeti>(Fakultet.predmetttt);
            p = new BindingList<Predmeti>();
            pb = new PredmetiBaza();
        }
        private Predmeti BuildPredmet()
        {
            Predmeti predmet = new Predmeti();
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Unesite ime predmeta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (textBoxOpis.Text == "")
            {
                errorProvider1.SetError(textBoxOpis, "Unesite kratak opis predmeta predmeta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (!(radioButtonPrvi.Checked) && !(radioButtonDrugi.Checked))
            {
                toolStripStatusLabel1.Text = "Odaberite ciklus u kojem se nalazi predmet";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (!(radioButtonI.Checked) && !(radioButtonII.Checked) && !(radioButtonIII.Checked))
            {
                toolStripStatusLabel1.Text = "Odaberite studijsku godinu u kojem se nalazi predmet";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else
            {
                predmet.idp = Convert.ToInt32(numericUpDownID.Value);
                predmet.brP = Convert.ToInt32(numericUpDownPredavanja.Value);
                predmet.brP = Convert.ToInt32(numericUpDownVjezbe.Value);
                predmet.max = Convert.ToInt32(numericUpDownMax.Value);
                predmet.ects = Convert.ToInt32(numericUpDownECTS.Value);
                predmet.naziv = textBoxime.Text;
              //  Predmeti predmet = new Predmeti(Convert.ToInt32(numericUpDownID.Value), );
                if (radioButtonPrvi.Checked)
                {
                    predmet.ciklus = 1;
                    if (radioButtonI.Checked)
                    {
                        predmet.godina = 1;
                    }
                    else if (radioButtonII.Checked)
                    {
                        predmet.godina = 2;
                    }
                    else if (radioButtonIII.Checked)
                    {
                        predmet.godina = 3;
                    }
                }
                else if (radioButtonDrugi.Checked)
                {
                    predmet.ciklus = 2;
                    if (radioButtonI.Checked)
                    {
                        predmet.godina = 1;
                    }
                    else if (radioButtonII.Checked)
                    {
                        predmet.godina = 2;
                    }
                    else if (radioButtonIII.Checked)
                    {
                        predmet.godina = 3;
                    }
                }
                for (int i = 0; i < Fakultet.nastavno.Count(); i++)
                {
                    if (comboBox1.Text == Fakultet.nastavno[i].ToString() && Fakultet.nastavno[i] is StalnoZaposleni)
                    {
                        predmet.nastavnik.Add(Fakultet.nastavno[i]);
                        Fakultet.nastavno[i].predmet.Add(predmet);
                        Fakultet.nastavno[i].brojpredmeta++;
                    }
                    else if (comboBox2.Text == Fakultet.nastavno[i].ToString() && Fakultet.nastavno[i] is PrivremenoZaposleni)
                    {
                        predmet.nastavnik.Add(Fakultet.nastavno[i]);
                        Fakultet.nastavno[i].predmet.Add(predmet);
                        Fakultet.nastavno[i].brojpredmeta++;
                    }
                }
                Fakultet.predmetttt.Add(predmet);
                FileStream fk = new FileStream("Predmet.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fk, pr);
                fk.Close();
                toolStripStatusLabel1.Text = "Uspjesno ste dodali predmet";

                
            }
            return predmet;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Unesite ime predmeta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (textBoxOpis.Text == "")
            {
                errorProvider1.SetError(textBoxOpis, "Unesite kratak opis predmeta predmeta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (!(radioButtonPrvi.Checked) && !(radioButtonDrugi.Checked))
            {
                toolStripStatusLabel1.Text = "Odaberite ciklus u kojem se nalazi predmet";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (!(radioButtonI.Checked) && !(radioButtonII.Checked) && !(radioButtonIII.Checked))
            {
                toolStripStatusLabel1.Text = "Odaberite studijsku godinu u kojem se nalazi predmet";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else
            {

                Predmeti predmet = new Predmeti(Convert.ToInt32(numericUpDownID.Value), Convert.ToInt32(numericUpDownPredavanja.Value), Convert.ToInt32(numericUpDownVjezbe.Value), Convert.ToInt32(numericUpDownMax.Value), Convert.ToInt32(numericUpDownECTS.Value), textBoxime.Text);
                if (radioButtonPrvi.Checked)
                {
                    predmet.ciklus = 1;
                    if (radioButtonI.Checked)
                    {
                        predmet.godina = 1;
                    }
                    else if (radioButtonII.Checked)
                    {
                        predmet.godina = 2;
                    }
                    else if (radioButtonIII.Checked)
                    {
                        predmet.godina = 3;
                    }
                }
                else if (radioButtonDrugi.Checked)
                {
                    predmet.ciklus = 2;
                    if (radioButtonI.Checked)
                    {
                        predmet.godina = 1;
                    }
                    else if (radioButtonII.Checked)
                    {
                        predmet.godina = 2;
                    }
                    else if (radioButtonIII.Checked)
                    {
                        predmet.godina = 3;
                    }
                }
              for(int i = 0; i < Fakultet.nastavno.Count(); i++)
                {
                    if (comboBox1.Text == Fakultet.nastavno[i].ToString() && Fakultet.nastavno[i] is StalnoZaposleni)
                    {
                        predmet.nastavnik.Add(Fakultet.nastavno[i]);
                        Fakultet.nastavno[i].predmet.Add(predmet);
                        Fakultet.nastavno[i].brojpredmeta++;
                    }
                    else if (comboBox2.Text == Fakultet.nastavno[i].ToString() && Fakultet.nastavno[i] is PrivremenoZaposleni)
                    {
                        predmet.nastavnik.Add(Fakultet.nastavno[i]);
                        Fakultet.nastavno[i].predmet.Add(predmet);
                        Fakultet.nastavno[i].brojpredmeta++;
                    }
                }
                Fakultet.predmetttt.Add(predmet);
                FileStream fk = new FileStream("Predmet.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fk, pr);
                fk.Close();
                toolStripStatusLabel1.Text = "Uspjesno ste dodali predmet";

            }
        }
        private void textBoxime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Unesite ime predmeta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void textBoxOpis_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxOpis.Text == "")
            {
                errorProvider1.SetError(textBoxOpis, "Unesite kratak opis predmeta predmeta");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void DodajPredmet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Fakultet.nastavno.Count; i++)
            {
                if (Fakultet.nastavno[i] is StalnoZaposleni)
                {
                    comboBox1.Items.Add(Fakultet.nastavno[i].ToString());
                }
                else if(Fakultet.nastavno[i] is PrivremenoZaposleni)
                {
                    comboBox2.Items.Add(Fakultet.nastavno[i].ToString());
                }
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pb.otvoriKonekciju();
                if (pb.spasiStudentaBachelora(BuildPredmet()) != 1) throw new Exception("Korisnik nije unesen!");
                pb.zatvoriKonekciju();
                MessageBox.Show("Uspjesno unesen predmet");
                Controls.Clear();
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
    }
}
