using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KupciController : ControllerBase
    {
        private readonly IKupacService _service;
        public KupciController(IKupacService service) => _service = service;
 
        [HttpGet]
        public List<Model.Kupci> Get([FromQuery] KupciSearchRequest request) => _service.Get(request);

        //[Authorize]
        [HttpGet("{id}")]
        public Model.Kupci GetById(int id) => _service.GetById(id); 
        
        [HttpPost]
        public Model.Kupci Insert(KupciUpsertRequest request) => _service.Insert(request);

        [Authorize]
        [HttpPut("{id}")]
        public Model.Kupci Update(int id, [FromBody] KupciUpsertRequest request) => _service.Update(id, request);
        
    }
}
