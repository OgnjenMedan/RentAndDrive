using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service): base(service) => _service = service;

        [HttpPost]
        public T Insert(TInsert request) => _service.Insert(request);

        [HttpPut("{id}")]
        public T Update(int id, [FromBody]TUpdate request) => _service.Update(id, request);

        [HttpDelete("{id}")]
        public T Delete(int id) => _service.Delete(id);
    }
}
