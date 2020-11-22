using RentAndDrive.MobileApp.ViewModels;
using RentAndDrive.Model.Requests;
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
    public partial class AutomobiliPage : ContentPage
    {
        private AutomobiliViewModel model = null;
        private AutomobiliSearchRequest _searchFilter = null;
        public AutomobiliPage()
        {
            InitializeComponent();
            BindingContext = model = new AutomobiliViewModel();
        }
        public AutomobiliPage(AutomobiliSearchRequest request)
        {
            InitializeComponent();
            BindingContext = model = new AutomobiliViewModel();
            if (request != null)
            {
                _searchFilter = request;
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (_searchFilter != null)
            {
                await model.Init(_searchFilter);

                DatumOd.Date = (DateTime)_searchFilter.DatumOd;
                DatumDo.Date = (DateTime)_searchFilter.DatumDo;
            } else
            {
                DatumOd.Date = DateTime.Now.AddDays(1);
                DatumDo.Date = DatumOd.Date.AddDays(1);
            }
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Automobili;
            if (item == null)
                return;


            if (DatumOd.Date <= DateTime.Now.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Datum od mora biti veći od današnjeg datuma!", "U redu");
                ItemsListView.SelectedItem = null;
                return;
            }

            if (DatumDo.Date <= DatumOd.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Minimalno trajanje rezervacije je jedan dan!", "U redu");
                ItemsListView.SelectedItem = null;
                return;
            }

            await Navigation.PushAsync(new AutomobiliDetaljiPage(item, DatumOd.Date, DatumDo.Date));
            ItemsListView.SelectedItem = null;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterAutomobiliPage(DatumOd.Date, DatumDo.Date));
        }

        private async void DatumDo_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (DatumDo.Date <= DatumOd.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Minimalno trajanje rezervacije je jedan dan!", "U redu");
                return;
            }

            if (_searchFilter != null)
            {
                await model.Init(_searchFilter);
            } else
            {
                AutomobiliSearchRequest request = new AutomobiliSearchRequest()
                {
                    DatumOd = DatumOd.Date,
                    DatumDo = DatumDo.Date,
                };

                await model.Init(request);
            }
        }

        private async void DatumOd_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (DatumOd.Date <= DateTime.Now.Date)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Datum početka rezervacije mora biti veći od današnjeg datuma!", "U redu");
                return;
            }
        }

    }
}