using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAndDrive.WinUI.Radnici
{
    public partial class frmDodajRadnika : Form
    {
        private APIService _korisnici = new APIService("Korisnici");
        private APIService _uloge = new APIService("Uloge");

        int? _id = null;
        public frmDodajRadnika(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDodajRadnika_Load(object sender, EventArgs e)
        {
            var ulogeList = await _uloge.Get<List<Model.Uloge>>(null);
            clbUloge.DataSource = ulogeList;
            clbUloge.DisplayMember = "Naziv";

            if(_id.HasValue)
            {
                var result = await _korisnici.GetById<Model.Korisnici>(_id);

                txtIme.Text = result.Ime;
                txtPrezime.Text = result.Prezime;
                txtKorisnickoIme.Text = result.KorisnickoIme;
                txtTelefon.Text = result.Telefon;
                txtEmail.Text = result.Email;

                foreach (var item in result.KorisniciUloge)
                {
                    for (int i = 0; i < clbUloge.Items.Count; i++)
                    {
                        Model.Uloge trenutna = (Model.Uloge)clbUloge.Items[i];

                        if (trenutna.UlogaId == item.UlogaId)
                            clbUloge.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }    
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && txtLozinka_Validating() && await txtKorisnickoIme_Validating() && await txtEmail_Validating())
            {
                var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();
                var request = new KorisniciUpsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordConfirm = txtPotvrdaLozinke.Text,
                    Status = cbStatus.Checked,
                    Uloge = roleList
                };

                Model.Korisnici entity = null;
                try
                {
                    if (_id.HasValue)
                    {

                        entity = await _korisnici.Update<Model.Korisnici>(_id.Value, request);
                        if (entity.KorisnickoIme.Equals(APIService.Username))
                        {
                            APIService.Password = request.Password;
                        }
                    } else
                    {
                        entity = await _korisnici.Insert<Model.Korisnici>(request);
                    }
                } catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste sačuvali podatke.");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }
 
        private bool txtLozinka_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                if (_id.HasValue)
                {
                    errorProvider1.SetError(txtLozinka, null);
                    errorProvider1.SetError(txtPotvrdaLozinke, null);
                    return true;
                } else
                {
                    errorProvider1.SetError(txtLozinka, Properties.Resources.RequiredField);
                    errorProvider1.SetError(txtPotvrdaLozinke, Properties.Resources.RequiredField);
                    return false;
                }
            } else if (txtLozinka.Text != txtPotvrdaLozinke.Text)
            {
                errorProvider1.SetError(txtLozinka, "Passwordi se ne slažu");
                errorProvider1.SetError(txtPotvrdaLozinke, "Passwordi se ne slažu");
                return false;
            }

            errorProvider1.SetError(txtLozinka, null);
            errorProvider1.SetError(txtPotvrdaLozinke, null);
            return true;
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldTxt(sender as TextBox, e, errorProvider1, Properties.Resources.RequiredField);
        }

        private void clbUloge_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldClb(clbUloge, e, errorProvider1, Properties.Resources.RequiredField);
        }

        private async Task<bool> txtKorisnickoIme_Validating()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            int id = _id ?? 0;
            foreach (var item in result)
                if (item.KorisnickoIme == txtKorisnickoIme.Text && item.KorisnikId != id)
                {
                    errorProvider1.SetError(txtKorisnickoIme, "Korisničko ime već postoji");
                    return false;
                }
            errorProvider1.SetError(txtKorisnickoIme, null);
            return true;
        }

        private async Task<bool> txtEmail_Validating()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            int id = _id ?? 0;

            foreach (var item in result)
            {
                if (item.Email == txtEmail.Text && item.KorisnikId != id)
                {
                    errorProvider1.SetError(txtEmail, "Email već postoji");
                    return false;
                }
            }

            errorProvider1.SetError(txtEmail, null);
            return true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.RequiredField);
                e.Cancel = true;
            } else if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                errorProvider1.SetError(txtEmail, "Pogrešan format email-a");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.RequiredField);
                e.Cancel = true;
            } else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}$") && !Regex.IsMatch(txtTelefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{4}$"))
            {
                errorProvider1.SetError(txtTelefon, "Pogrešan format telefona");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }
    }
}
