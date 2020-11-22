using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public interface IKupacService
    {
        List<Model.Kupci> Get(KupciSearchRequest request);
        Model.Kupci GetById(int id);
        Model.Kupci Insert(KupciUpsertRequest request);
        Model.Kupci Update(int id, KupciUpsertRequest request);
        Model.Kupci Authenticiraj(string username, string password);

    }
}
