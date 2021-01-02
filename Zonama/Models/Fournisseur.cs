using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zonama.Models
{
    public class Fournisseur
    {
        [Key]
        public int id_four { get; set; }
        public string nom { get; set; }
        public string tel { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
    }
}