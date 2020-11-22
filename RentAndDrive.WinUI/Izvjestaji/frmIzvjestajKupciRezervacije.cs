using Microsoft.Reporting.WinForms;
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

namespace RentAndDrive.WinUI.Izvjestaji
{
    public partial class frmIzvjestajKupciRezervacije : Form
    {
        private readonly APIService _automobiliService = new APIService("Automobili");
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _racuniService = new APIService("Racuni");
        private readonly APIService _kupciService = new APIService("Kupci");

        private int _kupacId;

        public frmIzvjestajKupciRezervacije(int kupacId)
        {
            InitializeComponent();
            _kupacId = kupacId;
        }

        private async void frmIzvjestajKupciRezervacije_Load(object sender, EventArgs e)
        {
            var kupac = await _kupciService.GetById<Model.Kupci>(_kupacId);

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Kupac", $"{kupac.Ime} {kupac.Prezime} - {kupac.KorisnickoIme}"));
            rpc.Add(new ReportParameter("DatumIzdavanja", DateTime.Now.ToString("dd.MM.yyyy HH:mm")));

            RezervacijeSearchRequest request = new RezervacijeSearchRequest()
            {
                KupacId = kupac.KupacId,
                Status = true // samo zavrsene rezervacije
            };

            var rezervacijeList = await _rezervacijeService.Get<List<Model.Rezervacije>>(request);

            rpc.Add(new ReportParameter("BrojRezervacija", rezervacijeList.Count.ToString()));
            dsRezervacije.tblRezervacijeDataTable tbl = new dsRezervacije.tblRezervacijeDataTable();

            decimal ukupanIznos = 0;
            decimal rezervacijaIznos = 0;

            foreach (var rezervacija in rezervacijeList)
            {
                var racuniList = await _racuniService.Get<List<Model.Racuni>>(new RacuniSearchRequest() { RezervacijaId = rezervacija.RezervacijaId });
                
                dsRezervacije.tblRezervacijeRow row = tbl.NewtblRezervacijeRow();
                
                row.Automobil = rezervacija.Automobil.ToString();
                row.DatumPreuzimanja = rezervacija.DatumPreuzimanja.ToString("dd.MM.yyyy");
                row.DatumPovrata = rezervacija.DatumPovrata.ToString("dd.MM.yyyy");

                rezervacijaIznos = racuniList.First().IznosSaPdv;
                
                row.Iznos = rezervacijaIznos.ToString();

                ukupanIznos += rezervacijaIznos;

                tbl.Rows.Add(row);
            }

            rpc.Add(new ReportParameter("UkupanIznos", ukupanIznos.ToString()));
            
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Rezervacije";
            rds.Value = tbl;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
