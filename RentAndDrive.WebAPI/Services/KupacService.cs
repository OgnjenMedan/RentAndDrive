using AutoMapper;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace RentAndDrive.WebAPI.Services
{
    public class KupacService : IKupacService
    {
        private readonly _190151Context _context;
        private readonly IMapper _mapper;

        public KupacService(_190151Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Kupci> Get(KupciSearchRequest request)
        {
            var query = _context.Kupci.Include(x => x.Grad).Include(x => x.Grad.Drzava).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Equals(request.KorisnickoIme));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Kupci>>(list);
        }

        public Model.Kupci GetById(int id)
        {
            var entity = _context.Kupci.Find(id);
            return _mapper.Map<Model.Kupci>(entity);
        }

        public Model.Kupci Insert(KupciUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Kupci>(request);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Lozinka i potvrda lozinke se ne slažu!");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Kupci.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(entity);
        }

        public Model.Kupci Update(int id, KupciUpsertRequest request)
        {
            var entity = _context.Kupci.Find(id);

            _mapper.Map(request, entity);

            _context.Kupci.Attach(entity);
            _context.Kupci.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirm)
                {
                    throw new Exception("Lozinka i potvrda lozinke se ne slažu!");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(entity);
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

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Kupci Authenticiraj(string username, string pass)
        {
            var user = _context.Kupci.FirstOrDefault(x => x.KorisnickoIme == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);
                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Kupci>(user);
                }
            }
            return null;
        }
    }
}
