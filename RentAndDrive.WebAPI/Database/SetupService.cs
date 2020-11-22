using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Database
{
    public class SetupService
    {
        public static void Init(_190151Context context)
        {
            context.Database.Migrate();
        }
    }
}
