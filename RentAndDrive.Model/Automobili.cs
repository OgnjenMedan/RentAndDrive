using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class Automobili
    {
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

        public override string ToString() => $"{Model?.Proizvodjac?.Naziv} {Model?.Naziv}";
    }
}
