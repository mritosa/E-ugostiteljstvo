﻿using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class NamirnicaRepository : Repository<namirnica>
    {
        public NamirnicaRepository() : base(new DBModel())
        {
        }
       
        public override int Update(namirnica entity, bool saveChanges = true)
        {
            var namirnicaKatalog = Context.namirnica_u_katalogu.SingleOrDefault(c => c.id == entity.namirnica_u_katalogu_id);

            var namirnica = Entities.SingleOrDefault(p => p.namirnica_u_katalogu_id == entity.namirnica_u_katalogu_id && p.rok == entity.rok);
            namirnica.namirnica_u_katalogu = namirnicaKatalog;
            namirnica.kolicina -= entity.kolicina;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
      
        public IQueryable<namirnica> GetAll(int id)
        {
            var query = from p in Entities.Include("namirnica_u_katalogu")
                        where p.namirnica_u_katalogu_id == id
                        select p;
            return query;
        }

        public IQueryable<namirnica> GetNamirniceByKatalogId(int namirnica_id)
        {
            var today = DateTime.Today;

            var query = from p in Entities.Include("namirnica_u_katalogu")
                        where p.namirnica_u_katalogu_id == namirnica_id && p.rok >= today
                        select p;
            return query;
        }


        
        public override int Add(namirnica entity, bool saveChanges = true)
        {
            var namirnicaKatalog = Context.namirnica_u_katalogu.SingleOrDefault(c => c.id == entity.namirnica_u_katalogu_id);
            var _namirnica = new namirnica();

            var noviRok = entity.rok.AddDays(namirnicaKatalog.rok_uporabe);

            _namirnica.kolicina = entity.kolicina;
            _namirnica.rok = noviRok;
            _namirnica.namirnica_u_katalogu = namirnicaKatalog;


            Entities.Add(_namirnica);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }

        }

        
        public IQueryable<StavkaIzvjestajaBlizuRoka> GetNamirniceBlizuRoka()
        {
            var today = DateTime.Today;
            var date = today.AddDays(7);

            var query = from p in Context.namirnica_u_katalogu
                        join n in Context.namirnica on p.id equals n.namirnica_u_katalogu_id into pn
                        from n in pn.Where(x => x.rok >= today && x.rok <= date)
                        select new StavkaIzvjestajaBlizuRoka
                        {
                            id = n.id,
                            kolicina = n.kolicina,
                            rok = n.rok,
                            naziv = p.naziv

                        };
            return query;
        }
       
        public IQueryable<dynamic> GetNamirniceIstecenogRoka()
        {
            var today = DateTime.Today;

            var result = from p in Context.namirnica_u_katalogu
                         join n in Context.namirnica on p.id equals n.namirnica_u_katalogu_id into pn
                         from n in pn.Where(x => x.rok < DateTime.Today)
                         select new
                         {
                             p.id,
                             p.naziv,
                             istekao_rok = n.rok,
                             p.vrsta,
                             kolicina = n.kolicina,
                             p.mjerna_jedinica,
                             p.cijena,
                             iznos = n.kolicina * p.cijena
                         };
            
            return result;
        }
        
        public IQueryable<StavkaNarudzbenice> GetDostupneKolicineNamirnica()
        {
            var today = DateTime.Today;
            var result = from p in Context.namirnica_u_katalogu
                         join n in Context.namirnica on p.id equals n.namirnica_u_katalogu_id into pn
                         from n in pn.Where(x => x.rok >= DateTime.Today)
                         group n by p into g
                         where g.Key.optimalne_zalihe > g.Sum(x => x.kolicina)
                         select new StavkaNarudzbenice
                         {
                            Id =  g.Key.id,
                            Naziv = g.Key.naziv,
                            Vrsta = g.Key.vrsta,
                            Kolicina = g.Key.optimalne_zalihe - g.Sum(x => x.kolicina),
                            MjernaJedinica = g.Key.mjerna_jedinica,
                            Cijena = g.Key.cijena,
                            Iznos = (g.Key.optimalne_zalihe - g.Sum(x => x.kolicina)) * g.Key.cijena
                         };
           
            return result;
        }
    }
}
