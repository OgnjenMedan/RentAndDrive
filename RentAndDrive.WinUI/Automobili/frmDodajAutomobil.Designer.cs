namespace RentAndDrive.WinUI.Automobili
{
    partial class frmDodajAutomobil
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
            this.cmbModeli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDodajAutomobil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSnaga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.MaskedTextBox();
            this.numBrojVrata = new System.Windows.Forms.NumericUpDown();
            this.numBrojSjedista = new System.Windows.Forms.NumericUpDown();
            this.txtGorivo = new System.Windows.Forms.TextBox();
            this.txtTransmisija = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojVrata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSjedista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModeli
            // 
            this.cmbModeli.FormattingEnabled = true;
            this.cmbModeli.Location = new System.Drawing.Point(287, 78);
            this.cmbModeli.Name = "cmbModeli";
            this.cmbModeli.Size = new System.Drawing.Size(176, 21);
            this.cmbModeli.TabIndex = 0;
            this.cmbModeli.Validating += new System.ComponentModel.CancelEventHandler(this.cmbModeli_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(172, 240);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(75, 23);
            this.btnSlika.TabIndex = 29;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(27, 241);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.ReadOnly = true;
            this.txtSlika.Size = new System.Drawing.Size(139, 20);
            this.txtSlika.TabIndex = 26;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Checked = true;
            this.chbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatus.Location = new System.Drawing.Point(288, 319);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(62, 17);
            this.chbStatus.TabIndex = 25;
            this.chbStatus.Text = "Aktivan";
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(27, 57);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(220, 159);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 27;
            this.pbSlika.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Slika";
            // 
            // btnDodajAutomobil
            // 
            this.btnDodajAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAutomobil.Location = new System.Drawing.Point(469, 78);
            this.btnDodajAutomobil.Name = "btnDodajAutomobil";
            this.btnDodajAutomobil.Size = new System.Drawing.Size(23, 21);
            this.btnDodajAutomobil.TabIndex = 30;
            this.btnDodajAutomobil.Text = "+";
            this.btnDodajAutomobil.UseVisualStyleBackColor = true;
            this.btnDodajAutomobil.Click += new System.EventHandler(this.btnDodajAutomobil_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Snaga (KS)";
            // 
            // txtSnaga
            // 
            this.txtSnaga.Location = new System.Drawing.Point(419, 136);
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.Size = new System.Drawing.Size(121, 20);
            this.txtSnaga.TabIndex = 43;
            this.txtSnaga.Validating += new System.ComponentModel.CancelEventHandler(this.txtSnaga_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Transmisija";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Gorivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Godina proizvodnje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Broj sjedišta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Broj vrata";
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Location = new System.Drawing.Point(288, 281);
            this.numCijena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(252, 20);
            this.numCijena.TabIndex = 31;
            this.numCijena.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cijena KM/dan";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(287, 136);
            this.txtGodinaProizvodnje.Mask = "0000";
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(120, 20);
            this.txtGodinaProizvodnje.TabIndex = 32;
            this.txtGodinaProizvodnje.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodinaProizvodnje_Validating);
            // 
            // numBrojVrata
            // 
            this.numBrojVrata.Location = new System.Drawing.Point(288, 232);
            this.numBrojVrata.Name = "numBrojVrata";
            this.numBrojVrata.Size = new System.Drawing.Size(120, 20);
            this.numBrojVrata.TabIndex = 33;
            this.numBrojVrata.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // numBrojSjedista
            // 
            this.numBrojSjedista.Location = new System.Drawing.Point(420, 232);
            this.numBrojSjedista.Name = "numBrojSjedista";
            this.numBrojSjedista.Size = new System.Drawing.Size(120, 20);
            this.numBrojSjedista.TabIndex = 34;
            this.numBrojSjedista.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // txtGorivo
            // 
            this.txtGorivo.Location = new System.Drawing.Point(420, 183);
            this.txtGorivo.Name = "txtGorivo";
            this.txtGorivo.Size = new System.Drawing.Size(120, 20);
            this.txtGorivo.TabIndex = 35;
            this.txtGorivo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtTransmisija
            // 
            this.txtTransmisija.Location = new System.Drawing.Point(288, 183);
            this.txtTransmisija.Name = "txtTransmisija";
            this.txtTransmisija.Size = new System.Drawing.Size(120, 20);
            this.txtTransmisija.TabIndex = 36;
            this.txtTransmisija.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(519, 379);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(84, 29);
            this.btnDodaj.TabIndex = 45;
            this.btnDodaj.Text = "Sačuvaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDodajAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 420);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSnaga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.numBrojVrata);
            this.Controls.Add(this.numBrojSjedista);
            this.Controls.Add(this.txtGorivo);
            this.Controls.Add(this.txtTransmisija);
            this.Controls.Add(this.btnDodajAutomobil);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.chbStatus);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModeli);
            this.Name = "frmDodajAutomobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj automobil";
            this.Load += new System.EventHandler(this.frmDodajAutomobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojVrata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSjedista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDodajAutomobil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSnaga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtGodinaProizvodnje;
        private System.Windows.Forms.NumericUpDown numBrojVrata;
        private System.Windows.Forms.NumericUpDown numBrojSjedista;
        private System.Windows.Forms.TextBox txtGorivo;
        private System.Windows.Forms.TextBox txtTransmisija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}