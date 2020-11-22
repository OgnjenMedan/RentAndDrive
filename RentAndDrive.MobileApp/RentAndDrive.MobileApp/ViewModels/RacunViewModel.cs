using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class RacunViewModel : BaseViewModel
    {
        private APIService _racunService = new APIService("Racuni");
        private int _rezervacijaId;

        string _brojRacuna = string.Empty;
        public string BrojRacuna
        {
            get { return _brojRacuna; }
            set { SetProperty(ref _brojRacuna, value); }
        }

        string _iznajmljivanjeVozila = string.Empty;
        public string IznajmljivanjeVozila
        {
            get { return _iznajmljivanjeVozila; }
            set { SetProperty(ref _iznajmljivanjeVozila, value); }
        }

        string _datum = string.Empty;
        public string Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        string _pdv = string.Empty;
        public string Pdv
        {
            get { return _pdv; }
            set { SetProperty(ref _pdv, value); }
        }

        string _iznosBezPdv = string.Empty;
        public string IznosBezPdv
        {
            get { return _iznosBezPdv; }
            set { SetProperty(ref _iznosBezPdv, value); }
        }

        string _iznosSaPdv = string.Empty;
        public string IznosSaPdv
        {
            get { return _iznosSaPdv; }
            set { SetProperty(ref _iznosSaPdv, value); }
        }

        string _cijenaAutomobila = string.Empty;
        public string CijenaAutomobila
        {
            get { return _cijenaAutomobila; }
            set { SetProperty(ref _cijenaAutomobila, value); }
        }


        string _brojDana = string.Empty;
        public string BrojDana
        {
            get { return _brojDana; }
            set { SetProperty(ref _brojDana, value); }
        }

        public RacunViewModel()
        {

        }
        public RacunViewModel(int rezervacijaId)
        {
            _rezervacijaId = rezervacijaId;
            InitCommand = new Command(async () => await Init());
            Title = "Račun";
        }
        public ICommand InitCommand { get; set; }
        
        public async Task Init()
        {
            var racun = await _racunService.Get<List<Racuni>>(new RacuniSearchRequest() { RezervacijaId = _rezervacijaId });

            BrojRacuna = racun[0].BrojRacuna;
            Datum = racun[0].DatumKreiranjaRacuna.ToString("dd.MM.yyyy HH:mm");
            CijenaAutomobila = $"{Decimal.Round(racun[0].Rezervacija.Automobil.Cijena, 2)} KM/dan";
            BrojDana = racun[0].TrajanjeRerezvacije.ToString();
            IznosBezPdv = $"{Decimal.Round(racun[0].IznosRezervacijeAutomobila, 2)} KM";
            Pdv = $"{racun[0].Pdv * 100}";
            IznosSaPdv = $"{Decimal.Round(racun[0].IznosSaPdv, 2)} KM";
        }
    }
}
