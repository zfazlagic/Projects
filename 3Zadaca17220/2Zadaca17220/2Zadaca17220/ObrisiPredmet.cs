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
    public partial class ObrisiPredmet : Form
    {
        public ObrisiPredmet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Unesite ID");
                toolStripStatusLabel1.Text = "Greska!";
            }

            else if (Fakultet.predmetttt.Count() == 0)
            {
                errorProvider1.SetError(textBox1, "Nema upisanih predmeta!");
                toolStripStatusLabel1.Text = "Greska!";
            }
            /*  else if (Fakultet.predmetttt.Count() >= 1)
              {
                  for (int i = 0; i < Fakultet.predmetttt.Count(); i++)
                  {
                     

                  }
              }*/
            else if(Fakultet.predmetttt.Count()>=1)
            {
                for (int i = 0; i < Fakultet.predmetttt.Count; i++)
                {
                    if (Convert.ToString(Fakultet.predmetttt[i].idp) == textBox1.Text)
                    {
                         DialogResult poruka = MessageBox.Show("Da li ste sigurni da zelite obrisati predmet sa navedenim ID brojem", textBox1.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DialogResult.OK == poruka)
                        {

                            Fakultet.predmetttt.Remove(Fakultet.predmetttt[i]);
                            toolStripStatusLabel1.Text = "Uspjesno ste obrisali predmet";
                            toolStripStatusLabel1.ForeColor = Color.Green;
                            textBox1.Clear();
                        }
                        else if (DialogResult.Cancel == poruka)
                        {

                            textBox1.Clear();
                        }
                    }
                    if (i == Fakultet.predmetttt.Count() - 1 && Convert.ToString(Fakultet.predmetttt[i].idp) != textBox1.Text)
                    {
                        errorProvider1.SetError(textBox1, "Ne postoji ID!");
                        toolStripStatusLabel1.Text = "Greska!";
                    }
                    //obrisi(Convert.ToInt32(textBox1.Text));
                }
            }
        }
        private void obrisi(int id)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Unesite ID");
                toolStripStatusLabel1.Text = "Greska!";
            }

            else if (Fakultet.predmetttt.Count() == 0)
            {
                errorProvider1.SetError(textBox1, "Nema upisanih predmeta!");
                toolStripStatusLabel1.Text = "Greska!";
            }
            else
            {
                for (int i = 0; i < Fakultet.predmetttt.Count; i++)
                {
                    if (Fakultet.predmetttt[i].idp == id)
                        Fakultet.predmetttt.Remove(Fakultet.predmetttt[i]);
                }
            }
        }
    }
}
