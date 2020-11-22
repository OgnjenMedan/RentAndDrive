using RentAndDrive.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentAndDrive.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private KupacViewModel model = null;
        public ProfilePage()
        {
            InitializeComponent();

            BindingContext = model = new KupacViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.FillGradoviList();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (model == null)
                return;

            if (IsValidateText(Ime) && IsValidateText(Prezime) && IsValidateText(Password) && Email_Validating() && Telefon_Validating() && Lozinka_Validating())
            {
                if (!await model.txtEmail_Validating())
                {
                    Email.Placeholder = "Email već postoji!";
                    Email.PlaceholderColor = Color.FromHex("#ff4d4d");
                    Email.Text = string.Empty;
                } else
                {
                    await model.Edit();
                }
            }
        }


        private bool Lozinka_Validating()
        {
            if (NewPassword.Text != PasswordConfirm.Text)
            {
                Password.TextColor = Color.FromHex("#ff4d4d");
                Password.Placeholder = "Obavezno polje!";
                Password.PlaceholderColor = Color.FromHex("#ff4d4d");

                PasswordConfirm.TextColor = Color.FromHex("#ff4d4d");
                PasswordConfirm.Placeholder = "Obavezno polje!";
                PasswordConfirm.PlaceholderColor = Color.FromHex("#ff4d4d");
                return false;
            }
            return true;
        }

        private bool Email_Validating()
        {
            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                Email.Placeholder = "Obavezno polje!";
                Email.PlaceholderColor = Color.FromHex("#ff4d4d");
                return false;
            } else if (!Regex.IsMatch(Email.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                Email.TextColor = Color.FromHex("#ff4d4d");
                return false;
            } else
            {
                return true;
            }
        }

        private bool Telefon_Validating()
        {
            if (string.IsNullOrWhiteSpace(Telefon.Text))
            {
                Telefon.Placeholder = "Obavezno polje!";
                Telefon.PlaceholderColor = Color.FromHex("#ff4d4d");
                return false;
            } else if (!Regex.IsMatch(Telefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}$") && !Regex.IsMatch(Telefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{4}$"))
            {
                Telefon.TextColor = Color.FromHex("#ff4d4d");
                return false;
            } else
            {
                return true;
            }
        }

        private bool IsValidateText(Entry entry)
        {
            if (string.IsNullOrEmpty(entry.Text))
            {
                entry.Placeholder = "Obavezno polje!";
                entry.PlaceholderColor = Color.FromHex("#ff4d4d");
                return false;
            }
            return true;
        }
    }
}