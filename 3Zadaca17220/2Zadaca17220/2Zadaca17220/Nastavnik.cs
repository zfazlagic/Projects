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
    public partial class Nastavnik : Form
    {
        public Nastavnik()
        {
            InitializeComponent();
        }

        private void Nastavnik_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Fakultet.nastavno.Count(); i++)
            {
                if (Fakultet.nastavno[i].username == StatickeVarijable.varijabla)
                {
                    textBoxime.Text = Fakultet.nastavno[i].ime;
                    textBoxprezime.Text = Fakultet.nastavno[i].prezime;
                    textBoxtitula.Text = Fakultet.nastavno[i].titula;
                    textBoxpozicija.Text = Fakultet.nastavno[i].pozicija;
                    for(int j = 0; j < Fakultet.nastavno[i].predmet.Count(); j++)
                    {
                        comboBox1.Items.Add(Fakultet.nastavno[i].predmet[j].naziv);
                        comboBox2.Items.Add(Fakultet.nastavno[i].predmet[j].naziv);
                    }
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Fakultet.predmetttt.Count(); i++)
            {
                if (comboBox1.Text == Fakultet.predmetttt[i].naziv)
                {
                    imepredmeta.Visible = true;
                    imepredmeta.Text = Fakultet.predmetttt[i].naziv;
                    brojects.Visible = true;
                    brojects.Text = "Broj ects bodova " + Fakultet.predmetttt[i].ects;
                    opis.Visible = true;
                    textBox1.Visible = true;

                }
            }
           
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Fakultet.predmetttt.Count(); i++)
            {
                if (comboBox2.Text == Fakultet.predmetttt[i].naziv)
                {
                    textBoximep.Text = Convert.ToString(Fakultet.predmetttt[i].naziv);
                    textBoxmaxbr.Text = Convert.ToString(Fakultet.predmetttt[i].max);
                    textBoxbroj.Text = Convert.ToString(Fakultet.predmetttt[i].studenti.Count);
                }
            }
        }
    }
}
