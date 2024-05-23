
namespace ProgramOlusturucuTest1
{
    partial class Form3
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
            this.gbislemler = new System.Windows.Forms.GroupBox();
            this.comboBoxlecturer = new System.Windows.Forms.ComboBox();
            this.comboBoxterm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txblecturename = new System.Windows.Forms.TextBox();
            this.txblecturecode = new System.Windows.Forms.TextBox();
            this.gbciktilar = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbislemler.SuspendLayout();
            this.gbciktilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbislemler
            // 
            this.gbislemler.BackColor = System.Drawing.Color.White;
            this.gbislemler.Controls.Add(this.comboBoxlecturer);
            this.gbislemler.Controls.Add(this.comboBoxterm);
            this.gbislemler.Controls.Add(this.label1);
            this.gbislemler.Controls.Add(this.lblbranch);
            this.gbislemler.Controls.Add(this.lblname);
            this.gbislemler.Controls.Add(this.lbltitle);
            this.gbislemler.Controls.Add(this.btnsave);
            this.gbislemler.Controls.Add(this.txblecturename);
            this.gbislemler.Controls.Add(this.txblecturecode);
            this.gbislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbislemler.Location = new System.Drawing.Point(12, 12);
            this.gbislemler.Name = "gbislemler";
            this.gbislemler.Size = new System.Drawing.Size(396, 477);
            this.gbislemler.TabIndex = 4;
            this.gbislemler.TabStop = false;
            this.gbislemler.Text = "Operations";
            // 
            // comboBoxlecturer
            // 
            this.comboBoxlecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxlecturer.FormattingEnabled = true;
            this.comboBoxlecturer.Items.AddRange(new object[] {
            "Orhan",
            "Tuğçe",
            "Kemal",
            "Ali Burak"});
            this.comboBoxlecturer.Location = new System.Drawing.Point(20, 301);
            this.comboBoxlecturer.Name = "comboBoxlecturer";
            this.comboBoxlecturer.Size = new System.Drawing.Size(352, 28);
            this.comboBoxlecturer.TabIndex = 10;
            this.comboBoxlecturer.Text = "Choose";
            // 
            // comboBoxterm
            // 
            this.comboBoxterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxterm.FormattingEnabled = true;
            this.comboBoxterm.Items.AddRange(new object[] {
            "1. Dönem",
            "2. Dönem",
            "3. Dönem",
            "4. Dönem",
            "5. Dönem",
            "6. Dönem",
            "7. Dönem",
            "8. Dönem"});
            this.comboBoxterm.Location = new System.Drawing.Point(20, 229);
            this.comboBoxterm.Name = "comboBoxterm";
            this.comboBoxterm.Size = new System.Drawing.Size(352, 28);
            this.comboBoxterm.TabIndex = 9;
            this.comboBoxterm.Text = "Choose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lecturer ";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbranch.Location = new System.Drawing.Point(16, 193);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(47, 18);
            this.lblbranch.TabIndex = 6;
            this.lblbranch.Text = "Term";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(16, 123);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(113, 18);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Lecture Name";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitle.Location = new System.Drawing.Point(16, 53);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(109, 18);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Lecture Code";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(105, 354);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(168, 45);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txblecturename
            // 
            this.txblecturename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txblecturename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txblecturename.Location = new System.Drawing.Point(20, 155);
            this.txblecturename.Name = "txblecturename";
            this.txblecturename.Size = new System.Drawing.Size(352, 26);
            this.txblecturename.TabIndex = 1;
            // 
            // txblecturecode
            // 
            this.txblecturecode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txblecturecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txblecturecode.Location = new System.Drawing.Point(20, 85);
            this.txblecturecode.Name = "txblecturecode";
            this.txblecturecode.Size = new System.Drawing.Size(352, 26);
            this.txblecturecode.TabIndex = 0;
            // 
            // gbciktilar
            // 
            this.gbciktilar.BackColor = System.Drawing.Color.White;
            this.gbciktilar.Controls.Add(this.listView1);
            this.gbciktilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbciktilar.Location = new System.Drawing.Point(431, 12);
            this.gbciktilar.Name = "gbciktilar";
            this.gbciktilar.Size = new System.Drawing.Size(687, 477);
            this.gbciktilar.TabIndex = 5;
            this.gbciktilar.TabStop = false;
            this.gbciktilar.Text = "Screen Outputs";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 438);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1136, 506);
            this.Controls.Add(this.gbislemler);
            this.Controls.Add(this.gbciktilar);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.gbislemler.ResumeLayout(false);
            this.gbislemler.PerformLayout();
            this.gbciktilar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbislemler;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txblecturename;
        private System.Windows.Forms.TextBox txblecturecode;
        private System.Windows.Forms.GroupBox gbciktilar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxlecturer;
        private System.Windows.Forms.ComboBox comboBoxterm;
    }
}