using System;
using System.Collections.Generic;
using System.Text;

namespace RentAndDrive.Model.Requests
{
    public class AutomobiliSearchRequest
    {
        public int? ModelId { get; set; }
        public int? ProizvodjacId { get; set; }
        public string GodinaProizvodnje { get; set; }
        public string Gorivo { get; set; }
        public int? BrojVrata { get; set; }
        public bool Automatik { get; set; }
        public bool Manualni { get; set; }
        public decimal? CijenaOd { get; set; }
        public decimal? CijenaDo { get; set; }
        public bool? SortirajSilazno { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public bool? Aktivno { get; set; }
    }
}
