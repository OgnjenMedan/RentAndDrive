using RentAndDrive.Model;
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
    public class KupacViewModel : BaseViewModel
    {
        private APIService _kupacService = new APIService("Kupci");
        private APIService _gradoviService = new APIService("Gradovi");

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        Gradovi _selectedGradovi = null;
        public Gradovi SelectedGradovi
        {
            get { return _selectedGradovi; }
            set {
                SetProperty(ref _selectedGradovi, value);
            }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _newPassword = string.Empty;
        public string NewPassword
        {
            get { return _newPassword; }
            set { SetProperty(ref _newPassword, value); }
        }


        string _passwordConfirm = string.Empty;
        public string PasswordConfirm
        {
            get { return _passwordConfirm; }
            set { SetProperty(ref _passwordConfirm, value); }
        }


        public ICommand InitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand GradoviCommand { get; set; }
        public ObservableCollection<Model.Gradovi> GradoviList { get; set; } = new ObservableCollection<Model.Gradovi>();

        public KupacViewModel()
        {
            Title = "Moj profil";
            // GradoviCommand = new Command(async () => await FillGradoviList());
            EditCommand = new Command(async () => await Edit());
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            var wait = await _kupacService.Get<List<Model.Kupci>>(null);

            var kupac = await _kupacService.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });

            try
            {
                Ime = kupac[0].Ime;
                Prezime = kupac[0].Prezime;
                Telefon = kupac[0].Telefon;
                Email = kupac[0].Email;
                KorisnickoIme = kupac[0].KorisnickoIme;

                if(kupac[0].GradId.HasValue && kupac[0].GradId.Value > 0)
                    SelectedGradovi = kupac[0].Grad;

            } catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "U redu");
                throw;
            }
        }


        public async Task Edit()
        {
            var kupac = await _kupacService.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });

            try
            {
                if (Password.Equals(APIService.Password))
                {
                    KupciUpsertRequest request = new KupciUpsertRequest()
                    {
                        Ime = Ime,
                        Prezime = Prezime,
                        Status = true,
                        DatumRegistracije = kupac[0].DatumRegistracije,
                        Email = Email,
                        KorisnickoIme = KorisnickoIme,
                        Telefon = Telefon,
                        Password = NewPassword,
                        PasswordConfirm = PasswordConfirm,
                    };

                    if (SelectedGradovi != null)
                        request.GradId = SelectedGradovi.GradId;

                    var entity = await _kupacService.Update<Model.Kupci>(kupac[0].KupacId, request);

                    if(entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Info", "Uspješno ste izmijenili svoje podatke.", "U redu");
                        if (!string.IsNullOrWhiteSpace(request.Password))
                            APIService.Password = request.Password;
                    }
                }

                else { 
                        await Application.Current.MainPage.DisplayAlert("Pogrešna lozinka", "Unesite ispravnu lozinku kako bi uredili vaše podatke.", "U redu");
                }

            } catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "U redu");
                throw;
            }

        }

        public async Task FillGradoviList()
        {
            try
            {
                if (GradoviList.Count == 0)
                {
                    var list = await _gradoviService.Get<List<Model.Gradovi>>(null);
                    foreach (var item in list)
                        GradoviList.Add(item);
                }
            } catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "U redu");
            }
        }

        public async Task<bool> txtEmail_Validating()
        {
            var kupac = await _kupacService.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count == 1)
            {
                var result = await _kupacService.Get<List<Model.Kupci>>(null);
                foreach (var item in result)
                    if (item.Email == Email && item.KupacId != kupac[0].KupacId)
                    {
                        return false;
                    }
                return true;
            }
            return false;
        }
    }
}
