using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.WebAPI.Services;

namespace RentAndDrive.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : BaseController<Model.Uloge, object>
    {
        public UlogeController(IService<Model.Uloge, object> service) : base(service)
        {

        }
    }
}
