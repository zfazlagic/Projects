using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Zadaca17220
{
    public partial class Slika : UserControl
    {
        public Slika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(ofd.FileName))
            {
                pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }
    }
}
