using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.MobileApp.Models
{
    public enum MenuItemType
    {
        Automobili,
        Rezervacije,
        IstorijaRezervacija,
        Profil,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
