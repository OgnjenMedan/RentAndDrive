using System;
using System.Collections.Generic;

namespace RentAndDrive.WebAPI.Database
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            Racuni = new HashSet<Racuni>();
        }

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
        public virtual ICollection<Racuni> Racuni { get; set; }
    }
}
