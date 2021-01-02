using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Zonama.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Zonama.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        {

        }
        public DbSet<Fournisseur> Fournisseur { get; set; }
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Gerant> Gerant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}