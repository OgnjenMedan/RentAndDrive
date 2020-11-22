using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;

namespace RentAndDrive.WebAPI.Controllers
{
    public class OcjeneController : BaseCRUDController<Model.Ocjene, OcjeneSearchRequest, OcjeneUpsertRequest, OcjeneUpsertRequest>
    {
        public OcjeneController(ICRUDService<Model.Ocjene, OcjeneSearchRequest, OcjeneUpsertRequest, OcjeneUpsertRequest> service) : base(service)
        {
        }
    }
}
