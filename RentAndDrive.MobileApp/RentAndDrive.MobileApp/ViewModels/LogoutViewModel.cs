using RentAndDrive.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentAndDrive.MobileApp.ViewModels
{
    public class LogoutViewModel
    {
        public ICommand InitCommand { get; set; }

        public LogoutViewModel()
        {

            InitCommand = new Command(() => Init());
        }

        public void Init()
        {
            APIService.Username = string.Empty;
            APIService.Password = string.Empty;
            Application.Current.MainPage = new LoginPage();
        }
    }
}
