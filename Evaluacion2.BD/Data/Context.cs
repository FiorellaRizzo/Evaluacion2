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
        public DbSet<TDocumento> TDocumentos { get; set; }
        public DbSet<Persona> Personas { get; set; }



        //genero el constructor con opciones
        public Context(DbContextOptions options) : base(options)
        {
            
        }
    }
}
