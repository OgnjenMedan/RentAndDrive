namespace RentAndDrive.WinUI.Racuni
{
    partial class frmRacuni
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.RacunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranjaRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Automobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrajanjeRerezvacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosRezervacijeAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Broj racuna";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(15, 43);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.Size = new System.Drawing.Size(159, 20);
            this.txtBrojRacuna.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Korisnicko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(197, 43);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(159, 20);
            this.txtKorisnickoIme.TabIndex = 17;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(844, 43);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRacuni);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 339);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Računi";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RacunId,
            this.KorisnickoIme,
            this.BrojRacuna,
            this.DatumKreiranjaRacuna,
            this.Automobil,
            this.TrajanjeRerezvacije,
            this.IznosRezervacijeAutomobila,
            this.Pdv,
            this.IznosSaPdv,
            this.Status});
            this.dgvRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuni.Location = new System.Drawing.Point(3, 16);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(904, 320);
            this.dgvRacuni.TabIndex = 0;
            // 
            // RacunId
            // 
            this.RacunId.DataPropertyName = "RacunId";
            this.RacunId.HeaderText = "RacunId";
            this.RacunId.Name = "RacunId";
            this.RacunId.ReadOnly = true;
            this.RacunId.Visible = false;
            this.RacunId.Width = 73;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Width = 120;
            // 
            // BrojRacuna
            // 
            this.BrojRacuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrojRacuna.DataPropertyName = "BrojRacuna";
            this.BrojRacuna.HeaderText = "Broj racuna";
            this.BrojRacuna.Name = "BrojRacuna";
            this.BrojRacuna.ReadOnly = true;
            this.BrojRacuna.Width = 140;
            // 
            // DatumKreiranjaRacuna
            // 
            this.DatumKreiranjaRacuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatumKreiranjaRacuna.DataPropertyName = "DatumKreiranjaRacuna";
            this.DatumKreiranjaRacuna.HeaderText = "Datum";
            this.DatumKreiranjaRacuna.Name = "DatumKreiranjaRacuna";
            this.DatumKreiranjaRacuna.ReadOnly = true;
            this.DatumKreiranjaRacuna.Width = 90;
            // 
            // Automobil
            // 
            this.Automobil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Automobil.DataPropertyName = "Automobil";
            this.Automobil.HeaderText = "Automobil";
            this.Automobil.Name = "Automobil";
            this.Automobil.ReadOnly = true;
            this.Automobil.Width = 110;
            // 
            // TrajanjeRerezvacije
            // 
            this.TrajanjeRerezvacije.DataPropertyName = "TrajanjeRerezvacije";
            this.TrajanjeRerezvacije.HeaderText = "Broj dana";
            this.TrajanjeRerezvacije.Name = "TrajanjeRerezvacije";
            this.TrajanjeRerezvacije.ReadOnly = true;
            this.TrajanjeRerezvacije.Width = 71;
            // 
            // IznosRezervacijeAutomobila
            // 
            this.IznosRezervacijeAutomobila.DataPropertyName = "IznosRezervacijeAutomobila";
            this.IznosRezervacijeAutomobila.HeaderText = "Cijena iznajmljivanja";
            this.IznosRezervacijeAutomobila.Name = "IznosRezervacijeAutomobila";
            this.IznosRezervacijeAutomobila.ReadOnly = true;
            this.IznosRezervacijeAutomobila.Width = 114;
            // 
            // Pdv
            // 
            this.Pdv.DataPropertyName = "Pdv";
            this.Pdv.HeaderText = "PDV";
            this.Pdv.Name = "Pdv";
            this.Pdv.ReadOnly = true;
            this.Pdv.Width = 54;
            // 
            // IznosSaPdv
            // 
            this.IznosSaPdv.DataPropertyName = "IznosSaPdv";
            this.IznosSaPdv.HeaderText = "Ukupno";
            this.IznosSaPdv.Name = "IznosSaPdv";
            this.IznosSaPdv.ReadOnly = true;
            this.IznosSaPdv.Width = 70;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 62;
            // 
            // frmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRacuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.frmRacuni_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranjaRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrajanjeRerezvacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosRezervacijeAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosSaPdv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}