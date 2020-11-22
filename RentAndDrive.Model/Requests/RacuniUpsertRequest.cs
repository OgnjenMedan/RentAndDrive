using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class RacuniUpsertRequest
    {
        [Required]
        public int RezervacijaId { get; set; }
        [Required]
        public string BrojRacuna { get; set; }
        [Required]
        public decimal IznosRezervacijeAutomobila { get; set; }
        [Required]
        public DateTime DatumKreiranjaRacuna { get; set; }
        [Required]
        public decimal Pdv { get; set; }
        [Required]
        public decimal IznosSaPdv { get; set; }
        [Required]
        public int TrajanjeRerezvacije { get; set; }
        public bool Status { get; set; }
    }
}
