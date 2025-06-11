using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public class ZaposlenikServices
    {
    
        public bool AddZaposlenik(zaposlenik _zaposlenik)
        {
            bool isSuccessful = false;
            using (var repo = new ZaposlenikRepository())
            {
                int affectedRows = repo.Add(_zaposlenik);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<zaposlenik> GetZaposlenici()
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetAll().ToList();
            }
        }

        public object GetZaposlenikById(int id)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikById(id);
            }
        }

        public zaposlenik GetZaposlenikByEmail(string phrase)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikByEmail(phrase);
            }
        }

        public zaposlenik GetZaposlenikNarudzbenice(int zaposlenikId)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikZaNarzdzbenicu(zaposlenikId);
            }
        }
       
        public bool PasswordStrenght(string password) {
            if (string.IsNullOrEmpty(password) || password.Length < 8) {
                return false;
            }

            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasDigit = false;
            bool hasSpecialCharacter = false;

            foreach (char c in password) {
                if (char.IsUpper(c)) {
                    hasUppercase = true;
                } else if (char.IsLower(c)) {
                    hasLowercase = true;
                } else if (char.IsDigit(c)) {
                    hasDigit = true;
                } else if (!char.IsLetterOrDigit(c)) {
                    hasSpecialCharacter = true;
                }
            }

            return hasUppercase && hasLowercase && hasDigit && hasSpecialCharacter;

        }
    }
}
