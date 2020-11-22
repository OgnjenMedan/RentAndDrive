using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public class AutomobilService : BaseCRUDService<Model.Automobili, AutomobiliSearchRequest, Database.Automobili, AutomobiliUpsertRequest, AutomobiliUpsertRequest>
    {
        public AutomobilService(_190151Context context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.Automobili> Get(AutomobiliSearchRequest search)
        {
            var query = _context.Automobili.Include(x => x.Model).Include(x => x.Model.Proizvodjac).AsQueryable();

            if(search.Aktivno.HasValue && search.Aktivno.Value)
            {
                query = query.Where(x => x.Status);
            }

            if (search.ModelId != 0 && search.ModelId.HasValue)
                query = query.Where(x => x.ModelId == search.ModelId);

            if (search.ProizvodjacId != 0 && search.ProizvodjacId.HasValue)
                query = query.Where(x => x.Model.ProizvodjacId == search.ProizvodjacId);

            if (!string.IsNullOrEmpty(search.GodinaProizvodnje))
            {
                int godinaProizvodnje = 0;
                bool isNumber = int.TryParse(search.GodinaProizvodnje, out godinaProizvodnje);

                if (isNumber)
                    query = query.Where(x => x.GodinaProizvodnje == godinaProizvodnje);
            }

            if (search.Manualni && !search.Automatik)
            {
                query = query.Where(x => x.Transmisija.Equals("Manualni"));
            }

            if (search.Automatik && !search.Manualni)
            {
                query = query.Where(x => x.Transmisija.Equals("Automatik"));
            }

            if (!string.IsNullOrEmpty(search.Gorivo))
                query = query.Where(x => x.Gorivo.Equals(search.Gorivo));

            if (search.BrojVrata.HasValue && search.BrojVrata > 0)
                query = query.Where(x => x.BrojVrata == search.BrojVrata);

            var list = new List<Automobili>();

            if (search.SortirajSilazno.HasValue)
            {
                if (search.SortirajSilazno.Value)
                    list = query.OrderByDescending(x => x.Cijena).ToList();
                else
                    list = query.OrderBy(x => x.Cijena).ToList();
            } else
            {
                list = query.OrderBy(x => x.Model.Proizvodjac.Naziv).ToList();
            }

            if (search.DatumOd.HasValue && search.DatumDo.HasValue)
            {
                DateTime Od = (DateTime)search.DatumOd;
                DateTime Do = (DateTime)search.DatumDo;

                var rezervisaniAutomobili = _context.Rezervacije.Where(x =>
                    (x.DatumPreuzimanja.Date >= Od.Date && x.DatumPreuzimanja.Date <= Do.Date) ||
                    (x.DatumPovrata.Date >= Od.Date && x.DatumPovrata.Date <= Do.Date)).ToList();

                list.RemoveAll(x => rezervisaniAutomobili.Any(y => x.AutomobilId == y.AutomobilId));
            }


            return _mapper.Map<List<Model.Automobili>>(list);
        }

        public override Model.Automobili GetById(int id)
        {
            var entity = _context.Automobili.Include(x => x.Model.Proizvodjac).Include(x => x.Model).Where(x => x.AutomobilId == id).FirstOrDefault();

            return _mapper.Map<Model.Automobili>(entity);
        }
    }
}
