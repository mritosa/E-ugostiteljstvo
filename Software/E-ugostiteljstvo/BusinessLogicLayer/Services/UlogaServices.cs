using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{

    public class UlogaServices
    {
        public List<uloga> GetUloge()
        {
            using (var repo = new UlogaRepository())
            {
                return repo.GetAll().ToList();
            }
        }
    }
}
