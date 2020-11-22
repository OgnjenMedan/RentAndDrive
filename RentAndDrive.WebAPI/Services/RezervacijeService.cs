using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public class RezervacijeService : BaseCRUDService<Model.Rezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijeService(_190151Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Rezervacije> Get(RezervacijeSearchRequest search)
        {
            var query = _context.Rezervacije
                .Include(x => x.Automobil.Model)
                .Include(x => x.Automobil.Model.Proizvodjac)
                .Include(x => x.Kupac)
                .Where(x => x.Status == search.Status).AsQueryable();

            if (search.ProizvodjacId.HasValue && search.ProizvodjacId != 0)
            {
                query = query.Where(x => x.Automobil.Model.ProizvodjacId == search.ProizvodjacId);
            }

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Kupac.Ime.Equals(search.Ime));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Kupac.Prezime.Equals(search.Prezime));
            }
            
            if (search.Do.HasValue && search.Od.HasValue)
            {
                query = query.Where(x => x.DatumPreuzimanja >= search.Od && x.DatumPovrata <= search.Do);
            }

            if (search.KupacId.HasValue && search.KupacId != 0)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

            var list = query.OrderByDescending(x => x.DatumKreiranjaRezervacije).ToList();

            return _mapper.Map<List<Model.Rezervacije>>(list);
        }

        public override Model.Rezervacije GetById(int id)
        {
            var entity = _context.Rezervacije.Include(x => x.Kupac).Include(x => x.Automobil.Model).Where(x => x.RezervacijaId == id).FirstOrDefault();
            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public override Model.Rezervacije Insert(RezervacijeUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Rezervacije>(request);
            _context.Rezervacije.Add(entity);
            _context.SaveChanges();

            GenerisiRacun(entity.RezervacijaId);

            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public override Model.Rezervacije Update(int id, RezervacijeUpsertRequest request)
        {
            var entity = _context.Rezervacije.Find(id);

            _mapper.Map(request, entity);

            _context.Rezervacije.Attach(entity);
            _context.Rezervacije.Update(entity);
            
            _context.SaveChanges();            

            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public void GenerisiRacun(int RezervacijaId)
        {
            var rezervacija = _context.Rezervacije.Include(x => x.Automobil).Include(x => x.Kupac).Where(x => x.RezervacijaId == RezervacijaId).FirstOrDefault();
            int totalDays = (int)(rezervacija.DatumPovrata.Date - rezervacija.DatumPreuzimanja.Date).TotalDays;
            var ukupnoCijenaVozila = rezervacija.Automobil.Cijena * totalDays;
            var PDV = (decimal)0.17;
            var iznosSPdv = ukupnoCijenaVozila + (ukupnoCijenaVozila * PDV);
            
            string guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            string brojRacuna = guid.Replace("=", "").Replace("+", "").Replace("/", "");

            var racun = new Database.Racuni
            {
                BrojRacuna = brojRacuna,
                RezervacijaId = rezervacija.RezervacijaId,
                DatumKreiranjaRacuna = DateTime.Now,
                IznosRezervacijeAutomobila = ukupnoCijenaVozila,
                Pdv = PDV,
                IznosSaPdv = iznosSPdv,
                TrajanjeRerezvacije = totalDays,
                Status = true
            };

            _context.Racuni.Add(racun);
            _context.SaveChanges();
        }

    }
}
