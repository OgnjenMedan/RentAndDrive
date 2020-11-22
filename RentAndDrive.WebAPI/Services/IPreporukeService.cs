using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public interface IPreporukeService
    {
        List<Model.Automobili> Get(int id);
    }
}
