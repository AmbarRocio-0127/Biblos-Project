using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace APIBiblos.Models
{
    public class Libros
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string fecha_publicacion { get; set; }
        public string editorial { get; set; }
        public string codigo { get; set; }
        public string Vendidos { get; set; }
        public int stock { get; set; }

    }
}
