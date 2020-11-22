using System;
using System.Collections.Generic;

namespace RentAndDrive.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int AutomobilId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Automobili Automobil { get; set; }
        public virtual Kupci Kupac { get; set; }
    }
}
