namespace _2Zadaca17220
{
    partial class DodajPredmet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownECTS = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPredavanja = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVjezbe = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonDrugi = new System.Windows.Forms.RadioButton();
            this.radioButtonPrvi = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonIII = new System.Windows.Forms.RadioButton();
            this.radioButtonII = new System.Windows.Forms.RadioButton();
            this.radioButtonI = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownECTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredavanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVjezbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOpis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownECTS);
            this.groupBox1.Controls.Add(this.numericUpDownMax);
            this.groupBox1.Controls.Add(this.numericUpDownPredavanja);
            this.groupBox1.Controls.Add(this.numericUpDownVjezbe);
            this.groupBox1.Controls.Add(this.numericUpDownID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxime);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o predmetu";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(6, 210);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(297, 89);
            this.textBoxOpis.TabIndex = 1;
            this.textBoxOpis.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOpis_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kratak opis predmeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maksimalan broj studenata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Broj predavanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj vjezbi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj ECTS bodova";
            // 
            // numericUpDownECTS
            // 
            this.numericUpDownECTS.Location = new System.Drawing.Point(183, 72);
            this.numericUpDownECTS.Name = "numericUpDownECTS";
            this.numericUpDownECTS.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownECTS.TabIndex = 8;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(183, 156);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 7;
            // 
            // numericUpDownPredavanja
            // 
            this.numericUpDownPredavanja.Location = new System.Drawing.Point(183, 124);
            this.numericUpDownPredavanja.Name = "numericUpDownPredavanja";
            this.numericUpDownPredavanja.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPredavanja.TabIndex = 6;
            // 
            // numericUpDownVjezbe
            // 
            this.numericUpDownVjezbe.Location = new System.Drawing.Point(183, 98);
            this.numericUpDownVjezbe.Name = "numericUpDownVjezbe";
            this.numericUpDownVjezbe.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownVjezbe.TabIndex = 5;
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(183, 45);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID predmeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime predmeta";
            // 
            // textBoxime
            // 
            this.textBoxime.Location = new System.Drawing.Point(130, 19);
            this.textBoxime.Name = "textBoxime";
            this.textBoxime.Size = new System.Drawing.Size(173, 20);
            this.textBoxime.TabIndex = 0;
            this.textBoxime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxime_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj u binarnu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(337, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nastavni ansambl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Odaberite pomocno osoblje";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Odaberite profesora";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonDrugi);
            this.groupBox3.Controls.Add(this.radioButtonPrvi);
            this.groupBox3.Location = new System.Drawing.Point(337, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 83);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciklus";
            // 
            // radioButtonDrugi
            // 
            this.radioButtonDrugi.AutoSize = true;
            this.radioButtonDrugi.Location = new System.Drawing.Point(3, 42);
            this.radioButtonDrugi.Name = "radioButtonDrugi";
            this.radioButtonDrugi.Size = new System.Drawing.Size(50, 17);
            this.radioButtonDrugi.TabIndex = 1;
            this.radioButtonDrugi.TabStop = true;
            this.radioButtonDrugi.Text = "Drugi";
            this.radioButtonDrugi.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrvi
            // 
            this.radioButtonPrvi.AutoSize = true;
            this.radioButtonPrvi.Location = new System.Drawing.Point(3, 19);
            this.radioButtonPrvi.Name = "radioButtonPrvi";
            this.radioButtonPrvi.Size = new System.Drawing.Size(43, 17);
            this.radioButtonPrvi.TabIndex = 0;
            this.radioButtonPrvi.TabStop = true;
            this.radioButtonPrvi.Text = "Prvi";
            this.radioButtonPrvi.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonIII);
            this.groupBox4.Controls.Add(this.radioButtonII);
            this.groupBox4.Controls.Add(this.radioButtonI);
            this.groupBox4.Location = new System.Drawing.Point(463, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 82);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Godina";
            // 
            // radioButtonIII
            // 
            this.radioButtonIII.AutoSize = true;
            this.radioButtonIII.Location = new System.Drawing.Point(6, 59);
            this.radioButtonIII.Name = "radioButtonIII";
            this.radioButtonIII.Size = new System.Drawing.Size(34, 17);
            this.radioButtonIII.TabIndex = 2;
            this.radioButtonIII.TabStop = true;
            this.radioButtonIII.Text = "III";
            this.radioButtonIII.UseVisualStyleBackColor = true;
            // 
            // radioButtonII
            // 
            this.radioButtonII.AutoSize = true;
            this.radioButtonII.Location = new System.Drawing.Point(6, 36);
            this.radioButtonII.Name = "radioButtonII";
            this.radioButtonII.Size = new System.Drawing.Size(31, 17);
            this.radioButtonII.TabIndex = 1;
            this.radioButtonII.TabStop = true;
            this.radioButtonII.Text = "II";
            this.radioButtonII.UseVisualStyleBackColor = true;
            // 
            // radioButtonI
            // 
            this.radioButtonI.AutoSize = true;
            this.radioButtonI.Location = new System.Drawing.Point(6, 13);
            this.radioButtonI.Name = "radioButtonI";
            this.radioButtonI.Size = new System.Drawing.Size(28, 17);
            this.radioButtonI.TabIndex = 0;
            this.radioButtonI.TabStop = true;
            this.radioButtonI.Text = "I";
            this.radioButtonI.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dodaj u bazu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DodajPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajPredmet";
            this.Text = "DodajPredmet";
            this.Load += new System.EventHandler(this.DodajPredmet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownECTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredavanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVjezbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownECTS;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownPredavanja;
        private System.Windows.Forms.NumericUpDown numericUpDownVjezbe;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxime;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonDrugi;
        private System.Windows.Forms.RadioButton radioButtonPrvi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonIII;
        private System.Windows.Forms.RadioButton radioButtonII;
        private System.Windows.Forms.RadioButton radioButtonI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
    }
}