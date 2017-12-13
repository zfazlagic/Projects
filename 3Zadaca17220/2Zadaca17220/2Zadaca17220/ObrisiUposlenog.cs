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
    public partial class ObrisiUposlenog : Form
    {
        public ObrisiUposlenog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Unesite sifru");
                toolStripStatusLabel1.Text = "Greska!";
            }
            else if (textBox1.Text.Length < 3)
            {
                errorProvider1.SetError(textBox1, "Minimalna duzina sifre je 3 cifri");
                toolStripStatusLabel1.Text = "Greska!";
            }
            else if (Fakultet.nastavno.Count() == 0)
            {
                errorProvider1.SetError(textBox1, "Nema uposlenih!");
                toolStripStatusLabel1.Text = "Greska!";
            }
            else if (Fakultet.nastavno.Count() >= 1)
            {
                for (int i = 0; i < Fakultet.nastavno.Count; i++)
                {
                    if (Convert.ToString(Fakultet.nastavno[i].sifra) ==textBox1.Text)
                    {
                        DialogResult poruka = MessageBox.Show("Da li ste sigurni da zelite obrisati uposlenog sa navedenim ID brojem", textBox1.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DialogResult.OK == poruka)
                        {

                            Fakultet.nastavno.Remove(Fakultet.nastavno[i]);
                            toolStripStatusLabel1.Text = "Uspjesno ste obrisali uposlenog";
                            toolStripStatusLabel1.ForeColor = Color.Green;
                            textBox1.Clear();
                        }
                        else if (DialogResult.Cancel == poruka)
                        {

                            textBox1.Clear();
                        }
                    }
                   if (i == Fakultet.nastavno.Count() - 1 && Convert.ToString(Fakultet.nastavno[i].sifra) != textBox1.Text)
                    {
                        errorProvider1.SetError(textBox1, "Ne postoji ID!");
                        toolStripStatusLabel1.Text = "Greska!";
                    }
                    //obrisi(Convert.ToInt32(textBox1.Text));
                }
            }

        }
    }
}

