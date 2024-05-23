using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProgramOlusturucuTest1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TANSK0J; Initial Catalog = courseSchedule; Integrated Security=True"); //veritabanı bağlantısı.
        SqlCommand command = new SqlCommand();
        BindingSource bindingSource = new BindingSource();
        DataSet dataSet = new DataSet();
        SqlDataReader dataReader;

        private bool newRecord;
        private string lecturerID;

        private string oldTitle;
        private string oldNameSurname;
        private string oldBranch;
        private string oldOffDay;

        public void verileriCek()
        {
            try
            {
                // Bağlantı dizesi ve SQL sorgusu
                string query = "SELECT lecturerID AS 'Lecturer ID', title AS 'Title', nameSurname AS 'Name Surname', branch AS 'Branch', dayoff AS 'Off Day' FROM tbl_Lecturer";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                // Veri setini doldur
                if (dataSet.Tables["tbl_Lecturer"] != null)
                {
                    dataSet.Tables["tbl_Lecturer"].Clear();
                }
                dataAdapter.Fill(dataSet, "tbl_Lecturer");

                // BindingSource'a veri kaynağını ekle
                bindingSource.DataSource = dataSet.Tables["tbl_Lecturer"];

                // DataGridView'e veri kaynağını ekle
                dataGridView1.DataSource = bindingSource;
                dataGridView1.ReadOnly = true;

                // Var olan bindingleri temizle ve yenilerini ekle
                txbid.DataBindings.Clear();
                txbid.DataBindings.Add("Text", bindingSource, "Lecturer ID");

                comboBoxtitle.DataBindings.Clear();
                comboBoxtitle.DataBindings.Add("Text", bindingSource, "Title");

                txbnamesurname.DataBindings.Clear();
                txbnamesurname.DataBindings.Add("Text", bindingSource, "Name Surname");

                txbbranch.DataBindings.Clear();
                txbbranch.DataBindings.Add("Text", bindingSource, "Branch");

                comboBoxoffday.DataBindings.Clear();
                comboBoxoffday.DataBindings.Add("Text", bindingSource, "Off Day");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Occurred While Loading Datas: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ilerigeri(object sender, EventArgs e)
        {
            if (bindingSource.Position <= 0) btngeri.Enabled = false; else btngeri.Enabled = true;
            if (bindingSource.Position == bindingSource.Count - 1) btnileri.Enabled = false; else btnileri.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                //MessageBox.Show("Bağlantı başarılı!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboBoxtitle.Enabled = false; txbnamesurname.Enabled = false; txbbranch.Enabled = false; comboBoxoffday.Enabled = false; btnsave.Enabled = false; btncancel.Enabled = false;

            verileriCek();

            bindingSource.PositionChanged += new EventHandler(ilerigeri);
        }

        int kacinci;
        private void btnnewrecord_Click(object sender, EventArgs e)
        {
            // Mevcut verileri saklayın
            oldTitle = comboBoxtitle.Text;
            oldNameSurname = txbnamesurname.Text;
            oldBranch = txbbranch.Text;
            oldOffDay = comboBoxoffday.Text;

            comboBoxtitle.Enabled = true; txbnamesurname.Enabled = true; txbbranch.Enabled = true; comboBoxoffday.Enabled = true; btnsave.Enabled = true; btncancel.Enabled = true;
            comboBoxtitle.ResetText(); txbnamesurname.Clear(); txbbranch.Clear(); comboBoxoffday.ResetText();
            comboBoxtitle.SelectedIndex = 0; comboBoxoffday.SelectedIndex = 0;

            kacinci = dataSet.Tables["tbl_Lecturer"].Rows.Count;
            newRecord = true;
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            // TextBox'lardan verileri al
            lecturerID = txbid.Text.Trim();
            string title = comboBoxtitle.Text.Trim();
            string namesurname = txbnamesurname.Text.Trim();
            string branch = txbbranch.Text.Trim();
            string offday = comboBoxoffday.Text.Trim();

            // Eğer TextBox'lardan herhangi biri boşsa veya değişiklik yapılmamışsa ekleme yapma
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(namesurname) || string.IsNullOrEmpty(branch) || string.IsNullOrEmpty(offday) || title == "Choose" || offday == "Choose")
            {
                MessageBox.Show("Please enter the all datas!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                try
                {
                    command.Connection = connection;
                    command.Parameters.Clear(); // Parametreleri temizle

                    if (newRecord)
                    {
                        //aynı kullanıcı bilgileri ile veritabanı kayıt işlemi yapılmış mı diye kontrol ediliyor.
                        command.CommandText = ("SELECT title, nameSurname FROM tbl_Lecturer WHERE title = '" + title + "' AND nameSurname = '" + namesurname + "'");
                        dataReader = command.ExecuteReader();
                        //girilen kayıt varsa mesaj ver
                        if (dataReader.Read())
                        {
                            MessageBox.Show("This User is Already Registered: ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dataReader.Close();
                        }

                        else
                        {
                            command.CommandText = "INSERT INTO tbl_Lecturer(title, nameSurname, branch, dayoff) VALUES (@title, @nameSurname, @branch, @dayoff)";
                        }

                    }
                    else
                    {
                        command.CommandText = "UPDATE tbl_Lecturer SET title = @Title, nameSurname = @NameSurname, branch = @Branch, dayoff = @DayOff WHERE lecturerID = @LecturerID";
                        command.Parameters.AddWithValue("@LecturerID", lecturerID);
                    }

                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@nameSurname", namesurname);
                    command.Parameters.AddWithValue("@branch", branch);
                    command.Parameters.AddWithValue("@dayoff", offday);

                    int result = command.ExecuteNonQuery();
                    // Check if update was successful
                    if (result > 0)
                    {
                        MessageBox.Show("Your Registration Has Been Successfully Completed.", "Information Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified lecturerID.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                verileriCek();
                bindingSource.Position = kacinci;
            }

            comboBoxtitle.Enabled = false; txbnamesurname.Enabled = false; txbbranch.Enabled = false; comboBoxoffday.Enabled = false; btnsave.Enabled = false; btncancel.Enabled = false;


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                kacinci = bindingSource.Position;
                DialogResult result = MessageBox.Show("Are You Sure You Want To Delete?", "Confirmation window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    command.Parameters.Clear(); // Parametreleri temizle
                    command.Connection = connection;

                    command.CommandText = "DELETE FROM tbl_Lecturer WHERE lecturerID = @lecturerID";
                    command.Parameters.AddWithValue("@lecturerID", txbid.Text);

                    int rs = command.ExecuteNonQuery();
                    // Check if delete was successful
                    if (rs > 0)
                    {
                        MessageBox.Show("Your Registration Has Been Successfully Deleted.", "Information Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    verileriCek();
                    bindingSource.Position = kacinci;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnileri_Click(object sender, EventArgs e)
        {
            
            // İleri butonuna tıklandığında bir sonraki satıra geç
            if (dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
            {
                // Bir sonraki satıra geç ve satırı seçili hale getir
                dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Selected = true;
                bindingSource.Position++;
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            
            // Geri butonuna tıklandığında bir önceki satıra geç
            if (dataGridView1.CurrentRow.Index > 0)
            {
                // Bir önceki satıra geç ve satırı seçili hale getir
                dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Selected = true;
                bindingSource.Position--;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Mevcut verileri saklayın
            oldTitle = comboBoxtitle.Text;
            oldNameSurname = txbnamesurname.Text;
            oldBranch = txbbranch.Text;
            oldOffDay = comboBoxoffday.Text;

            comboBoxtitle.Enabled = true; txbnamesurname.Enabled = true; txbbranch.Enabled = true; comboBoxoffday.Enabled = true; btnsave.Enabled = true; btncancel.Enabled = true;
            newRecord = false;
            kacinci = bindingSource.Position;
            btnsave.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // Mevcut verileri geri yükleyin
            comboBoxtitle.Text = oldTitle;
            txbnamesurname.Text = oldNameSurname;
            txbbranch.Text = oldBranch;
            comboBoxoffday.Text = oldOffDay;

            // Durum değişkenini sıfırlayın (yeni kayıt ekleme durumunu iptal et)
            newRecord = false;

            comboBoxtitle.Enabled = false; txbnamesurname.Enabled = false; txbbranch.Enabled = false; comboBoxoffday.Enabled = false; 
        }
    }
}
