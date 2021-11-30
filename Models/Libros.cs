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
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime? Fecha{ get; set; }
        public string Editorial { get; set; }
        public string Codigo { get; set; }
        public int Vendidos { get; set; }
        public int Cantidad { get; set; }

    }
}
