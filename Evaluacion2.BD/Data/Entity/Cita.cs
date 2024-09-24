using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data.Entity
{
    //[Index(nameof(ClienteId), nameof(DisponibilidadId), Name = "Cita_UQ", IsUnique = true)]
    public class Cita : EntityBase
    {
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }

        public bool Estado { get; set; }


        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
        public int DisponibilidadId { get; set; }
        public Disponibilidad Disponibilidad { get; set; }


    }
}
