using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zonama.Models;

namespace Zonama.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {

            var gerant = new List<Gerant>
            {
            new Gerant{nom="Walem",prenom="Hugo", tel="0491315765", email="hugo.walem@zonama.com", password="admin123"},
            };
            gerant.ForEach(s => context.Gerant.Add(s));
            context.SaveChanges();

            var employe = new List<Employe>
            {
            new Employe{nom="Laubry",prenom="Cassandra", tel="0491315685", email="cassandra.laubry@zonama.com", date_adm=DateTime.Parse("2005-09-01")},
            };
            employe.ForEach(s => context.Employe.Add(s));
            context.SaveChanges();

            var fournisseur = new List<Fournisseur>
            {
            new Fournisseur{nom="Corsair", tel="0496578634", email="corsair@gmail.com"},

            };
            fournisseur.ForEach(s => context.Fournisseur.Add(s));
            context.SaveChanges();

            var produit = new List<Produit>
            {
            new Produit{libelle="Sabre RGB (souris)",prix=60},

            };
            produit.ForEach(s => context.Produit.Add(s));
            context.SaveChanges();

            var service = new List<Service>
            {
            new Service{libelle="Montage de desktop",prix=80},

            };
            service.ForEach(s => context.Service.Add(s));
            context.SaveChanges();
        }
    }
}