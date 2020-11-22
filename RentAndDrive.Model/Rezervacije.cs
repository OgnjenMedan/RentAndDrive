using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public int KupacId { get; set; }
        public int AutomobilId { get; set; }
        public DateTime DatumPreuzimanja { get; set; }
        public DateTime DatumPovrata { get; set; }
        public DateTime DatumKreiranjaRezervacije { get; set; }
        public string Napomena { get; set; }
        public bool Status { get; set; }

        public virtual Automobili Automobil { get; set; }
        public virtual Kupci Kupac { get; set; }
    }
}
