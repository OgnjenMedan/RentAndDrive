using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.WebAPI.Services;

namespace RentAndDrive.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukeService _service;
        public PreporukeController(IPreporukeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Automobili> Get(int id)
        {
            return _service.Get(id);
        }
    }
}
