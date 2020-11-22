using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class RezervacijeUpsertRequest
    {
        [Required]
        public int KupacId { get; set; }
        [Required]
        public int AutomobilId { get; set; }
        [Required]
        public DateTime DatumPreuzimanja { get; set; }
        [Required]
        public DateTime DatumPovrata { get; set; }
        [Required]
        public DateTime DatumKreiranjaRezervacije { get; set; }
        public string Napomena { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
