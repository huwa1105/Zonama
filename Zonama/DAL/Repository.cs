using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zonama.DTO;
using Zonama.Interface;

namespace Zonama.DAL
{
    public class Repository : IRepository
    {
        private ShopContext db = new ShopContext();
        public LoginDTO Authentifier(string email, string password)
        {
            var logg = (from r in db.Gerant where r.email == email && r.password == password select new LoginDTO { firstname = r.prenom, name = r.nom, id_user = r.id_ger }).FirstOrDefault();
            return logg;
        }
    }
}