using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RentAndDrive.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _userService = new APIService("Korisnici");
        APIService _ulogeService = new APIService("Uloge");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtLozinka.Text;

                var korisnici = await _userService.Get<List<Model.Korisnici>>(new KorisniciSearchRequest() { KorisnickoIme = APIService.Username });
                var korisnik = korisnici.Where(x => x.KorisnickoIme == APIService.Username).FirstOrDefault();

                await _ulogeService.Get<dynamic>(null);

                frmIndex frmIndex = new frmIndex();
                frmIndex.Show();
            } catch (Exception ex)
            {
            }
        }
    }
}
