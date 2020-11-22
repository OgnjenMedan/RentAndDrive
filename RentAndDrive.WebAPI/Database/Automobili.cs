using System;
using System.Collections.Generic;

namespace RentAndDrive.WebAPI.Database
{
    public partial class Automobili
    {
        public Automobili()
        {
            Ocjene = new HashSet<Ocjene>();
            RegistracijeAutomobila = new HashSet<RegistracijeAutomobila>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int AutomobilId { get; set; }
        public int ModelId { get; set; }
        public decimal Cijena { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Gorivo { get; set; }
        public int Snaga { get; set; }
        public string Transmisija { get; set; }
        public int BrojVrata { get; set; }
        public int BrojSjedista { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public virtual Modeli Model { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
        public virtual ICollection<RegistracijeAutomobila> RegistracijeAutomobila { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
