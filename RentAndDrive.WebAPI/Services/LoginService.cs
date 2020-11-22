using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly _190151Context _context;
        private readonly IMapper _mapper;

        public LoginService(_190151Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Korisnici AuthenticateRadnik(string username, string password)
        {
            var user = _context.Korisnici.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var passwordHash = GenerateHash(user.LozinkaSalt, password);

                if (passwordHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }

            return null;
        }

        public Model.Korisnici AuthenticateKupac(string username, string password)
        {
            var user = _context.Kupci.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var passwordHash = GenerateHash(user.LozinkaSalt, password);

                if (passwordHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
