using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class RezervacijaFinalStepViewModel : BaseViewModel
    {

        private APIService _automobiliService = new APIService("Automobili");
        private APIService _rezervacijeService = new APIService("Rezervacije");

        Model.Automobili _automobil = null;
        public Model.Automobili Automobil
        {
            get { return _automobil; }
            set { SetProperty(ref _automobil, value); }
        }

        string _cijena = string.Empty;
        public string Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }

        string _mjenjac = string.Empty;
        public string Mjenjac
        {
            get { return _mjenjac; }
            set { SetProperty(ref _mjenjac, value); }
        }

        string _brojVrata = string.Empty;
        public string BrojVrata
        {
            get { return _brojVrata; }
            set { SetProperty(ref _brojVrata, value); }
        }

        string _brojOsoba = string.Empty;
        public string BrojOsoba
        {
            get { return _brojOsoba; }
            set { SetProperty(ref _brojOsoba, value); }
        }

        string _konjskihSnaga = string.Empty;
        public string KonjskihSnaga
        {
            get { return _konjskihSnaga; }
            set { SetProperty(ref _konjskihSnaga, value); }
        }

        string _gorivo = string.Empty;
        public string Gorivo
        {
            get { return _gorivo; }
            set { SetProperty(ref _gorivo, value); }
        }


        string _brojDana = string.Empty;
        public string BrojDana
        {
            get { return _brojDana; }
            set { SetProperty(ref _brojDana, value); }
        }


        string _cijenaUkupno = string.Empty;
        public string CijenaUkupno
        {
            get { return _cijenaUkupno; }
            set { SetProperty(ref _cijenaUkupno, value); }
        }

        DateTime _datumOd = DateTime.Now;
        public DateTime DatumOd
        {
            get { return _datumOd; }
            set { SetProperty(ref _datumOd, value); }
        }

        DateTime _datumDo = DateTime.Now;
        public DateTime DatumDo
        {
            get { return _datumDo; }
            set { SetProperty(ref _datumDo, value); }
        }
        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        string _napomena = string.Empty;
        public string Napomena
        {
            get { return _napomena; }
            set { SetProperty(ref _napomena, value); }
        }
        
        public RezervacijaFinalStepViewModel()
        {

        }

        public RezervacijaFinalStepViewModel(Automobili automobil, DateTime datumOd, DateTime datumDo)
        {
            Title = "Rezervacija automobila";
            Automobil = automobil;

            DatumOd = datumOd;
            DatumDo = datumDo;

            InitCommand = new Command(async () => await Init());

        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            Cijena = $"{Automobil.Cijena} KM/dan";
            Mjenjac = Automobil.Transmisija;
            Gorivo = Automobil.Gorivo;
            BrojVrata = $"Broj vrata: {Automobil.BrojVrata}";
            BrojOsoba = $"{Automobil.BrojSjedista} sjedišta";
            KonjskihSnaga = $"{Automobil.Snaga} KS";
            Slika = new byte[Automobil.Slika.Length];
            Slika = Automobil.Slika.ToArray();

            IzracunajCijenu(DatumOd, DatumDo);
        }

        public async Task<bool> IznajmiVozilo(Automobili automobil, DateTime datumOd, DateTime datumDo)
        {
            AutomobiliSearchRequest automobiliSearchRequest = new AutomobiliSearchRequest()
            {
                DatumOd = datumOd,
                DatumDo = datumDo,
            };

            var listaAutomobila = await _automobiliService.Get<List<Model.Automobili>>(automobiliSearchRequest);

            bool exists = listaAutomobila.Any(x => x.AutomobilId == automobil.AutomobilId);

            if (!exists)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Automobil nije dostupan u odabranom periodu. Molimo Vas, promijenite period rezervacije.", "U redu");
                return false;
            }


            var request = new RezervacijeUpsertRequest()
            {
                KupacId = APIService.KupacId,
                AutomobilId = automobil.AutomobilId,
                DatumKreiranjaRezervacije = DateTime.Now,
                DatumPreuzimanja = datumOd,
                DatumPovrata = datumDo,
                Napomena = Napomena,
                Status = false
            };

            try
            {
                var entity = await _rezervacijeService.Insert<Model.Rezervacije>(request);

                if (entity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Uspješno ste rezervisali automobil. Sve detalje svoje rezervacije pogledajte u sekciji Aktivne rezervacije.", "U redu");
                    return true;
                }
            } catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Došlo je do greške prilikom rezervisanja automobila. Molimo Vas, pokušajte ponovo.", "U redu");
            }
            return false;
        }


        public void IzracunajCijenu(DateTime datumOd, DateTime datumDo)
        {
            int trajanjeRezervacije = (int)(datumDo - datumOd).TotalDays;
            BrojDana = trajanjeRezervacije.ToString();

            decimal cijenaRezervacije = trajanjeRezervacije * Automobil.Cijena * 1.17m;
            CijenaUkupno = $"{cijenaRezervacije.ToString("#.##")} KM";
        }
    }
}
