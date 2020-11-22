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
    public class ModeliService : BaseCRUDService<Model.Modeli, ModeliSearchRequest, Database.Modeli, ModeliUpsertRequest, ModeliUpsertRequest>
    {
        public ModeliService(_190151Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Modeli> Get(ModeliSearchRequest search)
        {
            var query = _context.Modeli.Include(x => x.Proizvodjac).AsQueryable();

            if (!string.IsNullOrEmpty(search.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            if(search.ProizvodjacId.HasValue && search.ProizvodjacId > 0)
            {
                query = query.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }

            var list = query.OrderBy(x => x.Proizvodjac.Naziv).ToList();
            return _mapper.Map<List<Model.Modeli>>(list);
        }
    }
}
