using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.WebAPI.Services;

namespace RentAndDrive.WebAPI.Controllers
{
    public class GradoviController : BaseController<Model.Gradovi, object>
    {
        public GradoviController(IService<Model.Gradovi, object> service) : base(service)
        {

        }
    }
}
