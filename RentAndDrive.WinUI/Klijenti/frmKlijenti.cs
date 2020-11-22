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

namespace RentAndDrive.WinUI.Klijenti
{
    public partial class frmKlijenti : Form
    {
        private readonly APIService _klijenti = new APIService("Kupci");

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var request = new KupciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtKorisnickoIme.Text
            };

            var result = await _klijenti.Get<List<Model.Kupci>>(request);

            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }

        private async void frmKlijenti_Load(object sender, EventArgs e)
        {
            KupciSearchRequest request = null;

            var result = await _klijenti.Get<List<Model.Kupci>>(request);

            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }
    }
}
