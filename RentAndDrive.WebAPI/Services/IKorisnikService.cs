using RentAndDrive.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public interface IKorisnikService
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);
        Model.Korisnici GetById(int id);
        Model.Korisnici Insert(KorisniciUpsertRequest request);
        Model.Korisnici Update(int id, KorisniciUpsertRequest request);
        Model.Korisnici Authenticiraj(string username, string pass);
    }
}
