using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramOlusturucuTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddperson_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            this.Hide();
            F2.ShowDialog();
            this.Show();
        }

        private void btnaddlecture_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Hide();
            F3.ShowDialog();
            this.Show();
        }

        private void btnaddanalyze_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            this.Hide();
            F4.ShowDialog();
            this.Show();
        }
    }
}
