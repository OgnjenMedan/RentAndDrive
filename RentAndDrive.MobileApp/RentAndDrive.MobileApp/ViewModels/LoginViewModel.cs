using RentAndDrive.MobileApp.Views;
using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _ulogeService = new APIService("Uloge");
        private readonly APIService _kupciService = new APIService("Kupci");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => { await Login(); });
            RegistracijaCommand = new Command(() => { Registracija(); });
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegistracijaCommand { get; set; }

        public async Task Login()
        {
            IsBusy = true;

            APIService.Username = _username;
            APIService.Password = _password;
            
            try
            {
                await _ulogeService.Get<dynamic>(null);

                List<Model.Kupci> kupciList = await _kupciService.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
                if (kupciList.Count == 1)
                {
                    APIService.KupacId = kupciList[0].KupacId;
                    Application.Current.MainPage = new MainPage();
                } else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Unijeli ste pogrešno korisničko ime ili lozinku!", "U redu");
                }
            } catch (Exception ex)
            {
            }
        }

        public void Registracija()
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
    }
}
