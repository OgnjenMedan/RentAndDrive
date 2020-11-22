using System;
using System.Collections.Generic;

namespace RentAndDrive.WebAPI.Database
{
    public partial class Proizvodjaci
    {
        public Proizvodjaci()
        {
            Modeli = new HashSet<Modeli>();
        }

        public int ProizvodjacId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Modeli> Modeli { get; set; }
    }
}
