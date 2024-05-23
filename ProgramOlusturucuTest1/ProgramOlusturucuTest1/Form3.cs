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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string lecturecode = txblecturecode.Text.Trim();
            string lecturename = txblecturename.Text.Trim();
            string termid = comboBoxterm.Text.Trim();
            string lecturer = comboBoxlecturer.Text.Trim();

            if (string.IsNullOrEmpty(lecturecode) || string.IsNullOrEmpty(lecturename) || string.IsNullOrEmpty(termid) || string.IsNullOrEmpty(lecturer))
            {
                MessageBox.Show("Please enter the all datas!!!");
            }


            // Yeni bir ListViewItem oluştur
            ListViewItem newItem = new ListViewItem(lecturecode); // İlk sütunu belirtin

            // Diğer sütunları SubItems koleksiyonuna ekleyin
            newItem.SubItems.Add(lecturename);
            newItem.SubItems.Add(termid);
            newItem.SubItems.Add(lecturer);

            // ListView'e ListViewItem'i ekle
            listView1.Items.Add(newItem);          

            // TextBox'ları temizle
            comboBoxterm.ResetText();
            comboBoxlecturer.ResetText();
            txblecturecode.Clear();
            txblecturename.Clear();

        }
        private void veriler(string p1, string p2, string p3, string p4)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add(p1, 100);
            listView1.Columns.Add(p2, 180);
            listView1.Columns.Add(p3, 80);
            listView1.Columns.Add(p4, 150);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            veriler("Lecture code", "Lecture Name", "Term", "Lecturer");

            // Enter tuşuna basıldığında olay işleyicisini bağla
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form3_KeyDown);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer Enter tuşuna basıldıysa ve bu tuş Save butonu üzerindeyken basıldıysa
            if (e.KeyCode == Keys.Enter)
            {
                // Save butonuna tıklama olayını çağır
                btnsave.PerformClick();
            }
        }
    }
}
