using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zonama.Models
{
    public class Service
    {
        [Key]
        public int id_serv { get; set; }
        public string libelle { get; set; }
        public float prix { get; set; }
        public virtual Employe Employe { get; set; }
    }
}