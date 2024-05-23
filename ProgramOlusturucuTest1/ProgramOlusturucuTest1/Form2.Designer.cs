
namespace ProgramOlusturucuTest1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbislemler = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txbid = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnnewrecord = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.comboBoxoffday = new System.Windows.Forms.ComboBox();
            this.lblday = new System.Windows.Forms.Label();
            this.comboBoxtitle = new System.Windows.Forms.ComboBox();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txbbranch = new System.Windows.Forms.TextBox();
            this.txbnamesurname = new System.Windows.Forms.TextBox();
            this.gbciktilar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnileri = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.gbislemler.SuspendLayout();
            this.gbciktilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbislemler
            // 
            this.gbislemler.BackColor = System.Drawing.Color.White;
            this.gbislemler.Controls.Add(this.lblid);
            this.gbislemler.Controls.Add(this.txbid);
            this.gbislemler.Controls.Add(this.btncancel);
            this.gbislemler.Controls.Add(this.btnupdate);
            this.gbislemler.Controls.Add(this.btnnewrecord);
            this.gbislemler.Controls.Add(this.btndelete);
            this.gbislemler.Controls.Add(this.comboBoxoffday);
            this.gbislemler.Controls.Add(this.lblday);
            this.gbislemler.Controls.Add(this.comboBoxtitle);
            this.gbislemler.Controls.Add(this.lblbranch);
            this.gbislemler.Controls.Add(this.lblname);
            this.gbislemler.Controls.Add(this.lbltitle);
            this.gbislemler.Controls.Add(this.btnsave);
            this.gbislemler.Controls.Add(this.txbbranch);
            this.gbislemler.Controls.Add(this.txbnamesurname);
            this.gbislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbislemler.Location = new System.Drawing.Point(12, 23);
            this.gbislemler.Name = "gbislemler";
            this.gbislemler.Size = new System.Drawing.Size(396, 529);
            this.gbislemler.TabIndex = 2;
            this.gbislemler.TabStop = false;
            this.gbislemler.Text = "Operations";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(16, 36);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 18);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "Lecturer ID";
            // 
            // txbid
            // 
            this.txbid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbid.Enabled = false;
            this.txbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbid.Location = new System.Drawing.Point(19, 64);
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(352, 26);
            this.txbid.TabIndex = 15;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncancel.Location = new System.Drawing.Point(201, 415);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(134, 42);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(32, 415);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(134, 42);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnnewrecord
            // 
            this.btnnewrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnewrecord.Location = new System.Drawing.Point(32, 367);
            this.btnnewrecord.Name = "btnnewrecord";
            this.btnnewrecord.Size = new System.Drawing.Size(134, 42);
            this.btnnewrecord.TabIndex = 12;
            this.btnnewrecord.Text = "New Record";
            this.btnnewrecord.UseVisualStyleBackColor = true;
            this.btnnewrecord.Click += new System.EventHandler(this.btnnewrecord_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(32, 463);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(134, 42);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // comboBoxoffday
            // 
            this.comboBoxoffday.FormattingEnabled = true;
            this.comboBoxoffday.Items.AddRange(new object[] {
            "Choose",
            "Pazartesi",
            "Salı ",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.comboBoxoffday.Location = new System.Drawing.Point(19, 320);
            this.comboBoxoffday.Name = "comboBoxoffday";
            this.comboBoxoffday.Size = new System.Drawing.Size(352, 26);
            this.comboBoxoffday.TabIndex = 9;
            this.comboBoxoffday.Text = "Choose";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblday.Location = new System.Drawing.Point(16, 292);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(65, 18);
            this.lblday.TabIndex = 8;
            this.lblday.Text = "Off Day";
            // 
            // comboBoxtitle
            // 
            this.comboBoxtitle.FormattingEnabled = true;
            this.comboBoxtitle.Items.AddRange(new object[] {
            "Choose",
            "Arş. Gör.",
            "Dr. Öğr. Üyesi",
            "Yrd. Doç. Dr.",
            "Doç. Dr.",
            "Prof. Dr. "});
            this.comboBoxtitle.Location = new System.Drawing.Point(19, 128);
            this.comboBoxtitle.Name = "comboBoxtitle";
            this.comboBoxtitle.Size = new System.Drawing.Size(352, 26);
            this.comboBoxtitle.TabIndex = 7;
            this.comboBoxtitle.Text = "Choose";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbranch.Location = new System.Drawing.Point(16, 228);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(61, 18);
            this.lblbranch.TabIndex = 6;
            this.lblbranch.Text = "Branch";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(16, 164);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(135, 18);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Name - Surname";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitle.Location = new System.Drawing.Point(16, 100);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(40, 18);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Title";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(201, 367);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 42);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txbbranch
            // 
            this.txbbranch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbbranch.Location = new System.Drawing.Point(19, 256);
            this.txbbranch.Name = "txbbranch";
            this.txbbranch.Size = new System.Drawing.Size(352, 26);
            this.txbbranch.TabIndex = 2;
            // 
            // txbnamesurname
            // 
            this.txbnamesurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbnamesurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbnamesurname.Location = new System.Drawing.Point(19, 192);
            this.txbnamesurname.Name = "txbnamesurname";
            this.txbnamesurname.Size = new System.Drawing.Size(352, 26);
            this.txbnamesurname.TabIndex = 1;
            // 
            // gbciktilar
            // 
            this.gbciktilar.BackColor = System.Drawing.Color.White;
            this.gbciktilar.Controls.Add(this.dataGridView1);
            this.gbciktilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbciktilar.Location = new System.Drawing.Point(457, 23);
            this.gbciktilar.Name = "gbciktilar";
            this.gbciktilar.Size = new System.Drawing.Size(859, 529);
            this.gbciktilar.TabIndex = 3;
            this.gbciktilar.TabStop = false;
            this.gbciktilar.Text = "Screen Outputs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnileri
            // 
            this.btnileri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnileri.BackgroundImage")));
            this.btnileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnileri.Location = new System.Drawing.Point(412, 294);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(42, 58);
            this.btnileri.TabIndex = 4;
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btngeri.Location = new System.Drawing.Point(412, 230);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(42, 58);
            this.btngeri.TabIndex = 5;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1328, 564);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnileri);
            this.Controls.Add(this.gbislemler);
            this.Controls.Add(this.gbciktilar);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer Addition Area";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbislemler.ResumeLayout(false);
            this.gbislemler.PerformLayout();
            this.gbciktilar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbislemler;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txbbranch;
        private System.Windows.Forms.TextBox txbnamesurname;
        private System.Windows.Forms.GroupBox gbciktilar;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox comboBoxtitle;
        private System.Windows.Forms.ComboBox comboBoxoffday;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnewrecord;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txbid;
    }
}