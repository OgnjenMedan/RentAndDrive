using RentAndDrive.MobileApp.Views;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class RezervacijeDetaljiViewModel : BaseViewModel
    {
        string _automobil = string.Empty;
        private readonly APIService _rezervacijeServices = new APIService("Rezervacije");
        private readonly APIService _ocjeneService = new APIService("Ocjene");
        public string Automobil
        {
            get { return _automobil; }
            set { SetProperty(ref _automobil, value); }
        }

        string _datumPreuzimanja = string.Empty;
        public string DatumPreuzimanja
        {
            get { return _datumPreuzimanja; }
            set { SetProperty(ref _datumPreuzimanja, value); }
        }

        string _datumPovrata = string.Empty;
        public string DatumPovrata
        {
            get { return _datumPovrata; }
            set { SetProperty(ref _datumPovrata, value); }
        }

        string _napomena = string.Empty;

        public string Napomena
        {
            get { return _napomena; }
            set { SetProperty(ref _napomena, value); }
        }

        Model.Rezervacije _rezervacija = null;
        public Model.Rezervacije Rezervacija
        {
            get { return _rezervacija; }
            set { SetProperty(ref _rezervacija, value); }
        }

        bool _buttonVisibility;

        public bool ButtonVisibility
        {
            get {
                return _buttonVisibility;
            }
            set {
                _buttonVisibility = value;
                OnPropertyChanged(nameof(ButtonVisibility));
            }
        }

        string _ocjenaAutomobila = string.Empty;
        public string OcjenaAutomobila
        {
            get { return _ocjenaAutomobila; }
            set { SetProperty(ref _ocjenaAutomobila, value); }
        }

        public Model.Rezervacije Item { get; set; }

        public RezervacijeDetaljiViewModel()
        {
        }

        public RezervacijeDetaljiViewModel(Rezervacije model)
        {
            Title = "Detalji rezervacije";
            Item = model;
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            ButtonVisibility = !Item.Status;

            Rezervacija = Item;
            Automobil = Item.Automobil.ToString();
            DatumPovrata = Item.DatumPovrata.ToString("dd.MM.yyyy");
            DatumPreuzimanja = Item.DatumPreuzimanja.ToString("dd.MM.yyyy");
            Napomena = Item.Napomena;
        }


        public async Task OtkaziRezervaciju()
        {

            bool answer = await Application.Current.MainPage.DisplayAlert("Pažnja!", "Da li ste sigurni da želite otkazati odabranu rezervaciju?", "Da", "Ne");

            if (answer)
            {
                RezervacijeUpsertRequest request = new RezervacijeUpsertRequest()
                {
                    Status = true,
                    AutomobilId = Item.AutomobilId,
                    DatumKreiranjaRezervacije = Item.DatumKreiranjaRezervacije,
                    DatumPovrata = Item.DatumPovrata,
                    DatumPreuzimanja = Item.DatumPreuzimanja,
                    KupacId = Item.KupacId,
                    Napomena = Item.Napomena
                };

                try
                {
                    Rezervacije entity = null;
                    entity = await _rezervacijeServices.Update<Model.Rezervacije>(Item.RezervacijaId, request);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste otkazali rezervaciju", "U redu");
                        ButtonVisibility = false;
                    }
                } catch
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Greška na serveru!", "U redu");
                }
            }
        }

        public async Task<bool> IsOcjenjen()
        {
            OcjeneSearchRequest searchRequest = new OcjeneSearchRequest()
            {
                AutomobilId = Item.Automobil.AutomobilId,
                KupacId = APIService.KupacId
            };

            var ocjene = await _ocjeneService.Get<List<Model.Ocjene>>(searchRequest);

            return ocjene.Count > 0;
        }

        public async Task<bool> OcijeniAutomobil()
        {
            bool isNumber = int.TryParse(OcjenaAutomobila, out int ocjena);

            if(isNumber)
            {
                if (ocjena > 0 && ocjena < 11)
                {
                    OcjeneUpsertRequest request = new OcjeneUpsertRequest()
                    {
                        AutomobilId = Item.Automobil.AutomobilId,
                        KupacId = APIService.KupacId,
                        Datum = DateTime.Now,
                        Ocjena = ocjena
                    };

                    try
                    {
                        var entity = await _ocjeneService.Insert<Model.Ocjene>(request);
                        if (entity != null)
                        {
                            await Application.Current.MainPage.DisplayAlert("Info", $"Uspješno ste ocijenili automobil {Item.Automobil}!", "U redu");
                            return true;
                        }
                    } catch (Exception)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Došlo je do greške prilikom ocjenjivanja automobila. Pokušajte ponovo.", "U redu");
                        return false;

                    }

                } else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Ocjena mora biti u rasponu od 1 do 10.", "U redu");
                    return false;
                }
            } else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Molimo Vas da u polje za Ocjenu automobila unesete brojčanu vrijednost.", "U redu");
            }
            return false;
        }
    }
}
