using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data.Entity
{
    //[Index(nameof(ClienteId), nameof(DisponibilidadId), Name = "Cita_UQ", IsUnique = true)]
    public class Disponibilidad : EntityBase
    {
        [Required(ErrorMessage = "La seleccion de fecha es obligatorio")]
        [MaxLength(4, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La seleccion de horario es obligatorio")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public int Horarios { get; set; }

        [Required(ErrorMessage = "La seleccion de disponibilidad es obligatoria")]
        
        public bool Disponible { get; set; }

       
        public int OptometristaId { get; set; }

        public Optometrista Optometrista { get; set; }
    }
}
