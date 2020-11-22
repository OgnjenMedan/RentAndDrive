using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model
{
    public class Racuni
    {
        public int RacunId { get; set; }
        public int RezervacijaId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumKreiranjaRacuna { get; set; }
        public int TrajanjeRerezvacije { get; set; }
        public decimal IznosRezervacijeAutomobila { get; set; }
        public decimal Pdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public bool Status { get; set; }

        public virtual Rezervacije Rezervacija { get; set; }
        public string Automobil { get { return $"{Rezervacija?.Automobil.Model.Naziv ?? " "}"; } }
        public string KorisnickoIme { get { return $"{Rezervacija?.Kupac.KorisnickoIme ?? " "}"; } }
    }
}
