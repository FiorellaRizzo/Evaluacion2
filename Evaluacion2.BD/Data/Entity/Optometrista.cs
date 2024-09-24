using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data.Entity
{
    public class Optometrista : EntityBase
    {
        public int PersonaId { get; set; }

        public Persona Persona { get; set; }
    }
}
