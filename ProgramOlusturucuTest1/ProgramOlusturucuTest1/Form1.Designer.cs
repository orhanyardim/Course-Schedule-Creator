
namespace ProgramOlusturucuTest1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxperson = new System.Windows.Forms.PictureBox();
            this.pictureBoxlecture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnaddperson = new System.Windows.Forms.Button();
            this.btnaddlecture = new System.Windows.Forms.Button();
            this.btnaddanalyze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxperson
            // 
            this.pictureBoxperson.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxperson.Image")));
            this.pictureBoxperson.Location = new System.Drawing.Point(49, 63);
            this.pictureBoxperson.Name = "pictureBoxperson";
            this.pictureBoxperson.Size = new System.Drawing.Size(140, 125);
            this.pictureBoxperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxperson.TabIndex = 0;
            this.pictureBoxperson.TabStop = false;
            // 
            // pictureBoxlecture
            // 
            this.pictureBoxlecture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlecture.Image")));
            this.pictureBoxlecture.Location = new System.Drawing.Point(248, 63);
            this.pictureBoxlecture.Name = "pictureBoxlecture";
            this.pictureBoxlecture.Size = new System.Drawing.Size(140, 125);
            this.pictureBoxlecture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlecture.TabIndex = 1;
            this.pictureBoxlecture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnaddperson
            // 
            this.btnaddperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddperson.Location = new System.Drawing.Point(49, 208);
            this.btnaddperson.Name = "btnaddperson";
            this.btnaddperson.Size = new System.Drawing.Size(140, 54);
            this.btnaddperson.TabIndex = 5;
            this.btnaddperson.Text = "Add Lecturer";
            this.btnaddperson.UseVisualStyleBackColor = true;
            this.btnaddperson.Click += new System.EventHandler(this.btnaddperson_Click);
            // 
            // btnaddlecture
            // 
            this.btnaddlecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddlecture.Location = new System.Drawing.Point(248, 208);
            this.btnaddlecture.Name = "btnaddlecture";
            this.btnaddlecture.Size = new System.Drawing.Size(140, 54);
            this.btnaddlecture.TabIndex = 6;
            this.btnaddlecture.Text = "Add Lecture";
            this.btnaddlecture.UseVisualStyleBackColor = true;
            this.btnaddlecture.Click += new System.EventHandler(this.btnaddlecture_Click);
            // 
            // btnaddanalyze
            // 
            this.btnaddanalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddanalyze.Location = new System.Drawing.Point(447, 208);
            this.btnaddanalyze.Name = "btnaddanalyze";
            this.btnaddanalyze.Size = new System.Drawing.Size(140, 54);
            this.btnaddanalyze.TabIndex = 7;
            this.btnaddanalyze.Text = "See Analyze";
            this.btnaddanalyze.UseVisualStyleBackColor = true;
            this.btnaddanalyze.Click += new System.EventHandler(this.btnaddanalyze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(632, 336);
            this.Controls.Add(this.btnaddanalyze);
            this.Controls.Add(this.btnaddlecture);
            this.Controls.Add(this.btnaddperson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxlecture);
            this.Controls.Add(this.pictureBoxperson);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Creators Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxperson;
        private System.Windows.Forms.PictureBox pictureBoxlecture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnaddperson;
        private System.Windows.Forms.Button btnaddlecture;
        private System.Windows.Forms.Button btnaddanalyze;
    }
}