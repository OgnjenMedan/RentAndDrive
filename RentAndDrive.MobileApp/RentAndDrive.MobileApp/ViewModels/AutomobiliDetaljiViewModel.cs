using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class AutomobiliDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _automobiliService = new APIService("Automobili");
        private readonly APIService _preporukeService = new APIService("Preporuke");

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

        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        public AutomobiliDetaljiViewModel()
        {
            Title = "Detalji automobila";
            InitCommand = new Command(async () => await Init());
        }

        public DateTime DatumOd;
        public DateTime DatumDo;

        public ICommand InitCommand { get; set; }
        public ObservableCollection<Model.Automobili> preporuceniAutomobiliList { get; set; } = new ObservableCollection<Model.Automobili>();

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


            // ucitavanje preporucenih automobila

            preporuceniAutomobiliList.Clear();

            var preporuke = await _preporukeService.Get<List<Model.Automobili>>(Automobil.AutomobilId);

            AutomobiliSearchRequest automobiliSearchRequest = new AutomobiliSearchRequest()
            {
                DatumOd = DatumOd,
                DatumDo = DatumDo
            };

            var dostupniAutomobili = await _automobiliService.Get<List<Model.Automobili>>(automobiliSearchRequest);
            preporuke.RemoveAll(x => !dostupniAutomobili.Any(y => x.AutomobilId == y.AutomobilId));

            foreach (var preporuceniAutomobil in preporuke)
            {
                preporuceniAutomobiliList.Add(preporuceniAutomobil);
            }
        }

    }
}
