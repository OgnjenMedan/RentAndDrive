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
    public partial class RacunPage : ContentPage
    {
        private RacunViewModel model = null;
        public RacunPage(int rezervacijaId)
        {
            InitializeComponent();

            BindingContext = model = new RacunViewModel(rezervacijaId);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await model.Init();
        }
    }
}