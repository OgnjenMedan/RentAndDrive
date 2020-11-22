namespace RentAndDrive.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.automobiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutneRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.završeneRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvođačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeliAutomobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajModelAutomobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automobiliToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.proizvođačiToolStripMenuItem,
            this.modeliAutomobilaToolStripMenuItem,
            this.radniciToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(772, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // automobiliToolStripMenuItem
            // 
            this.automobiliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.automobiliToolStripMenuItem.Name = "automobiliToolStripMenuItem";
            this.automobiliToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.automobiliToolStripMenuItem.Text = "Automobili";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj automobil";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.klijentiToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trenutneRezervacijeToolStripMenuItem,
            this.završeneRezervacijeToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // trenutneRezervacijeToolStripMenuItem
            // 
            this.trenutneRezervacijeToolStripMenuItem.Name = "trenutneRezervacijeToolStripMenuItem";
            this.trenutneRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.trenutneRezervacijeToolStripMenuItem.Text = "Trenutne rezervacije";
            this.trenutneRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.trenutneRezervacijeToolStripMenuItem_Click);
            // 
            // završeneRezervacijeToolStripMenuItem
            // 
            this.završeneRezervacijeToolStripMenuItem.Name = "završeneRezervacijeToolStripMenuItem";
            this.završeneRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.završeneRezervacijeToolStripMenuItem.Text = "Završene rezervacije";
            this.završeneRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.završeneRezervacijeToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            this.računiToolStripMenuItem.Click += new System.EventHandler(this.računiToolStripMenuItem_Click);
            // 
            // proizvođačiToolStripMenuItem
            // 
            this.proizvođačiToolStripMenuItem.Name = "proizvođačiToolStripMenuItem";
            this.proizvođačiToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.proizvođačiToolStripMenuItem.Text = "Proizvođači";
            this.proizvođačiToolStripMenuItem.Click += new System.EventHandler(this.proizvođačiToolStripMenuItem_Click);
            // 
            // modeliAutomobilaToolStripMenuItem
            // 
            this.modeliAutomobilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.dodajModelAutomobilaToolStripMenuItem});
            this.modeliAutomobilaToolStripMenuItem.Name = "modeliAutomobilaToolStripMenuItem";
            this.modeliAutomobilaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.modeliAutomobilaToolStripMenuItem.Text = "Modeli automobila";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // dodajModelAutomobilaToolStripMenuItem
            // 
            this.dodajModelAutomobilaToolStripMenuItem.Name = "dodajModelAutomobilaToolStripMenuItem";
            this.dodajModelAutomobilaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dodajModelAutomobilaToolStripMenuItem.Text = "Dodaj model automobila";
            this.dodajModelAutomobilaToolStripMenuItem.Click += new System.EventHandler(this.dodajModelAutomobilaToolStripMenuItem_Click);
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.dodajRadnikaToolStripMenuItem});
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.radniciToolStripMenuItem.Text = "Radnici";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // dodajRadnikaToolStripMenuItem
            // 
            this.dodajRadnikaToolStripMenuItem.Name = "dodajRadnikaToolStripMenuItem";
            this.dodajRadnikaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dodajRadnikaToolStripMenuItem.Text = "Dodaj radnika";
            this.dodajRadnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajRadnikaToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            this.izvještajiToolStripMenuItem.Click += new System.EventHandler(this.izvještajiToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 616);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(772, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 638);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent And Drive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem automobiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeliAutomobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvođačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dodajModelAutomobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenutneRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem završeneRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
    }
}



