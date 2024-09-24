using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data.Entity
{
    
    public class Persona : EntityBase
    {
        [Required(ErrorMessage = "El numero de documento es obligatorio")]
        [MaxLength(10, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "El nombre de la persona es obligatorio")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido de la persona es obligatorio")]
        [MaxLength(100, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public string Apellido { get; set; }
        
        [Required(ErrorMessage = "El telefono de la persona es obligatorio")]
        [MaxLength(15, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo de la persona es obligatorio")]
        [MaxLength(45, ErrorMessage = "Maximo numero de caracteres es {1}")]
        public string Correo { get; set; }

    }
}
