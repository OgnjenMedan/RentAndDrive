using AutoMapper;
using RentAndDrive.Model;
using RentAndDrive.WebAPI.Database;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RentAndDrive.WebAPI.Services
{
    public class PreporukeService : IPreporukeService
    {
        private readonly _190151Context _context;
        private readonly IMapper _mapper;
        Dictionary<int, List<Database.Ocjene>> automobili = new Dictionary<int, List<Database.Ocjene>>();

        public PreporukeService(_190151Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Automobili> Get(int id)
        {
            UcitajAutomobile(id);

            List<Database.Ocjene> ocjenePosmatranogAutomobila = _context.Ocjene.Where(x => x.AutomobilId == id).OrderBy(x => x.KupacId).ToList();
            List<Database.Ocjene> zajednickeOcjene1 = new List<Database.Ocjene>();
            List<Database.Ocjene> zajednickeOcjene2 = new List<Database.Ocjene>();
            List<Model.Automobili> preporuceniAutomobili = new List<Model.Automobili>();

            foreach (var item in automobili)
            {
                foreach (Database.Ocjene ocjena in ocjenePosmatranogAutomobila)
                {
                    if (item.Value.Where(x=>x.KupacId == ocjena.KupacId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(ocjena);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KupacId == ocjena.KupacId).First());
                    }
                }

                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);

                if (slicnost > 0.5)
                {
                    var temp = _context.Automobili.Find(item.Key);
                    Model.Automobili automobilTemp = _mapper.Map<Model.Automobili>(temp);
                    preporuceniAutomobili.Add(automobilTemp);
                }

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniAutomobili;
        }

        private double GetSlicnost(List<Database.Ocjene> zajednickeOcjene1, List<Database.Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;
            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik += zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 += zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 += zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
            {
                return 0;
            } else
            {
                return brojnik / nazivnik;
            }
        }


        private void UcitajAutomobile(int id)
        {
            List<Database.Automobili> ostaliAutomobili = _context.Automobili
                .Include(x => x.Model)
                .Include(x => x.Model.Proizvodjac)
                .Where(x => x.AutomobilId != id && x.Status)
                .ToList();
            List<Database.Ocjene> ocjene;
            foreach (Database.Automobili item in ostaliAutomobili)
            {
                ocjene = _context.Ocjene.Where(x => x.AutomobilId == item.AutomobilId).OrderBy(x => x.KupacId).ToList();
                if (ocjene.Count > 0)
                    automobili.Add(item.AutomobilId, ocjene);
            }
        }
    }
}
