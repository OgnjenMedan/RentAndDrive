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
    public partial class RezervacijeDetaljiPage : ContentPage
    {
        private RezervacijeDetaljiViewModel _model = null;
        public RezervacijeDetaljiPage(RezervacijeDetaljiViewModel model)
        {
            InitializeComponent();
            BindingContext = _model = model;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _model.Init();

            var isOcjenjen = await _model.IsOcjenjen();

            if(!isOcjenjen && _model.Rezervacija.Status)
            {
                OcjenaStackLayout.IsVisible = true;
            }

            OtkaziRezervacijuButton.IsVisible = !_model.Rezervacija.Status;
            OtkaziRezervacijuButton.SetBinding(IsVisibleProperty, nameof(_model.ButtonVisibility));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await _model.OtkaziRezervaciju();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var item = ((Button)sender).BindingContext as Rezervacije;

            int _rezervacijaId = item.RezervacijaId;
            Navigation.PushAsync(new RacunPage(_rezervacijaId));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            // Click za ocjenjivanje

            bool isSuccess = await _model.OcijeniAutomobil();
            if (isSuccess)
            {
                OcjenaStackLayout.IsVisible = false;
            }
        }
    }
}