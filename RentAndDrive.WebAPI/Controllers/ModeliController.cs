using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    public class ModeliController : BaseCRUDController<Model.Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest>
    {
        public ModeliController(ICRUDService<Model.Modeli, ModeliSearchRequest, ModeliUpsertRequest, ModeliUpsertRequest> service) : base(service)
        {

        }
    }
}
