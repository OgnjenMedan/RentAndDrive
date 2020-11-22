using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public interface ILoginService
    {
        Model.Korisnici AuthenticateRadnik(string username, string password);
        Model.Korisnici AuthenticateKupac(string username, string password);
    }
}
