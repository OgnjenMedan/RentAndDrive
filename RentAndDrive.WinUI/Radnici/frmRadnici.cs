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

namespace RentAndDrive.WinUI.Radnici
{
    public partial class frmRadnici : Form
    {
        private APIService _korisniciService = new APIService("Korisnici");
        public frmRadnici()
        {
            InitializeComponent();
        }

        private async void frmRadnici_Load(object sender, EventArgs e)
        {
            await LoadRadnici();
        }

        private async Task LoadRadnici()
        {
            KorisniciSearchRequest request = new KorisniciSearchRequest()
            {
                Ime = "",
                Prezime = "",
                isAdmin = false
            };

            var result = await _korisniciService.Get<List<Model.Korisnici>>(request);

            FormatUloge(result);

            dgvRadnici.AutoGenerateColumns = false;
            dgvRadnici.DataSource = result;
        }

        private void FormatUloge(List<Model.Korisnici> result)
        {

            foreach (var item in result)
            {
                item.Uloge = "";
                foreach (var uloga in item.KorisniciUloge)
                {
                    item.Uloge += $"{uloga.Uloga.Naziv} ";
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            KorisniciSearchRequest request = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                isAdmin = cbxAdmin.Checked
            };

            var result = await _korisniciService.Get<List<Model.Korisnici>>(request);

            FormatUloge(result);
            
            dgvRadnici.AutoGenerateColumns = false;
            dgvRadnici.DataSource = result;
        }

        private async void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            frmDodajRadnika frm = new frmDodajRadnika();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                await LoadRadnici();
            }
        }

        private void dgvRadnici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = int.Parse(dgvRadnici.SelectedRows[0].Cells[0].Value.ToString());
            frmDodajRadnika frm = new frmDodajRadnika(id);
            frm.ShowDialog();
        }
    }
}
