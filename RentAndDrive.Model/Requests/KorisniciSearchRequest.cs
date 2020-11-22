using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool? isAdmin { get; set; }
        public string KorisnickoIme { get; set; }

    }
}
