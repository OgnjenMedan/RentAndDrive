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
    public partial class LogoutPage : ContentPage
    {
        private LogoutViewModel mode = null;
        public LogoutPage()
        {
            InitializeComponent();
            BindingContext = mode = new LogoutViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            mode.Init();
        }
    }
}