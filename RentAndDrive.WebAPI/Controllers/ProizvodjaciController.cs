using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    public class ProizvodjaciController : BaseCRUDController<Model.Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest>
    {
        public ProizvodjaciController(ICRUDService<Model.Proizvodjaci, object, ProizvodjaciUpsertRequest, ProizvodjaciUpsertRequest> service) : base(service)
        {

        }
    }
}
