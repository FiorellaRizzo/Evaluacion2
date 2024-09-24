using Evaluacion2.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data
{
    public class Context : DbContext
    //esta clase representara en mi programa la base de datos
    {
        //el metodo DbSet es una clase generica que incorpora las tablas de la BD
      
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Optometrista> Optometristas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Disponibilidad> Disponibilidad { get; set; }




        //genero el constructor con opciones
        public Context(DbContextOptions options) : base(options)
        {
            
        }
    }
}
