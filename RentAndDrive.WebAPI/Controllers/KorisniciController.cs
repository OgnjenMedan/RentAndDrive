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
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisnikService _service;

        public KorisniciController(IKorisnikService service) => _service = service;

        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery] KorisniciSearchRequest request) => _service.Get(request);

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id) => _service.GetById(id);

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Korisnici Insert(KorisniciUpsertRequest request) => _service.Insert(request);

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, [FromBody]KorisniciUpsertRequest request) => _service.Update(id, request);
    }
}
