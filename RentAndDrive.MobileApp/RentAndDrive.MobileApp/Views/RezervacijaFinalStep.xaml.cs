using RentAndDrive.MobileApp.ViewModels;
using RentAndDrive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentAndDrive.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijaFinalStep : ContentPage
    {
        RezervacijaFinalStepViewModel _model = null;
        Automobili _selectedAutomobil = null;
        DateTime _datumOd;
        DateTime _datumDo;
        public RezervacijaFinalStep(Automobili automobil, DateTime datumOd, DateTime datumDo)
        {
            InitializeComponent();

            BindingContext = _model = new RezervacijaFinalStepViewModel(automobil, datumOd, datumDo);
            _selectedAutomobil = automobil;
            
            _datumOd = datumOd;
            _datumDo = datumDo;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (DatumOd.Date <= DateTime.Now.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Datum od mora biti veći od današnjeg datuma!", "U redu");
                return;
            }

            if (DatumDo.Date <= DatumOd.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Minimalno trajanje rezervacije je jedan dan!", "U redu");
                return;
            }



            bool success = await _model.IznajmiVozilo(_selectedAutomobil, DatumOd.Date, DatumDo.Date);

            if (success)
            {
                await Navigation.PushAsync(new AutomobiliPage());
            }
        }

        private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            // Datum Od

            if (DatumOd.Date <= DateTime.Now.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Datum od mora biti veći od današnjeg datuma!", "U redu");
                return;
            }
             

            _model.IzracunajCijenu(DatumOd.Date, DatumDo.Date);
        }

        private async void DatePicker_DateSelected_1(object sender, DateChangedEventArgs e)
        {
            // Datum Do
            if (DatumDo.Date <= DatumOd.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Minimalno trajanje rezervacije je jedan dan!", "U redu");
                return;
            }

            _model.IzracunajCijenu(DatumOd.Date, DatumDo.Date);
        }











    }
}