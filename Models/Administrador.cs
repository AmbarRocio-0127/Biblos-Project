using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIBiblos.Models
{
    public class Administrador
    {
        [Key]
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
    }
}
