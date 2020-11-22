using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using RentAndDrive.Model;
using RentAndDrive.Model.Requests;
using RentAndDrive.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Services
{
    public class KorisnikService : IKorisnikService
    {
        private readonly _190151Context _context;
        private readonly IMapper _mapper;

        public KorisnikService(_190151Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.Include(x => x.KorisniciUloge).ThenInclude(x => x.Uloga).AsQueryable();

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

            if (request.isAdmin.HasValue && request.isAdmin.Value)
            {
                query = query.Where(x => x.KorisniciUloge.Any(y => y.Uloga.Naziv.StartsWith("Admin")));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Include(x => x.KorisniciUloge).ThenInclude(x => x.Uloga).Where(x => x.KorisnikId == id).FirstOrDefault();
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Lozinka i potvrda lozinke se ne slažu.");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge()
                {
                    KorisnikId = entity.KorisnikId,
                    UlogaId = uloga
                };

                _context.KorisniciUloge.Add(korisniciUloge);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciUpsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            
            _mapper.Map(request, entity);

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            var korisnickeUloge = _context.KorisniciUloge.Where(x => x.KorisnikId == id).ToList();
            
            foreach (var item in korisnickeUloge)
            {
                _context.KorisniciUloge.Remove(item);
            }
            
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge
                {
                    KorisnikId = entity.KorisnikId,
                    UlogaId = uloga,
                };

                _context.KorisniciUloge.Add(korisniciUloge);
            }

            _context.SaveChanges();

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirm)
                {
                    throw new Exception("Lozinka i potvrda lozinke se ne slažu.");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
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



        public Model.Korisnici Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.FirstOrDefault(x => x.KorisnickoIme == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);
                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            return null;
        }
    }
}
