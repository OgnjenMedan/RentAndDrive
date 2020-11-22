using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    public class RacuniController : BaseCRUDController<Model.Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest>
    {
        public RacuniController(ICRUDService<Model.Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest> service): base(service)
        {

        }
    }
}
