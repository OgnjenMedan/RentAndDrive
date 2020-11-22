using System;
using System.Collections.Generic;

namespace RentAndDrive.WebAPI.Database
{
    public partial class Modeli
    {
        public Modeli()
        {
            Automobili = new HashSet<Automobili>();
        }

        public int ModelId { get; set; }
        public string Naziv { get; set; }
        public int ProizvodjacId { get; set; }

        public virtual Proizvodjaci Proizvodjac { get; set; }
        public virtual ICollection<Automobili> Automobili { get; set; }
    }
}
