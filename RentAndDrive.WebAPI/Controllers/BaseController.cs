using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentAndDrive.WebAPI.Services;

namespace RentAndDrive.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IService<T, TSearch> _service;
        public BaseController(IService<T, TSearch> service) => _service = service;

        [HttpGet]
        public ActionResult<List<T>> Get([FromQuery] TSearch search) => _service.Get(search);

        [HttpGet("{id}")]
        public T GetById(int id) => _service.GetById(id);
    }
}
