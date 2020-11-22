using AutoMapper;
using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Automobili, Model.Automobili>();
            CreateMap<Database.Drzave, Model.Drzave>();
            CreateMap<Database.Gradovi, Model.Gradovi>();
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.Kupci, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Kupci, Model.Kupci>().ReverseMap();
            CreateMap<Database.Modeli, Model.Modeli>();
            CreateMap<Database.Ocjene, Model.Ocjene>().ReverseMap();
            CreateMap<Database.Proizvodjaci, Model.Proizvodjaci>();
            CreateMap<Database.Racuni, Model.Racuni>();
            CreateMap<Database.RegistracijeAutomobila, Model.RegistracijeAutomobila>();
            CreateMap<Database.Rezervacije, Model.Rezervacije>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.Uloge, Model.Uloge>().ReverseMap();

            CreateMap<AutomobiliUpsertRequest, Database.Automobili>();
            CreateMap<DrzaveUpsertRequest, Database.Drzave>();
            CreateMap<GradoviUpsertRequest, Database.Gradovi>();
            CreateMap<KorisniciUpsertRequest, Database.Korisnici>().ReverseMap();
            CreateMap<KupciUpsertRequest, Database.Kupci>();
            CreateMap<ModeliUpsertRequest, Database.Modeli>();
            CreateMap<OcjeneUpsertRequest, Database.Ocjene>();
            CreateMap<ProizvodjaciUpsertRequest, Database.Proizvodjaci>();
            CreateMap<RacuniUpsertRequest, Database.Racuni>();
            CreateMap<RegistracijeAutomobilaUpsertRequest, Database.RegistracijeAutomobila>();
            CreateMap<RezervacijeUpsertRequest, Database.Rezervacije>();
        }
    }
}
