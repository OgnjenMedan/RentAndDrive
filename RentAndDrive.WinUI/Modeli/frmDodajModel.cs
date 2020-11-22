using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAndDrive.WinUI.Modeli
{
    public partial class frmDodajModel : Form
    {
        private APIService _proizvodjaciService = new APIService("proizvodjaci");
        private APIService _modeliService = new APIService("modeli");
        private int? _id;
        private int? _proizvodjacId;
        public frmDodajModel(int? id = null, int? proizvodjacId = null, string nazivModela = "")
        {
            InitializeComponent();

            if (id.HasValue && proizvodjacId.HasValue && !string.IsNullOrEmpty(nazivModela))
            {
                _id = id;
                txtNazivModela.Text = nazivModela;
                _proizvodjacId = proizvodjacId;
            }
        }
        private async void frmDodajModel_Load(object sender, EventArgs e)
        {
            await LoadProizvodjaci();
        }

        private async void btnDodajModel_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new ModeliUpsertRequest()
                {
                    ProizvodjacId = int.Parse(cbxProizvodjaci.SelectedValue.ToString()),
                    Naziv = txtNazivModela.Text
                };

                Model.Modeli entity = null;

                if (_id.HasValue)
                {
                    entity = await _modeliService.Update<Model.Modeli>(_id.Value, request);
                } else
                {
                    entity = await _modeliService.Insert<Model.Modeli>(request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste spremili podatke.", "Info", MessageBoxButtons.OK);
                }

                DialogResult = DialogResult.OK;

                Close();
            }
        }
        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>();

            cbxProizvodjaci.DisplayMember = "Naziv";
            cbxProizvodjaci.ValueMember = "ProizvodjacId";
            cbxProizvodjaci.DataSource = result.OrderBy(x => x.Naziv).ToList();

            if (_proizvodjacId.HasValue)
                cbxProizvodjaci.SelectedValue = _proizvodjacId;
        }

        private void txtNazivModela_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivModela.Text))
            {
                errorProvider.SetError(txtNazivModela, Properties.Resources.RequiredField);
                e.Cancel = true;

            } else
            {
                errorProvider.SetError(txtNazivModela, null);
                e.Cancel = false;
            }
        }

    }
}
