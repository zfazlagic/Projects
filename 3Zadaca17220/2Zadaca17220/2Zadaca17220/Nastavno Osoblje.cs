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
    public partial class Nastavnoosoblje : Form
    {
        private List<NastavnoOsoblje> ns;
        public Nastavnoosoblje()
        {
            InitializeComponent();
            ns = new List<NastavnoOsoblje>(Fakultet.nastavno);
        }
        private void UpisuDatoteku()
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
                    streamPisač.WriteLine("Nastavno osoblje");
                    streamPisač.WriteLine(textBoxime.Text);
                    streamPisač.WriteLine(textBoxprezime.Text);
                    streamPisač.WriteLine(datumrodj.Value.ToString());
                    streamPisač.WriteLine(textBoxmaticni.Text);
                    streamPisač.WriteLine(username.Text);
                    streamPisač.WriteLine(password.Text);
                    streamPisač.WriteLine(pozicija.Text);
                    streamPisač.WriteLine(titula.Text);
                    streamPisač.WriteLine(strucna.Text);
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
            if(!(radioButtonstalno.Checked) && !(radioButtonprivremeno.Checked))
            {
                errorProvider1.SetError(radioButtonstalno, "Niste odabrali nacin zaposlenja");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Niste unijeli ime uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;

            }
            else if (textBoxprezime.Text == "")
            {
                errorProvider1.SetError(textBoxprezime, "Niste unijeli prezime uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (pozicija.Text == "")
            {
                errorProvider1.SetError(pozicija, "Odaberite poziciju osoblja");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (titula.Text == "")
            {
                errorProvider1.SetError(titula, "Odaberite titulu osoblja");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (strucna.Text == "")
            {
                errorProvider1.SetError(strucna, "Odaberite strucnu spremu uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            else if (password.Text == "")
            {
                errorProvider1.SetError(password, "Unesite password uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
            if (radioButtonstalno.Checked)
            {
                StalnoZaposleni stalninastavno = new StalnoZaposleni(textBoxime.Text, textBoxprezime.Text, pozicija.Text, strucna.Text, titula.Text, datumrodj.Value);
                if (!stalninastavno.ValidirajMaticni(textBoxmaticni.Text))
                {
                    errorProvider1.SetError(textBoxmaticni, "Pogresan maticni broj");
                    toolStripStatusLabel1.Text = "Greska";
                }
                else
                {
                    stalninastavno.brojpredmeta = Convert.ToInt32(numericUpDown1.Value);
                    Fakultet.nastavno.Add(stalninastavno);
                    stalninastavno.sifra = stalninastavno.GenerisiSifru(Fakultet.nastavno.Count());
                    toolStripStatusLabel1.Text = "Uspjesno ste dodali uposlenog";
                    toolStripStatusLabel1.BackColor = Color.Green;
                    UpisuDatoteku();
                }
            }
            else if(radioButtonprivremeno.Checked)
            {
                groupBox4.Visible = true;
                PrivremenoZaposleni privremeninastavno = new PrivremenoZaposleni(textBoxime.Text, textBoxprezime.Text, pozicija.Text, strucna.Text, titula.Text, datumrodj.Value,pocetak.Value,kraj.Value);
                if (textBoxmaticni.Text.Length<13)
                {
                    errorProvider1.SetError(textBoxmaticni, "Pogresan maticni broj");
                    toolStripStatusLabel1.Text = "Greska";
                }
                else
                {
                    privremeninastavno.brojpredmeta =Convert.ToInt32(numericUpDown1.Value);
                    Fakultet.nastavno.Add(privremeninastavno);
                    privremeninastavno.sifra = privremeninastavno.GenerisiSifru(Fakultet.nastavno.Count);

                    ns = Fakultet.nastavno;
                    FileStream fk = new FileStream("Nastavnik.dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fk, ns);

                    fk.Close();
                    toolStripStatusLabel1.Text = "Uspjesno ste dodali uposlenog";
                    toolStripStatusLabel1.BackColor = Color.Green;
                    
                    

                }
            }
        }

        private void textBoxime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxime.Text == "")
            {
                errorProvider1.SetError(textBoxime, "Niste unijeli ime uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;

            }
        }

        private void textBoxprezime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxprezime.Text == "")
            {
                errorProvider1.SetError(textBoxprezime, "Niste unijeli prezime uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void textBoxmaticni_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxmaticni.Text == "")
            {
                errorProvider1.SetError(textBoxmaticni, "Niste unijeli maticni");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void pozicija_Validating(object sender, CancelEventArgs e)
        {
            if (pozicija.Text == "")
            {
                errorProvider1.SetError(pozicija, "Odaberite poziciju osoblja");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void titula_Validating(object sender, CancelEventArgs e)
        {
            if (titula.Text == "")
            {
                errorProvider1.SetError(titula, "Odaberite titulu osoblja");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void strucna_Validating(object sender, CancelEventArgs e)
        {
            if (strucna.Text == "")
            {
                errorProvider1.SetError(strucna, "Odaberite strucnu spremu uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (username.Text == "")
            {
                errorProvider1.SetError(username, "Unesite username uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (password.Text == "")
            {
                errorProvider1.SetError(password, "Unesite password uposlenog");
                toolStripStatusLabel1.Text = "Greska";
                toolStripStatusLabel1.BackColor = Color.Red;
            }
        }
    }
}
