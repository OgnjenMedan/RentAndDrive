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
    public partial class RezervacijePage : ContentPage
    {
        RezervacijeViewModel model = null;
        public RezervacijePage(bool statusRezervacije = false)
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel(statusRezervacije);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Rezervacije;

            await Navigation.PushAsync(new RezervacijeDetaljiPage(new RezervacijeDetaljiViewModel(item)));
        }

    }
}