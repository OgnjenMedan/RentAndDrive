using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public class BaseService<T, TSearch, TDatabase> : IService<T, TSearch> where TDatabase : class
    {
        protected readonly _190151Context _context;
        protected readonly IMapper _mapper;

        public BaseService(_190151Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<T> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var entity = _context.Set<TDatabase>().ToList();

            return _mapper.Map<T>(entity);
        }
    }
}
