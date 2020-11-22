namespace RentAndDrive.WinUI.Proizvodjaci
{
    partial class frmProizvodjaci
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProizvodjaci = new System.Windows.Forms.DataGridView();
            this.ProizvodjacId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProizvodjaci);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvođači";
            // 
            // dgvProizvodjaci
            // 
            this.dgvProizvodjaci.AllowUserToAddRows = false;
            this.dgvProizvodjaci.AllowUserToDeleteRows = false;
            this.dgvProizvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodjaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodjacId,
            this.Naziv});
            this.dgvProizvodjaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProizvodjaci.Location = new System.Drawing.Point(3, 16);
            this.dgvProizvodjaci.Name = "dgvProizvodjaci";
            this.dgvProizvodjaci.ReadOnly = true;
            this.dgvProizvodjaci.Size = new System.Drawing.Size(267, 339);
            this.dgvProizvodjaci.TabIndex = 0;
            // 
            // ProizvodjacId
            // 
            this.ProizvodjacId.DataPropertyName = "ProizvodjacId";
            this.ProizvodjacId.HeaderText = "ProizvodjacId";
            this.ProizvodjacId.Name = "ProizvodjacId";
            this.ProizvodjacId.ReadOnly = true;
            this.ProizvodjacId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // frmProizvodjaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 406);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProizvodjaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvođači";
            this.Load += new System.EventHandler(this.frmProizvodjaci_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProizvodjaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodjacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}