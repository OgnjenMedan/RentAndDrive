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
    public partial class frmModeli : Form
    {
        private readonly APIService _modeliService = new APIService("Modeli");
        public frmModeli()
        {
            InitializeComponent();
        }

        private async void frmModeli_Load(object sender, EventArgs e)
        {
            await LoadModeli();
        }

        private async Task LoadModeli()
        {
            var source = await _modeliService.Get<List<Model.Modeli>>();

            dgvModeli.AutoGenerateColumns = false;
            dgvModeli.DataSource = source;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            ModeliSearchRequest request = new ModeliSearchRequest() { Naziv = txtNaziv.Text };
            
            var source = await _modeliService.Get<List<Model.Modeli>>(request);

            dgvModeli.AutoGenerateColumns = false;
            dgvModeli.DataSource = source;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajModel frmDodajModel = new frmDodajModel();
            frmDodajModel.ShowDialog();

            if (frmDodajModel.DialogResult == DialogResult.OK)
            {
                await LoadModeli();
            }
        }

        private void dgvModeli_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = dgvModeli.SelectedRows[0].DataBoundItem as Model.Modeli;

            frmDodajModel frmDodajModel = new frmDodajModel(result.ModelId, result.ProizvodjacId, result.Naziv);
            frmDodajModel.ShowDialog();
        }
    }
}
