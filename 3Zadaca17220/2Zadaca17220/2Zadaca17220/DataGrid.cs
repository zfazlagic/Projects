using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace _2Zadaca17220
{
    public partial class DataGrid : Form
    {
        private BindingList<Student> st;
        BindingSource izvor;

        public DataGrid()
        {
            InitializeComponent();
        }

        public DataGrid(BindingList<Student> stu)
        {
            InitializeComponent();
            this.st = stu;
            izvor = new BindingSource(st, null);
            dataGridView1.DataSource = izvor;
        }

        private void LoadDataGridByReflection(Type type, BindingList<Student> stu)
        {
            PropertyInfo[] pi = type.GetProperties();
            foreach (StudentBachelor p in st)
            {
                object[] values = new object[pi.Length];
                for (int i = 0; i < pi.Length; i++)
                    values[i] = pi[i].GetValue(p);

                dataGridView1.Rows.Add(values);
            }

        }


        private void Deserilizacija_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li želite spasiti izmjene?", "Izmjene", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                BindingSource bs = dataGridView1.DataSource as BindingSource;
            }
        }

    }
}
