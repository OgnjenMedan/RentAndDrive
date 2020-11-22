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

namespace RentAndDrive.WinUI.Racuni
{
    public partial class frmRacuni : Form
    {
        private readonly APIService _racuni = new APIService("Racuni");

        public frmRacuni()
        {
            InitializeComponent();
        }

        private async void frmRacuni_Load(object sender, EventArgs e)
        {
            RacuniSearchRequest request = null;
            var result = await _racuni.Get<List<Model.Racuni>>(request);

            dgvRacuni.AutoGenerateColumns = false;
            dgvRacuni.DataSource = result;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RacuniSearchRequest request = new RacuniSearchRequest()
            {
                BrojRacuna = txtBrojRacuna.Text,
                KorisnickoIme = txtKorisnickoIme.Text
            };

            var result = await _racuni.Get<List<Model.Racuni>>(request);

            dgvRacuni.AutoGenerateColumns = false;
            dgvRacuni.DataSource = result;
        }
    }
}
