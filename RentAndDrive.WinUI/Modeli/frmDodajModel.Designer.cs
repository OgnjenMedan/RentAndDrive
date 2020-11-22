namespace RentAndDrive.WinUI.Modeli
{
    partial class frmDodajModel
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
            this.txtNazivModela = new System.Windows.Forms.TextBox();
            this.cbxProizvodjaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajModel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivModela
            // 
            this.txtNazivModela.Location = new System.Drawing.Point(52, 107);
            this.txtNazivModela.Name = "txtNazivModela";
            this.txtNazivModela.Size = new System.Drawing.Size(152, 20);
            this.txtNazivModela.TabIndex = 1;
            this.txtNazivModela.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivModela_Validating);
            // 
            // cbxProizvodjaci
            // 
            this.cbxProizvodjaci.FormattingEnabled = true;
            this.cbxProizvodjaci.Location = new System.Drawing.Point(52, 52);
            this.cbxProizvodjaci.Name = "cbxProizvodjaci";
            this.cbxProizvodjaci.Size = new System.Drawing.Size(152, 21);
            this.cbxProizvodjaci.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proizvodjač";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // btnDodajModel
            // 
            this.btnDodajModel.Location = new System.Drawing.Point(90, 159);
            this.btnDodajModel.Name = "btnDodajModel";
            this.btnDodajModel.Size = new System.Drawing.Size(75, 23);
            this.btnDodajModel.TabIndex = 5;
            this.btnDodajModel.Text = "Sačuvaj";
            this.btnDodajModel.UseVisualStyleBackColor = true;
            this.btnDodajModel.Click += new System.EventHandler(this.btnDodajModel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDodajModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 209);
            this.Controls.Add(this.btnDodajModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxProizvodjaci);
            this.Controls.Add(this.txtNazivModela);
            this.Name = "frmDodajModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model automobila";
            this.Load += new System.EventHandler(this.frmDodajModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivModela;
        private System.Windows.Forms.ComboBox cbxProizvodjaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajModel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}