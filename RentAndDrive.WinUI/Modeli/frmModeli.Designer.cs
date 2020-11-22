namespace RentAndDrive.WinUI.Modeli
{
    partial class frmModeli
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
            this.grpbModeli = new System.Windows.Forms.GroupBox();
            this.dgvModeli = new System.Windows.Forms.DataGridView();
            this.ModelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.grpbModeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeli)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbModeli
            // 
            this.grpbModeli.Controls.Add(this.dgvModeli);
            this.grpbModeli.Location = new System.Drawing.Point(12, 78);
            this.grpbModeli.Name = "grpbModeli";
            this.grpbModeli.Size = new System.Drawing.Size(368, 340);
            this.grpbModeli.TabIndex = 0;
            this.grpbModeli.TabStop = false;
            this.grpbModeli.Text = "Modeli";
            // 
            // dgvModeli
            // 
            this.dgvModeli.AllowUserToAddRows = false;
            this.dgvModeli.AllowUserToDeleteRows = false;
            this.dgvModeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelId,
            this.Proizvodjac,
            this.Naziv});
            this.dgvModeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModeli.Location = new System.Drawing.Point(3, 16);
            this.dgvModeli.Name = "dgvModeli";
            this.dgvModeli.ReadOnly = true;
            this.dgvModeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModeli.Size = new System.Drawing.Size(362, 321);
            this.dgvModeli.TabIndex = 0;
            this.dgvModeli.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvModeli_CellMouseDoubleClick);
            // 
            // ModelId
            // 
            this.ModelId.DataPropertyName = "ModelId";
            this.ModelId.HeaderText = "ModelId";
            this.ModelId.Name = "ModelId";
            this.ModelId.ReadOnly = true;
            this.ModelId.Visible = false;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.DataPropertyName = "Proizvodjac";
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.ReadOnly = true;
            this.Proizvodjac.Width = 120;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Model";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(166, 34);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(287, 34);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj model";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv modela";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(16, 36);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(144, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // frmModeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 430);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.grpbModeli);
            this.Name = "frmModeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeli automobila";
            this.Load += new System.EventHandler(this.frmModeli_Load);
            this.grpbModeli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbModeli;
        private System.Windows.Forms.DataGridView dgvModeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}