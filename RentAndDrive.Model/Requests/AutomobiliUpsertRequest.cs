using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class AutomobiliUpsertRequest
    {
        [Required]
        public int ModelId { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public int GodinaProizvodnje { get; set; }
        [Required]
        public string Gorivo { get; set; }
        [Required]
        public int Snaga { get; set; }
        [Required]
        public string Transmisija { get; set; }
        [Required]
        public int BrojVrata { get; set; }
        [Required]
        public int BrojSjedista { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public byte[] SlikaThumb { get; set; }
    }
}
