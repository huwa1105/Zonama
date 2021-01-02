using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zonama.Models
{
    public class Produit
    {
        [Key]
        public int id_prod { get; set; }
        public string libelle { get; set; }
        public float prix { get; set; }
        public virtual Fournisseur id_four { get; set; }
    }
}