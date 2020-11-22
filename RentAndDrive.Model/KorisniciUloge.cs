using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; } 
        public Uloge Uloga { get; set; }
    }
}
