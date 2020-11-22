using RentAndDrive.MobileApp.Views;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
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
        
        string _passwordConfirm = string.Empty;
        public string PasswordConfirm
        {
            get { return _passwordConfirm; }
            set { SetProperty(ref _passwordConfirm, value); }
        }

        //Gradovi _selectedGrad = null;
        //public Gradovi SelectedGrad
        //{
        //    get { return _selectedGrad; }
        //    set {
        //        SetProperty(ref _selectedGrad, value);
        //        if (value != null)
        //        {
        //            GradoviCommand.Execute(null);
        //        }
        //    }
        //}

        public ICommand InitCommand { get; set; }
        public ICommand RegistracijaCommand { get; set; }
        public ICommand GradoviCommand { get; set; }
        // public ObservableCollection<Gradovi> gradoviList { get; set; } = new ObservableCollection<Gradovi>();

        public RegistracijaViewModel()
        {
            Title = "Registracija";
            RegistracijaCommand = new Command(async () => await Registracija());
           //  GradoviCommand = new Command(async () => await FillGradoviList());
        }

        public async Task Registracija()
        {
            try
            {
                KupciUpsertRequest request = new KupciUpsertRequest
                {
                    Ime = Ime,
                    Prezime = Prezime,
                    Status = true,
                    DatumRegistracije = DateTime.Now,
                    Email = Email,
                    KorisnickoIme = KorisnickoIme,
                    Telefon = Telefon,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm
                };

                var entity = await _kupacService.Insert<Model.Kupci>(request);
                if (entity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Uspješno ste se registrovali.", "U redu");
                }
                Application.Current.MainPage = new LoginPage();
            } catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "U redu");
                throw;
            }

        }
        public async Task<bool> txtKorisnickoIme_Validating()
        {
            var result = await _kupacService.Get<List<Model.Kupci>>(null);
            foreach (var item in result)
                if (item.KorisnickoIme == KorisnickoIme)
                {
                    return false;
                }
            return true;
        }

        public async Task<bool> txtEmail_Validating()
        {
            var result = await _kupacService.Get<List<Model.Kupci>>(null);
            foreach (var item in result)
                if (item.Email == Email)
                {
                    return false;
                }
            return true;
        }
                
        //public async Task FillGradoviList()
        //{
        //    try
        //    {
        //        if (gradoviList.Count == 0)
        //        {
        //            var list = await _gradoviService.Get<List<Model.Gradovi>>(null);
        //            foreach (var item in list)
        //                gradoviList.Add(item);
        //        }
        //    } catch (Exception ex)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "U redu");
        //    }
        //}
    }
}
