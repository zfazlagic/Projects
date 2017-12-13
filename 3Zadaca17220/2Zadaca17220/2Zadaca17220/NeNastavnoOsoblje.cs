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
    public partial class NeNastavnoOsoblje : Form
    {
        public NeNastavnoOsoblje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Unesite ime");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (textBoxprezime.Text == "")
            {
                errorProvider1.SetError(textBoxprezime, "Unesite prezime");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (textBoxmaticni.Text == "")
            {
                errorProvider1.SetError(textBoxmaticni, "Unesite maticni");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Unesite strucnu spremu");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else
            {
                Radnici radnik = new Radnici(textBoxime.Text, textBoxprezime.Text, dateTimePicker1.Value, comboBox1.Text);
                if (textBoxmaticni.Text.Length<13)
                {
                    errorProvider1.SetError(textBoxmaticni, "Pogresan maticni broj");
                    toolStripStatusLabel1.Text = "Greska";
                    toolStripStatusLabel1.BackColor = Color.Red;
                }
                else
                {
                    radnik.maticni = textBoxmaticni.Text;
                    Fakultet.nenastavno.Add(radnik);
                    radnik.sifra = radnik.GenerisiSifru(Fakultet.nenastavno.Count());
                    toolStripStatusLabel1.Text = "Uspjesno ste dodali uposlenog";
                    toolStripStatusLabel1.BackColor = Color.Green;

                }
            }
        }
        private void textBoxime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Unesite ime");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void textBoxprezime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxprezime.Text == "")
            {
                errorProvider1.SetError(textBoxprezime, "Unesite prezime");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void textBoxmaticni_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxmaticni.Text == "")
            {
                errorProvider1.SetError(textBoxmaticni, "Unesite maticni");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Unesite strucnu spremu");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }
    }
}
