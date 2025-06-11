﻿using DataAccessLayer.Repositories;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class IskoristenostNamirnicaServices
    {

        public List<StavkaIskoristenostNamirnice> GetIskoristeneNamirniceByMonth(int month, int year)
        {
            using (var repo = new IskoristenostNamirnicaRepository())
            {
                return repo.GetIskoristeneNamirniceByMonth(month,year).ToList();
            }
        }
  
        public bool UpdateIskoristenostNamirnice(iskoristenost_namirnice nam)
        {
            bool isSuccessful = false;
            using (var repo = new IskoristenostNamirnicaRepository())
            {
                int affectedRows = repo.Update(nam);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public bool AddIskoristenostNamirnice(iskoristenost_namirnice _namirnica)
        {
            bool isSuccessful = false;
            using (var repo = new IskoristenostNamirnicaRepository())
            {
                int affectedRows = repo.Add(_namirnica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
