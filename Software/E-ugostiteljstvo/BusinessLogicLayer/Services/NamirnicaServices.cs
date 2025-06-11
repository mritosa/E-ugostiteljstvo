using DataAccessLayer.Repositories;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class NamirnicaServices
    {

        public List<namirnica> GetAll(int id)
        {
            using (var repo = new NamirnicaRepository())
            {
                return repo.GetAll(id).ToList();
            }
        }
  
        public List<dynamic> GetNamirniceIstecenogRoka()
        {
            using (var repo = new NamirnicaRepository())
            {
                return repo.GetNamirniceIstecenogRoka().ToList();
            }
        }

        public List<namirnica> GetNamirniceUSkladistu(int namirnica_id)
        {
            using (var repo = new NamirnicaRepository())
            {
                return repo.GetNamirniceByKatalogId(namirnica_id).ToList();
            }
        }

        public List<StavkaIzvjestajaBlizuRoka> GetNamirniceBlizuRoka()
        {
            using (var repo = new NamirnicaRepository())
            {
                return repo.GetNamirniceBlizuRoka().ToList();
            }
        }

        public List<StavkaNarudzbenice> GetDostupneKolicineNamirnica()
        {
            using (var repo = new NamirnicaRepository())
            {
                return repo.GetDostupneKolicineNamirnica().ToList();
            }
        }

        public bool UpdateNamirnica(namirnica product)
        {
            bool isSuccessful = false;
            using (var repo = new NamirnicaRepository())
            {
                int affectedRows = repo.Update(product);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
   
        public bool AddNamirnica(namirnica _namirnica)
        {
            bool isSuccessful = false;
            using (var repo = new NamirnicaRepository())
            {
                int affectedRows = repo.Add(_namirnica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
