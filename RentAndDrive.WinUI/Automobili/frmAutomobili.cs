using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAndDrive.WinUI.Automobili
{
    public partial class frmAutomobili : Form
    {
        private readonly APIService _modeliService = new APIService("Modeli");
        private readonly APIService _proizvodjaciService = new APIService("Proizvodjaci");
        private readonly APIService _automobiliService = new APIService("Automobili");

        private List<Model.Modeli> _modeli = new List<Model.Modeli>();
        public frmAutomobili()
        {
            InitializeComponent();
        }

        private async void frmAutomobili_Load(object sender, EventArgs e)
        {
            await LoadAutomobili();
            await LoadProizvodjaci();
            await LoadModeli();
        }

        private async Task LoadAutomobili()
        {
            var result = await _automobiliService.Get<List<Model.Automobili>>();

            dgvAutomobili.AutoGenerateColumns = false;
            dgvAutomobili.DataSource = result;
        }

        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>(null);
            result.Insert(0, new Model.Proizvodjaci());

            cbxProzivodjaci.DataSource = result;
            cbxProzivodjaci.DisplayMember = "Naziv";
            cbxProzivodjaci.ValueMember = "ProizvodjacId";
        }

        private async Task LoadModeli()
        {
            _modeli = await _modeliService.Get<List<Model.Modeli>>(null);
            _modeli.Insert(0, new Model.Modeli());

            cbxModeli.DataSource = _modeli;
            cbxModeli.DisplayMember = "Naziv";
            cbxModeli.ValueMember = "ModelId";
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            AutomobiliSearchRequest request = new AutomobiliSearchRequest()
            {
                GodinaProizvodnje = txtGodinaProizvodnje.Text,
                Automatik = true,
                Manualni = true
            };

            var modelId = cbxModeli.SelectedValue;
            if (modelId == null)
                request.ModelId = 0;
            else
                request.ModelId = int.Parse(modelId.ToString());

            var proizvodjacId = cbxProzivodjaci.SelectedValue;
            if (proizvodjacId == null)
                request.ProizvodjacId = 0;
            else
                request.ProizvodjacId = int.Parse(proizvodjacId.ToString());

            var result = await _automobiliService.Get<List<Model.Automobili>>(request);
            dgvAutomobili.AutoGenerateColumns = false;
            dgvAutomobili.DataSource = result;
        }

        private void dgvAutomobili_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvAutomobili.SelectedRows[0].Cells[0].Value.ToString());
            frmDodajAutomobil frm = new frmDodajAutomobil(id);
            frm.ShowDialog();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajAutomobil frm = new frmDodajAutomobil();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await LoadAutomobili();
                await LoadModeli();
            }
        }

        private void cbxProzivodjaci_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProizvodjac = (int) cbxProzivodjaci.SelectedValue;
            var filteredModeli = _modeli.Where(x => x.ProizvodjacId == selectedProizvodjac).ToList();
            
            filteredModeli.Insert(0, new Model.Modeli());

            cbxModeli.DataSource = filteredModeli;
        }
    }
}
