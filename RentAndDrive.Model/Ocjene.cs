using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }
        public int AutomobilId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public virtual Kupci Kupac { get; set; }
        public virtual Automobili Automobili { get; set; }
    }
}
