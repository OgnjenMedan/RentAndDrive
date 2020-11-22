using AutoMapper;
using RentAndDrive.Model.Requests;
using Microsoft.EntityFrameworkCore;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public class OcjeneService : BaseCRUDService<Model.Ocjene, OcjeneSearchRequest, Database.Ocjene, OcjeneUpsertRequest, OcjeneUpsertRequest>
    {
        public OcjeneService(_190151Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Ocjene> Get(OcjeneSearchRequest search)
        {
            var query = _context.Ocjene.Include(x => x.Automobil).Include(x => x.Kupac).AsQueryable();

            if (search.AutomobilId.HasValue && search.AutomobilId > 0)
            {
                query = query.Where(x => x.AutomobilId == search.AutomobilId);
            }

            if (search.KupacId.HasValue && search.KupacId > 0)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjene>>(list);
        }

        public override Model.Ocjene Insert(OcjeneUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Ocjene>(request);
            _context.Ocjene.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Ocjene>(entity);
        }

    }
}
