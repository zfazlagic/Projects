namespace _2Zadaca17220
{
    partial class DodajMastera
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
            this.prezimeB = new System.Windows.Forms.GroupBox();
            this.maticniM = new System.Windows.Forms.TextBox();
            this.datumRM = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imeM = new System.Windows.Forms.TextBox();
            this.prezimeM = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brojPM = new System.Windows.Forms.NumericUpDown();
            this.DatumUpM = new System.Windows.Forms.DateTimePicker();
            this.datumZavM = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mjesto = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.greskamaticni = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonNe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datumProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Predmeti = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.slika1 = new _2Zadaca17220.Slika();
            this.prezimeB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojPM)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumProvider2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Predmeti.SuspendLayout();
            this.SuspendLayout();
            // 
            // prezimeB
            // 
            this.prezimeB.Controls.Add(this.maticniM);
            this.prezimeB.Controls.Add(this.datumRM);
            this.prezimeB.Controls.Add(this.label4);
            this.prezimeB.Controls.Add(this.label3);
            this.prezimeB.Controls.Add(this.label2);
            this.prezimeB.Controls.Add(this.label1);
            this.prezimeB.Controls.Add(this.imeM);
            this.prezimeB.Controls.Add(this.prezimeM);
            this.prezimeB.Location = new System.Drawing.Point(1, 3);
            this.prezimeB.Name = "prezimeB";
            this.prezimeB.Size = new System.Drawing.Size(274, 148);
            this.prezimeB.TabIndex = 0;
            this.prezimeB.TabStop = false;
            this.prezimeB.Text = "Podaci o studentu";
            // 
            // maticniM
            // 
            this.maticniM.Location = new System.Drawing.Point(105, 102);
            this.maticniM.Name = "maticniM";
            this.maticniM.Size = new System.Drawing.Size(142, 20);
            this.maticniM.TabIndex = 7;
            this.maticniM.Validating += new System.ComponentModel.CancelEventHandler(this.maticniM_Validating);
            // 
            // datumRM
            // 
            this.datumRM.Location = new System.Drawing.Point(105, 75);
            this.datumRM.Name = "datumRM";
            this.datumRM.Size = new System.Drawing.Size(142, 20);
            this.datumRM.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum rodjenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maticni broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime studenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prezime studenta";
            // 
            // imeM
            // 
            this.imeM.Location = new System.Drawing.Point(105, 19);
            this.imeM.Name = "imeM";
            this.imeM.Size = new System.Drawing.Size(142, 20);
            this.imeM.TabIndex = 1;
            this.imeM.Validating += new System.ComponentModel.CancelEventHandler(this.imeM_Validating);
            // 
            // prezimeM
            // 
            this.prezimeM.Location = new System.Drawing.Point(105, 49);
            this.prezimeM.Name = "prezimeM";
            this.prezimeM.Size = new System.Drawing.Size(142, 20);
            this.prezimeM.TabIndex = 0;
            this.prezimeM.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeM_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brojPM);
            this.groupBox2.Controls.Add(this.DatumUpM);
            this.groupBox2.Controls.Add(this.datumZavM);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o obrazovanju";
            // 
            // brojPM
            // 
            this.brojPM.Location = new System.Drawing.Point(268, 80);
            this.brojPM.Name = "brojPM";
            this.brojPM.Size = new System.Drawing.Size(132, 20);
            this.brojPM.TabIndex = 10;
            // 
            // DatumUpM
            // 
            this.DatumUpM.Location = new System.Drawing.Point(217, 53);
            this.DatumUpM.Name = "DatumUpM";
            this.DatumUpM.Size = new System.Drawing.Size(183, 20);
            this.DatumUpM.TabIndex = 8;
            // 
            // datumZavM
            // 
            this.datumZavM.Location = new System.Drawing.Point(217, 27);
            this.datumZavM.Name = "datumZavM";
            this.datumZavM.Size = new System.Drawing.Size(183, 20);
            this.datumZavM.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Broj polozenih predmeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Datum upisa na studij";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum zavrsetka prethodnog obrazovanja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mjesto zavrsetka prethodnog studija";
            this.label8.Visible = false;
            // 
            // mjesto
            // 
            this.mjesto.Location = new System.Drawing.Point(484, 296);
            this.mjesto.Name = "mjesto";
            this.mjesto.Size = new System.Drawing.Size(143, 20);
            this.mjesto.TabIndex = 7;
            this.mjesto.Visible = false;
            this.mjesto.Validating += new System.ComponentModel.CancelEventHandler(this.mjesto_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.greskamaticni});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // greskamaticni
            // 
            this.greskamaticni.Name = "greskamaticni";
            this.greskamaticni.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonNe
            // 
            this.radioButtonNe.AutoSize = true;
            this.radioButtonNe.Location = new System.Drawing.Point(9, 65);
            this.radioButtonNe.Name = "radioButtonNe";
            this.radioButtonNe.Size = new System.Drawing.Size(121, 17);
            this.radioButtonNe.TabIndex = 6;
            this.radioButtonNe.TabStop = true;
            this.radioButtonNe.Text = "Na drugom fakultetu";
            this.radioButtonNe.UseVisualStyleBackColor = true;
            this.radioButtonNe.CheckedChanged += new System.EventHandler(this.radioButtonNe_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDa);
            this.groupBox1.Controls.Add(this.radioButtonNe);
            this.groupBox1.Location = new System.Drawing.Point(470, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zavrsetak predhodnog studija";
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Location = new System.Drawing.Point(9, 32);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(131, 17);
            this.radioButtonDa.TabIndex = 7;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "Na maticnom fakultetu";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // datumProvider2
            // 
            this.datumProvider2.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.password);
            this.groupBox3.Controls.Add(this.username);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(1, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 109);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login podaci";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(78, 64);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(139, 20);
            this.password.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(78, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(139, 20);
            this.username.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username";
            // 
            // Predmeti
            // 
            this.Predmeti.Controls.Add(this.checkedListBox2);
            this.Predmeti.Controls.Add(this.label12);
            this.Predmeti.Controls.Add(this.label11);
            this.Predmeti.Controls.Add(this.checkedListBox1);
            this.Predmeti.Location = new System.Drawing.Point(470, 3);
            this.Predmeti.Name = "Predmeti";
            this.Predmeti.Size = new System.Drawing.Size(244, 148);
            this.Predmeti.TabIndex = 10;
            this.Predmeti.TabStop = false;
            this.Predmeti.Text = "Predmeti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Upisi na predmet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Polozeni";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(109, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(114, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(109, 75);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(114, 64);
            this.checkedListBox2.TabIndex = 3;
            // 
            // slika1
            // 
            this.slika1.Location = new System.Drawing.Point(298, 3);
            this.slika1.Name = "slika1";
            this.slika1.Size = new System.Drawing.Size(166, 148);
            this.slika1.TabIndex = 9;
            // 
            // DodajMastera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 426);
            this.Controls.Add(this.Predmeti);
            this.Controls.Add(this.mjesto);
            this.Controls.Add(this.slika1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.prezimeB);
            this.Name = "DodajMastera";
            this.Text = "DodajMastera";
            this.Load += new System.EventHandler(this.DodajMastera_Load);
            this.prezimeB.ResumeLayout(false);
            this.prezimeB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brojPM)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumProvider2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Predmeti.ResumeLayout(false);
            this.Predmeti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox prezimeB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeM;
        private System.Windows.Forms.TextBox prezimeM;
        private System.Windows.Forms.TextBox maticniM;
        private System.Windows.Forms.DateTimePicker datumRM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatumUpM;
        private System.Windows.Forms.DateTimePicker datumZavM;
        private System.Windows.Forms.NumericUpDown brojPM;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mjesto;
        private System.Windows.Forms.RadioButton radioButtonNe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripStatusLabel greskamaticni;
        private System.Windows.Forms.ErrorProvider datumProvider2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Slika slika1;
        private System.Windows.Forms.GroupBox Predmeti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}