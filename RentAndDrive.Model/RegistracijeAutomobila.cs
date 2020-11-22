using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class RegistracijeAutomobila
    {
        public int RegistracijaId { get; set; }
        public int RadnikId { get; set; }
        public int AutomobilId { get; set; }
        public string RegistarskeTablice { get; set; }
        public DateTime PocetakRegistracije { get; set; }
        public DateTime KrajRegistracije { get; set; }
        public decimal Cijena { get; set; }
        public bool Status { get; set; }

        public virtual Automobili Automobil { get; set; }
        public virtual Korisnici Radnik { get; set; }
    }
}
