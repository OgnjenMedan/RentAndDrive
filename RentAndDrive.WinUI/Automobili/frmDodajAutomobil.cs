using RentAndDrive.Model.Requests;
using RentAndDrive.WinUI.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAndDrive.WinUI.Automobili
{
    public partial class frmDodajAutomobil : Form
    {
        private APIService _modeliService = new APIService("modeli");
        private APIService _automobiliSerice = new APIService("automobili");
        
        private int? _id;
        private byte[] slikaTemp;
        private byte[] slikaThumbTemp;

        public frmDodajAutomobil(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDodajAutomobil_Load(object sender, EventArgs e)
        {
            LoadModeli();

            if (_id.HasValue)
            {
                var result = await _automobiliSerice.GetById<Model.Automobili>(_id.Value);

                cmbModeli.SelectedValue = result.ModelId;
                txtGodinaProizvodnje.Text = result.GodinaProizvodnje.ToString();
                txtSnaga.Text = result.Snaga.ToString();
                txtGorivo.Text = result.Gorivo;
                txtTransmisija.Text = result.Transmisija;
                numBrojVrata.Value = result.BrojVrata;
                numBrojSjedista.Value = result.BrojSjedista;
                numCijena.Value = result.Cijena;
                chbStatus.Checked = result.Status;
                slikaTemp = result.Slika;
                slikaThumbTemp = result.SlikaThumb;

                if (result.Slika.Length != 0)
                {
                    pbSlika.Image = Image.FromStream(new MemoryStream(result.SlikaThumb));
                }
            }
        }

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {
            frmDodajModel frm = new frmDodajModel();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                LoadModeli();
            }
        }

        private async void LoadModeli()
        {
            var result = await _modeliService.Get<List<Model.Modeli>>();
            result.Insert(0, new Model.Modeli());   

            cmbModeli.DisplayMember = "Naziv";
            cmbModeli.ValueMember = "ModelId";
            cmbModeli.DataSource = result;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && txtSlika_Validating())
            {
                var request = new AutomobiliUpsertRequest()
                {
                    ModelId = int.Parse(cmbModeli.SelectedValue.ToString()),
                    Cijena = numCijena.Value,
                    GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                    Gorivo = txtGorivo.Text,
                    Transmisija = txtTransmisija.Text,
                    Snaga = int.Parse(txtSnaga.Text),
                    BrojVrata = (int)numBrojVrata.Value,
                    BrojSjedista = (int)numBrojSjedista.Value,
                    Status = chbStatus.Checked
                };

                if (txtSlika.Text != string.Empty)//Slika
                {
                    var file = File.ReadAllBytes(txtSlika.Text);
                    request.Slika = file;
                    request.SlikaThumb = file;
                } else
                {
                    request.Slika = slikaTemp;
                    request.SlikaThumb = slikaThumbTemp;
                }

                Model.Automobili entity = null;
                if (_id.HasValue)
                {
                    entity = await _automobiliSerice.Update<Model.Automobili>(_id.Value, request);
                } else
                {
                    entity = await _automobiliSerice.Insert<Model.Automobili>(request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste spremili podatke.");
                }

                DialogResult = DialogResult.OK;
                
                Close();
            }
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                txtSlika.Text = fileName;
                Image image = Image.FromFile(fileName);

                pbSlika.Image = image;
            }
        }


        private bool txtSlika_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text) && !_id.HasValue)
            {
                errorProvider.SetError(txtSlika, Properties.Resources.RequiredField);
                return false;
            } else
            {
                errorProvider.SetError(txtSlika, null);
            }

            return true;
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProvider, Properties.Resources.RequiredField);
        }

        private void num_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldNumeric(sender as NumericUpDown, e, errorProvider, Properties.Resources.RequiredField);
        }

        private void txtGodinaProizvodnje_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldMtxt(sender as MaskedTextBox, e, errorProvider, Properties.Resources.RequiredField);
        }

        private void cmbModeli_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldCmb(sender as ComboBox, e, errorProvider, Properties.Resources.RequiredField);
        }

        private void txtSnaga_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSnaga.Text) || !int.TryParse(txtSnaga.Text, out int ks))
            {
                errorProvider.SetError(txtSnaga, Properties.Resources.RequiredAndOnlyNumbersAllowed);
                e.Cancel = true;
            } else
            {
                errorProvider.SetError(txtSnaga, null);
            }
        }
    }
}
