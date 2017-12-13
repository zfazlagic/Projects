namespace _2Zadaca17220
{
    partial class DodajBatchelora
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datumRodj = new System.Windows.Forms.DateTimePicker();
            this.maticni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prezimeB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imeB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datumUp = new System.Windows.Forms.DateTimePicker();
            this.datumZav = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.novi = new System.Windows.Forms.CheckedListBox();
            this.polozeni = new System.Windows.Forms.CheckedListBox();
            this.upisi = new System.Windows.Forms.Label();
            this.polozenipredmet = new System.Windows.Forms.Label();
            this.slika1 = new _2Zadaca17220.Slika();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime studenta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datumRodj);
            this.groupBox1.Controls.Add(this.maticni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prezimeB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imeB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o studentu";
            // 
            // datumRodj
            // 
            this.datumRodj.Location = new System.Drawing.Point(177, 76);
            this.datumRodj.Name = "datumRodj";
            this.datumRodj.Size = new System.Drawing.Size(152, 20);
            this.datumRodj.TabIndex = 9;
            // 
            // maticni
            // 
            this.maticni.Location = new System.Drawing.Point(177, 102);
            this.maticni.Name = "maticni";
            this.maticni.Size = new System.Drawing.Size(152, 20);
            this.maticni.TabIndex = 8;
            this.maticni.Validating += new System.ComponentModel.CancelEventHandler(this.maticni_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maticni broj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rodjenja (dd.mm.yyyy)";
            // 
            // prezimeB
            // 
            this.prezimeB.Location = new System.Drawing.Point(177, 51);
            this.prezimeB.Name = "prezimeB";
            this.prezimeB.Size = new System.Drawing.Size(152, 20);
            this.prezimeB.TabIndex = 4;
            this.prezimeB.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeB_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime studenta";
            // 
            // imeB
            // 
            this.imeB.Location = new System.Drawing.Point(177, 22);
            this.imeB.Name = "imeB";
            this.imeB.Size = new System.Drawing.Size(152, 20);
            this.imeB.TabIndex = 2;
            this.imeB.Validating += new System.ComponentModel.CancelEventHandler(this.imeB_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datumUp);
            this.groupBox2.Controls.Add(this.datumZav);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(3, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o obrazovanju";
            // 
            // datumUp
            // 
            this.datumUp.Location = new System.Drawing.Point(209, 58);
            this.datumUp.Name = "datumUp";
            this.datumUp.Size = new System.Drawing.Size(120, 20);
            this.datumUp.TabIndex = 9;
            // 
            // datumZav
            // 
            this.datumZav.Location = new System.Drawing.Point(209, 29);
            this.datumZav.Name = "datumZav";
            this.datumZav.Size = new System.Drawing.Size(120, 20);
            this.datumZav.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 85);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Broj polozenih predmeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Datum upisa na studij";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum zavrsetka prethodnog obrazovanja";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(3, 368);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(106, 32);
            this.dodaj.TabIndex = 3;
            this.dodaj.Text = "Spasi u binarnu";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(366, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Godina studija";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(34, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "III";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "II";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(28, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "I";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.password);
            this.groupBox4.Controls.Add(this.username);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(3, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 81);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login podaci";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(177, 39);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(152, 20);
            this.password.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(177, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(152, 20);
            this.username.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.novi);
            this.groupBox5.Controls.Add(this.polozeni);
            this.groupBox5.Controls.Add(this.upisi);
            this.groupBox5.Controls.Add(this.polozenipredmet);
            this.groupBox5.Location = new System.Drawing.Point(366, 281);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 125);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Predmeti";
            this.groupBox5.Visible = false;
            // 
            // novi
            // 
            this.novi.FormattingEnabled = true;
            this.novi.Location = new System.Drawing.Point(116, 70);
            this.novi.Name = "novi";
            this.novi.Size = new System.Drawing.Size(120, 49);
            this.novi.TabIndex = 14;
            // 
            // polozeni
            // 
            this.polozeni.FormattingEnabled = true;
            this.polozeni.Location = new System.Drawing.Point(116, 10);
            this.polozeni.Name = "polozeni";
            this.polozeni.Size = new System.Drawing.Size(120, 49);
            this.polozeni.TabIndex = 13;
            // 
            // upisi
            // 
            this.upisi.AutoSize = true;
            this.upisi.Location = new System.Drawing.Point(8, 84);
            this.upisi.Name = "upisi";
            this.upisi.Size = new System.Drawing.Size(92, 13);
            this.upisi.TabIndex = 12;
            this.upisi.Text = "Upisi na predmete";
            // 
            // polozenipredmet
            // 
            this.polozenipredmet.AutoSize = true;
            this.polozenipredmet.Location = new System.Drawing.Point(6, 23);
            this.polozenipredmet.Name = "polozenipredmet";
            this.polozenipredmet.Size = new System.Drawing.Size(90, 13);
            this.polozenipredmet.TabIndex = 11;
            this.polozenipredmet.Text = "Polozeni predmeti";
            // 
            // slika1
            // 
            this.slika1.Location = new System.Drawing.Point(377, 2);
            this.slika1.Name = "slika1";
            this.slika1.Size = new System.Drawing.Size(166, 147);
            this.slika1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Spasi u bazu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Spasi kao XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DodajBatchelora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.slika1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajBatchelora";
            this.Text = "DodajBatchelora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajBatchelora_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajBatchelora_FormClosed);
            this.Load += new System.EventHandler(this.DodajBatchelora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prezimeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeB;
        private System.Windows.Forms.TextBox maticni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker datumRodj;
        private System.Windows.Forms.DateTimePicker datumUp;
        private System.Windows.Forms.DateTimePicker datumZav;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Slika slika1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox novi;
        private System.Windows.Forms.CheckedListBox polozeni;
        private System.Windows.Forms.Label upisi;
        private System.Windows.Forms.Label polozenipredmet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}