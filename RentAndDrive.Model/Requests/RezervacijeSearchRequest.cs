using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? ProizvodjacId { get; set; }
        public DateTime? Od { get; set; }
        public DateTime? Do { get; set; }
        public bool Status { get; set; }
        public int? KupacId { get; set; }
    }
}
