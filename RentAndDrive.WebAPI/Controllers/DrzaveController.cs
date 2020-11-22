using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    public class DrzaveController : BaseCRUDController<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveController(ICRUDService<Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest> service) : base(service)
        {
        }
    }
}
