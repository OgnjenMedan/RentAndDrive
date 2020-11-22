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

namespace RentAndDrive.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private APIService _proizvodjaciService = new APIService("proizvodjaci");

        private bool _statusRezervacije;

        public frmRezervacije(bool statusRezervacije)
        {
            InitializeComponent();
            _statusRezervacije = statusRezervacije;
        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            await LoadProizvodjaci();

            RezervacijeSearchRequest request = new RezervacijeSearchRequest
            {
                Status = _statusRezervacije,
                Od = null,
                Do = null,
            };
            var result = await _rezervacije.Get<List<Model.Rezervacije>>(request);
            
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = result;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RezervacijeSearchRequest request = new RezervacijeSearchRequest
            {
                Status = _statusRezervacije,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Od = dtpOd.Value,
                Do = dtpDo.Value,
                ProizvodjacId = int.Parse(cmbProizvodjac.SelectedValue.ToString()),
            };

            var result = await _rezervacije.Get<List<Model.Rezervacije>>(request);

            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = result;
        }

        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaciService.Get<List<Model.Proizvodjaci>>();
            result.Insert(0, new Model.Proizvodjaci());

            cmbProizvodjac.DisplayMember = "Naziv";
            cmbProizvodjac.ValueMember = "ProizvodjacId";
            cmbProizvodjac.DataSource = result.OrderBy(x => x.Naziv).ToList();
        }

    }
}
