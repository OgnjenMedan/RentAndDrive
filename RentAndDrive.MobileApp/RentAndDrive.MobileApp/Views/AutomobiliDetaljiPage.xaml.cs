using RentAndDrive.MobileApp.ViewModels;
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
    public partial class AutomobiliDetaljiPage : ContentPage
    {
        AutomobiliDetaljiViewModel _model = null;
        Model.Automobili _automobil = null;
        DateTime _datumOd = DateTime.Now;
        DateTime _datumDo = DateTime.Now;
        public AutomobiliDetaljiPage(Model.Automobili automobil, DateTime datumOd, DateTime datumDo)
        {
            InitializeComponent();

            BindingContext = _model = new AutomobiliDetaljiViewModel() 
            {
                Automobil = automobil,
                DatumOd = datumOd,
                DatumDo = datumDo
            };

            _automobil = automobil;
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
            await Navigation.PushAsync(new RezervacijaFinalStep(_automobil, _datumOd, _datumDo));
        }

        private async void PreporuceniListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // ucitavanje detalja za preporuceni automobil
            
            var item = e.SelectedItem as Model.Automobili;

            await Navigation.PushAsync(new AutomobiliDetaljiPage(item, _datumOd, _datumDo));
        }
    }
}