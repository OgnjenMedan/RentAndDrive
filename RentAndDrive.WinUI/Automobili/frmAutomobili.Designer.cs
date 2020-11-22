namespace RentAndDrive.WinUI.Automobili
{
    partial class frmAutomobili
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.AutomobilId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmisija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojVrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxModeli = new System.Windows.Forms.ComboBox();
            this.cbxProzivodjaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(863, 42);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj automobil";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AllowUserToAddRows = false;
            this.dgvAutomobili.AllowUserToDeleteRows = false;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutomobilId,
            this.Model,
            this.Cijena,
            this.GodinaProizvodnje,
            this.Gorivo,
            this.Snaga,
            this.Transmisija,
            this.BrojVrata,
            this.BrojSjedista,
            this.Status});
            this.dgvAutomobili.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutomobili.Location = new System.Drawing.Point(3, 16);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobili.Size = new System.Drawing.Size(953, 502);
            this.dgvAutomobili.TabIndex = 1;
            this.dgvAutomobili.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAutomobili_CellMouseDoubleClick);
            // 
            // AutomobilId
            // 
            this.AutomobilId.DataPropertyName = "AutomobilId";
            this.AutomobilId.HeaderText = "AutomobilId";
            this.AutomobilId.Name = "AutomobilId";
            this.AutomobilId.ReadOnly = true;
            this.AutomobilId.Visible = false;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 130;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 80;
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.DataPropertyName = "GodinaProizvodnje";
            this.GodinaProizvodnje.HeaderText = "Godina proizvodnje";
            this.GodinaProizvodnje.Name = "GodinaProizvodnje";
            this.GodinaProizvodnje.ReadOnly = true;
            this.GodinaProizvodnje.Width = 140;
            // 
            // Gorivo
            // 
            this.Gorivo.DataPropertyName = "Gorivo";
            this.Gorivo.HeaderText = "Gorivo";
            this.Gorivo.Name = "Gorivo";
            this.Gorivo.ReadOnly = true;
            this.Gorivo.Width = 80;
            // 
            // Snaga
            // 
            this.Snaga.DataPropertyName = "Snaga";
            this.Snaga.HeaderText = "Snaga";
            this.Snaga.Name = "Snaga";
            this.Snaga.ReadOnly = true;
            this.Snaga.Width = 80;
            // 
            // Transmisija
            // 
            this.Transmisija.DataPropertyName = "Transmisija";
            this.Transmisija.HeaderText = "Transmisija";
            this.Transmisija.Name = "Transmisija";
            this.Transmisija.ReadOnly = true;
            // 
            // BrojVrata
            // 
            this.BrojVrata.DataPropertyName = "BrojVrata";
            this.BrojVrata.HeaderText = "Broj vrata";
            this.BrojVrata.Name = "BrojVrata";
            this.BrojVrata.ReadOnly = true;
            this.BrojVrata.Width = 80;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedista";
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            this.BrojSjedista.Width = 110;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAutomobili);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 521);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automobili";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(458, 42);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // cbxModeli
            // 
            this.cbxModeli.FormattingEnabled = true;
            this.cbxModeli.Location = new System.Drawing.Point(167, 43);
            this.cbxModeli.Name = "cbxModeli";
            this.cbxModeli.Size = new System.Drawing.Size(129, 21);
            this.cbxModeli.TabIndex = 6;
            // 
            // cbxProzivodjaci
            // 
            this.cbxProzivodjaci.FormattingEnabled = true;
            this.cbxProzivodjaci.Location = new System.Drawing.Point(15, 43);
            this.cbxProzivodjaci.Name = "cbxProzivodjaci";
            this.cbxProzivodjaci.Size = new System.Drawing.Size(129, 21);
            this.cbxProzivodjaci.TabIndex = 4;
            this.cbxProzivodjaci.SelectionChangeCommitted += new System.EventHandler(this.cbxProzivodjaci_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proizvođač";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godina proizvodnje";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(319, 43);
            this.txtGodinaProizvodnje.Mask = "0000";
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(129, 20);
            this.txtGodinaProizvodnje.TabIndex = 11;
            // 
            // frmAutomobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 598);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxModeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxProzivodjaci);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmAutomobili";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobili";
            this.Load += new System.EventHandler(this.frmAutomobili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxModeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutomobilId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaProizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmisija;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojVrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.ComboBox cbxProzivodjaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtGodinaProizvodnje;
    }
}