using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using APIBiblos.Models;

namespace APIBiblos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Libros> libros { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
    }
}
