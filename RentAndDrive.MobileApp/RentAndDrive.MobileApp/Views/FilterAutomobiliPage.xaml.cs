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
    public partial class FilterAutomobiliPage : ContentPage
    {
        public AutomobiliFilterViewModel _model = null;
        private DateTime _datumOd;
        private DateTime _datumDo;
        public FilterAutomobiliPage()
        {
            InitializeComponent();
            BindingContext = _model = new AutomobiliFilterViewModel();
        }

        public FilterAutomobiliPage(DateTime datumOd, DateTime datumDo)
        {
            InitializeComponent();
            BindingContext = _model = new AutomobiliFilterViewModel();

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
            AutomobiliSearchRequest searchFilter = new AutomobiliSearchRequest()
            {
                Automatik = MjenjacAutomatik.IsChecked,
                Manualni = MjenjacManualni.IsChecked,
                SortirajSilazno = SortirajSilazno.IsToggled,
                ProizvodjacId = _model.SelectedProizvodjac?.ProizvodjacId,
                ModelId = _model.SelectedModel?.ModelId,
                Gorivo = _model.SelectedTipGoriva,
                BrojVrata = _model.SelectedBrojVrata,
                DatumOd = _datumOd,
                DatumDo = _datumDo
            };

            if(!string.IsNullOrEmpty(_model.CijenaOd))
            {
                if (decimal.TryParse(_model.CijenaOd, out decimal cijenaOd))
                {
                    searchFilter.CijenaOd = cijenaOd;
                }
            }

            if (!string.IsNullOrEmpty(_model.CijenaDo))
            {
                if (decimal.TryParse(_model.CijenaDo, out decimal cijenaDo))
                {
                    searchFilter.CijenaDo = cijenaDo;
                }
            }

            await Navigation.PushAsync(new AutomobiliPage(searchFilter));
        }

        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;

            var proizvodjac = (Model.Proizvodjaci)picker.SelectedItem;

            await _model.FillModeliList(proizvodjac.ProizvodjacId);
        }

    }
}