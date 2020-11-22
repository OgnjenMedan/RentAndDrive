using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class Kupci
    {
        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }
        public int? GradId { get; set; }
        public virtual Gradovi Grad { get; set; }
        public string KupacInfo { get { return $"{Ime} {Prezime} {KorisnickoIme}"; } }

        public override string ToString() => $"{Ime} {Prezime} - {KorisnickoIme}";

    }
}
