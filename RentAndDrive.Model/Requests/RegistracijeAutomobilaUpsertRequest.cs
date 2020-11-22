using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class RegistracijeAutomobilaUpsertRequest
    {
        [Required]
        public int RadnikId { get; set; }
        [Required]
        public int AutomobilId { get; set; }
        [Required]
        public string RegistarskeTablice { get; set; }
        [Required]
        public DateTime PocetakRegistracije { get; set; }
        [Required]
        public DateTime KrajRegistracije { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
