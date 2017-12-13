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
    public partial class Pretraga : Form
    {
        public Pretraga()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Pretraga_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Fakultet.studenti.Count; i++)
                comboBox1.Items.Add(Fakultet.studenti[i].ToString());
            for (int j = 0; j < Fakultet.predmetttt.Count; j++)
                comboBox1.Items.Add(Fakultet.predmetttt[j].naziv);
            for (int k = 0; k < Fakultet.nastavno.Count(); k++)
                comboBox1.Items.Add(Fakultet.nastavno[k].ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
