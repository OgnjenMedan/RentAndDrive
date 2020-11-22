using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Controllers
{
    public class AutomobiliController: BaseCRUDController<Model.Automobili, AutomobiliSearchRequest, AutomobiliUpsertRequest, AutomobiliUpsertRequest>
    {
        public AutomobiliController(ICRUDService<Model.Automobili, AutomobiliSearchRequest, AutomobiliUpsertRequest, AutomobiliUpsertRequest> service): base(service)
        {

        }
    }
}
