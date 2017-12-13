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
    public partial class Form2 : Form
        {
        public Form2()
            {
            InitializeComponent();
            }

        private void Form2_Load(object sender, EventArgs e)
            {
            for (int i = 0; i < Fakultet.studenti.Count(); i++) {
                if (Fakultet.studenti[i].username == StatickeVarijable.varijabla) {
                    textBoxime.Text = Fakultet.studenti[i].ime;
                    textBoxprezime.Text = Fakultet.studenti[i].prezime;
                    for (int j = 0; j < Fakultet.studenti[i].polozeni.Count(); j++) {
                        comboBox1.Items.Add(Fakultet.studenti[i].polozeni[j].naziv);
                        }
                    for (int k = 0; k < Fakultet.studenti[i].aktivni.Count(); k++) {
                        comboBox2.Items.Add(Fakultet.studenti[i].polozeni[k].naziv);
                        }
                    }
                }
            for (int i = 0; i < Fakultet.studenti.Count(); i++) {
                if (Fakultet.studenti[i].username == StatickeVarijable.varijabla) {
                    for (int j = 0; j < Fakultet.studenti[i].aktivni.Count; j++) {
                        comboBox3.Items.Add(Fakultet.studenti[i].aktivni[j].naziv);
                        }
                    }
                }
            for(int i = 0; i < Fakultet.predmetttt.Count; i++) {
                
                upisi.Items.Add(Fakultet.predmetttt[i].naziv);
                }
            /*for(int i = 0; i < Fakultet.studenti.Count; i++) {
                if (Fakultet.studenti[i].username == StatickeVarijable.varijabla) {
                    for(int j = 0; j < Fakultet.predmetttt.Count; j++) {
                        for(int k = 0; k < Fakultet.studenti[i].aktivni.Count; k++) {
                            for(int l = 0; l < Fakultet.studenti[i].polozeni.Count; l++) {
                                if(Fakultet.predmetttt[j].naziv!=Fakultet.studenti[i].aktivni[k].naziv && Fakultet.predmetttt[j].naziv != Fakultet.studenti[i].polozeni[l].naziv) {
                                    upisi.Items.Add(Fakultet.predmetttt[j].naziv);
                                    }
                                }
                            }
                        }
                    }
                }*/
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            for (int i = 0; i < Fakultet.predmetttt.Count(); i++) {
                if (comboBox1.Text == Fakultet.predmetttt[i].naziv) {
                    imepredmeta.Visible = true;
                    imepredmeta.Text = Fakultet.predmetttt[i].naziv;
                    ects.Visible = true;
                    ects.Text = "Broj ects bodova " + Convert.ToString(Fakultet.predmetttt[i].ects);
                    listBox1.Visible = true;
                    label6.Visible = true;
                    for (int j = 0; j < Fakultet.predmetttt[i].nastavnik.Count(); j++) {

                        listBox1.Items.Add(Fakultet.predmetttt[i].nastavnik[j]);
                        }

                    }
                }
            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
            listBox2.ClearSelected();
            for (int i = 0; i < Fakultet.predmetttt.Count(); i++) {
                if (comboBox1.Text == Fakultet.predmetttt[i].naziv) {
                    imeaktivnog.Visible = true;
                    imeaktivnog.Text = Fakultet.predmetttt[i].naziv;
                    ectsaktivnog.Visible = true;
                    ectsaktivnog.Text = "Broj ects bodova " + Convert.ToString(Fakultet.predmetttt[i].ects);
                    listBox2.Visible = true;
                    profesoraktivnog.Visible = true;
                    for (int j = 0; j < Fakultet.predmetttt[i].nastavnik.Count(); j++) {

                        listBox2.Items.Add(Fakultet.predmetttt[i].nastavnik[j]);
                        }

                    }
                }
            }

        private void comboBox1_Click(object sender, EventArgs e)
            {
            listBox1.Items.Clear();
            }

        private void comboBox2_Click(object sender, EventArgs e)
            {
            listBox1.Items.Clear();
            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
            {
            for (int i = 0; i < Fakultet.studenti.Count; i++) {
                for (int j = 0; j < Fakultet.studenti[i].aktivni.Count; j++) {
                    if (comboBox3.Text == Fakultet.studenti[i].aktivni[j].naziv)
                        Fakultet.studenti[i].aktivni.Remove(Fakultet.studenti[i].aktivni[j]);
                    MessageBox.Show("Uspjesno ste se ispisali sa predmeta");
                    }
                }
            }

        private void upisi_SelectedIndexChanged(object sender, EventArgs e)
            {
            for (int i = 0; i < Fakultet.predmetttt.Count; i++) {
                if (Fakultet.predmetttt[i].naziv == upisi.Text) {
                    for (int j = 0; j < Fakultet.studenti.Count; j++)
                        if (Fakultet.studenti[j].username == StatickeVarijable.varijabla) {
                            Fakultet.studenti[j].aktivni.Add(Fakultet.predmetttt[i]);
                            comboBox3.Items.Add(Fakultet.predmetttt[j].naziv);
                            }
                    }
                }

            }
        }
    }

