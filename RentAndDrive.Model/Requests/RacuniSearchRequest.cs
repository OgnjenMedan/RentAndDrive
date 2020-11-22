using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class RacuniSearchRequest
    {
        public string KorisnickoIme { get; set; }
        public string BrojRacuna { get; set; }
        public int? RezervacijaId { get; set; }
    }
}
