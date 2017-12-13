using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2Zadaca17220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void batchelorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajBatchelora dodajB = new DodajBatchelora();
            dodajB.MdiParent = this;
            dodajB.Show();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajMastera dodajM = new DodajMastera();
            dodajM.MdiParent = this;
            dodajM.Show();
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obrisi obrisi = new Obrisi();
            obrisi.MdiParent = this;
            obrisi.Show();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nastavnoosoblje nastavnik = new Nastavnoosoblje();
            nastavnik.MdiParent = this;
            nastavnik.Show();
        }

        private void brisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeNastavnoOsoblje radnik = new NeNastavnoOsoblje();
            radnik.MdiParent = this;
            radnik.Show();
        }

        private void brisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ObrisiUposlenog obrisisi = new ObrisiUposlenog();
            obrisisi.MdiParent = this;
            obrisisi.Show();
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DodajPredmet predmet = new DodajPredmet();
            predmet.MdiParent = this;
            predmet.Show();
        }

        private void brisiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ObrisiPredmet pr = new ObrisiPredmet();
            pr.MdiParent = this;
            pr.Show();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            pretraga.MdiParent = this;
            pretraga.Show();
        }

       
    }
}
