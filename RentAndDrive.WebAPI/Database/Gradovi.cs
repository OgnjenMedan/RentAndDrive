using System;
using System.Collections.Generic;

namespace RentAndDrive.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Kupci = new HashSet<Kupci>();
        }
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzave Drzava { get; set; }
        public virtual ICollection<Kupci> Kupci { get; set; }
    }
}
