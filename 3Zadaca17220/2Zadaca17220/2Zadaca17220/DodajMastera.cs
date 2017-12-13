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

namespace _2Zadaca17220
{
    public partial class DodajMastera : Form
    {
        public DodajMastera()
        {
            InitializeComponent();
        }
        private void UpisiuDatoteku()
        {
            try
            {

                // Kreiranje tekstualne datoteke pod nazivom unesenog korisničkog imena i upisivanje unesenih podataka
                if (!File.Exists(username.Text))
                {

                    // Kreiranje stream-a tekstualne datoteke (kreiranje tekstualne datoteke)
                    FileStream streamDatoteke = new FileStream("Podaci/" + username.Text + ".txt", FileMode.Create);

                    // Kreiranje stream-a za pisanje sadržaja tekstualne datoteke
                    StreamWriter streamPisač = new StreamWriter(streamDatoteke);

                    // Pisanje sadržaja tekstualne datoteke
                    streamPisač.WriteLine("Student master");
                    streamPisač.WriteLine(imeM.Text);
                    streamPisač.WriteLine(prezimeM.Text);
                    streamPisač.WriteLine(datumRM.Value.ToString());
                    streamPisač.WriteLine(maticniM.Text);
                    streamPisač.WriteLine(username.Text);
                    streamPisač.WriteLine(password.Text);
                    streamPisač.WriteLine(datumZavM.Value);
                    streamPisač.WriteLine(DatumUpM.Value);
                    streamPisač.WriteLine(brojPM.Value);
                    /* if (pictureBox1.ImageLocation == null)
                     {
                         pictureBox1.ImageLocation = "../../InicijalnaProfilnaSlika.jpg";
                     }
                     streamPisač.WriteLine(pictureBox1.ImageLocation);*/

                    // Čišćenje bafera stream-a za pisanje sadržaja tekstualne datoteke
                    streamPisač.Flush();

                    // Zatvaranje stream-a za pisanje sadržaja tekstualne datoteke
                    streamPisač.Close();

                    // Zatvaranje stream-a tekstualne datoteke
                    streamDatoteke.Close();

                    MessageBox.Show("Korisnik je uspješno registrovan.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tekstualna datoteka \"" + username.Text + "\" već postoji.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception izuzetak)
            {

                // Prikazivanje izuzetka
                MessageBox.Show(izuzetak.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudentMaster master = new StudentMaster(imeM.Text, prezimeM.Text, datumRM.Value);
            master.foto = slika1.BackgroundImage;
           if (maticniM.Text.Length<13)
            
            {
                errorProvider1.SetError(maticniM, "Maticni broj nije validan");
                toolStripStatusLabel1.Text = "Pogresan unos";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (!master.ValidirajDatumUpisa(datumZavM.Value, DatumUpM.Value))
            {
                datumProvider2.SetError(DatumUpM, "Nemoguc datum upisa");
                toolStripStatusLabel1.Text = "Pogresan unos";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (!(radioButtonDa.Checked) && !(radioButtonNe.Checked))
            {
                toolStripStatusLabel1.Text = "ODABERITE OPCIJU ZAVRSETKA PRETHODNOG OBRAZOVANJA!";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else
            {
                for (int i = 0; i < Fakultet.predmetttt.Count(); i++)
                {
                    if (checkedListBox1.Text == Fakultet.predmetttt[i].naziv)
                    {
                        master.polozeni.Add(Fakultet.predmetttt[i]);
                        
                    }
                    else if (checkedListBox2.Text == Fakultet.predmetttt[i].naziv)
                    {
                        master.aktivni.Add(Fakultet.predmetttt[i]);
                        Fakultet.predmetttt[i].studenti.Add(master);
                    }
                }

                master.maticni = maticniM.Text;
                master.DatumUpisa = DatumUpM.Value;
                master.DZavrsetka = datumZavM.Value;
                if (radioButtonDa.Checked)
                    master.index = master.DodijeliIndex(Fakultet.studenti.Count());
                else if (radioButtonNe.Checked)
                {
                    label8.Visible = true;
                    mjesto.Visible = true;
                    master.MjestoZavrsetka = mjesto.Text;
                    master.index = master.DodijeliNoviIndex(Fakultet.studenti.Count());
                }
                Fakultet.studenti.Add(master);
                
                toolStripStatusLabel1.Text = "Uspjesno ste registrovali master studenta.";
                toolStripStatusLabel1.BackColor = Color.Green;
                UpisiuDatoteku();

            }
             
            }

        private void imeM_Validating(object sender, CancelEventArgs e)
        {
            if (imeM.Text == "")
            {
                errorProvider1.SetError(imeM, "Unesite ime studenta");
               
            }
        }

        private void prezimeM_Validating(object sender, CancelEventArgs e)
        {
            if (prezimeM.Text == "")
            {
                errorProvider1.SetError(prezimeM, "Unesite prezime studenta");

            }
        }

        private void maticniM_Validating(object sender, CancelEventArgs e)
        {
            if (maticniM.Text == "")
            {
                errorProvider1.SetError(maticniM, "Unesite maticni broj studenta");

            }
        }

        private void mjesto_Validating(object sender, CancelEventArgs e)
        {
            if (mjesto.Text == "")
            {
                errorProvider1.SetError(mjesto, "Unesite mjesto zavrsetka studija");
            }
        }

        private void radioButtonNe_CheckedChanged(object sender, EventArgs e)
        {
            mjesto.Visible = true;
            label8.Visible = true;
        }

        private void DodajMastera_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Fakultet.predmetttt.Count; i++)
            {
                checkedListBox1.Items.Add(Fakultet.predmetttt[i].naziv);
                checkedListBox1.Items.Add(Fakultet.predmetttt[i].naziv);
            }
        }
    }
       
    }

