using Microsoft.EntityFrameworkCore;
using RegistroPrestamo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Moras> Moras { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
