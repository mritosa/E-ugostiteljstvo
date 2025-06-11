﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.Entities;

namespace DataAccessLayer.Repositories
{
    
    public class UlogaRepository : Repository<uloga>
    {
        public UlogaRepository() : base(new DBModel())
        {
        }

        public override int Update(uloga entity, bool saveChanges = true)
        {
            var uloga = Entities.SingleOrDefault(c => c.id == entity.id);

            uloga.naziv = entity.naziv;
            uloga.opis = entity.opis;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
