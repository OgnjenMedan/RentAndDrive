using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using RentAndDrive.Model.Requests;

namespace RentAndDrive.WinUI.Proizvodjaci
{
    public partial class frmProizvodjaci : Form
    {
        private readonly APIService _service = new APIService("proizvodjaci");

        public frmProizvodjaci()
        {
            InitializeComponent();
        }

        private async void frmProizvodjaci_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Model.Proizvodjaci>>();

            dgvProizvodjaci.AutoGenerateColumns = false;
            dgvProizvodjaci.DataSource = result;
        }

    }
}
