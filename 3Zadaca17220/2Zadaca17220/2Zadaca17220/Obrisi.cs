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
    public partial class Obrisi : Form
    {
        public Obrisi()
        {
            InitializeComponent();
        }

        private void brisi_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Unesite index");
            }
            else if (textBox1.Text.Length < 5)
            {
                errorProvider1.SetError(textBox1, "Minimalna duzina indexa je 6 cifri");
            }
            else if (Fakultet.studenti.Count() == 0)
            {
                errorProvider1.SetError(textBox1, "Nema upisanih studenata!");
                toolStripStatusLabel1.Text = "Greska!";
            }
            
            else if (Fakultet.studenti.Count() >= 1)
            {
                for (int i = 0; i < Fakultet.studenti.Count; i++)
                {
                    if (Fakultet.studenti[i].index==textBox1.Text)
                    {
                        DialogResult poruka = MessageBox.Show("Da li ste sigurni da zelite obrisati studenta sa navedenim brojem indexa", textBox1.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DialogResult.OK == poruka)
                        {

                            Fakultet.studenti.Remove(Fakultet.studenti[i]);
                            toolStripStatusLabel1.Text = "Uspjesno ste obrisali studenta";
                            toolStripStatusLabel1.ForeColor = Color.Green;
                            textBox1.Clear();
                        }
                        else if (DialogResult.Cancel == poruka)
                        {

                            textBox1.Clear();
                        }
                    }
                    if (i == Fakultet.studenti.Count() - 1 && Fakultet.studenti[i].index != textBox1.Text)
                    {
                        errorProvider1.SetError(textBox1, "Ne postoji index!");
                        toolStripStatusLabel1.Text = "Greska!";
                    }
                    //obrisi(Convert.ToInt32(textBox1.Text));
                }
            }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Unesite index");
            }
            else if (textBox1.Text.Length < 5)
            {
                errorProvider1.SetError(textBox1, "Minimalna duzina indexa je 6 cifri");
            }
            else if (Fakultet.studenti.Count() == 0)
            {
                errorProvider1.SetError(textBox1, "Ne postoji index!");
                toolStripStatusLabel1.Text = "Greska!";
            }
            else
            {
                for (int i = 0; i < Fakultet.studenti.Count(); i++)
                {
                    if (i == Fakultet.studenti.Count() - 1 && Fakultet.studenti[i].index != textBox1.Text)
                    {
                        errorProvider1.SetError(textBox1, "Ne postoji index!");
                        toolStripStatusLabel1.Text = "Greska!";
                    }
                }
            }
        }
    }
}