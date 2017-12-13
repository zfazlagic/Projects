namespace _2Zadaca17220
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchelorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brisiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.uposleniciToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(77, 741);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.obrisiToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.studentiToolStripMenuItem.Text = "Studenti";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchelorToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj studenta";
            // 
            // batchelorToolStripMenuItem
            // 
            this.batchelorToolStripMenuItem.Name = "batchelorToolStripMenuItem";
            this.batchelorToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.batchelorToolStripMenuItem.Text = "Batchelor";
            this.batchelorToolStripMenuItem.Click += new System.EventHandler(this.batchelorToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.obrisiToolStripMenuItem.Text = "Obrisi studenta";
            this.obrisiToolStripMenuItem.Click += new System.EventHandler(this.obrisiToolStripMenuItem_Click);
            // 
            // uposleniciToolStripMenuItem
            // 
            this.uposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.brisiToolStripMenuItem,
            this.brisiToolStripMenuItem1});
            this.uposleniciToolStripMenuItem.Name = "uposleniciToolStripMenuItem";
            this.uposleniciToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.uposleniciToolStripMenuItem.Text = "Uposlenici";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj nastavno osoblje";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // brisiToolStripMenuItem
            // 
            this.brisiToolStripMenuItem.Name = "brisiToolStripMenuItem";
            this.brisiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.brisiToolStripMenuItem.Text = "Dodaj nenastavno osoblje";
            this.brisiToolStripMenuItem.Click += new System.EventHandler(this.brisiToolStripMenuItem_Click);
            // 
            // brisiToolStripMenuItem1
            // 
            this.brisiToolStripMenuItem1.Name = "brisiToolStripMenuItem1";
            this.brisiToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.brisiToolStripMenuItem1.Text = "Obrisi uposlenog";
            this.brisiToolStripMenuItem1.Click += new System.EventHandler(this.brisiToolStripMenuItem1_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem2,
            this.brisiToolStripMenuItem2});
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            // 
            // dodajToolStripMenuItem2
            // 
            this.dodajToolStripMenuItem2.Name = "dodajToolStripMenuItem2";
            this.dodajToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.dodajToolStripMenuItem2.Text = "Dodaj predmet ";
            this.dodajToolStripMenuItem2.Click += new System.EventHandler(this.dodajToolStripMenuItem2_Click);
            // 
            // brisiToolStripMenuItem2
            // 
            this.brisiToolStripMenuItem2.Name = "brisiToolStripMenuItem2";
            this.brisiToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.brisiToolStripMenuItem2.Text = "Obrisi predmet";
            this.brisiToolStripMenuItem2.Click += new System.EventHandler(this.brisiToolStripMenuItem2_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Administracija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchelorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem brisiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
    }
}

