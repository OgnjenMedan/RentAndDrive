using RentAndDrive.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAndDrive.WinUI.Izvjestaji
{
    public partial class frmIzvjestajKupci : Form
    {
        private APIService _kupci = new APIService("Kupci");

        public frmIzvjestajKupci()
        {
            InitializeComponent();
        }

        private async void frmIzvjestajKupci_Load(object sender, EventArgs e)
        {
            var result = await _kupci.Get<List<Kupci>>();

            result.Insert(0, new Kupci());

            cbKupci.DataSource = result;
            cbKupci.ValueMember = "KupacId";
            cbKupci.DisplayMember = "KupacInfo";
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                var kupacValue = cbKupci.SelectedValue?.ToString();

                if (int.TryParse(kupacValue, out int id))
                {
                    frmIzvjestajKupciRezervacije frm = new frmIzvjestajKupciRezervacije(id);
                    frm.ShowDialog();
                }
            }
        }

        private void cbKupci_Validating(object sender, CancelEventArgs e)
        {
            Validator.RequiredFieldCmb(cbKupci, e, errorProvider1, Properties.Resources.RequiredField);
        }
    }
}
