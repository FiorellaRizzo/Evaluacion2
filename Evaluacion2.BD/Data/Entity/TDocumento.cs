using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2.BD.Data.Entity
{
    public class TDocumento : EntityBase
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }
    }
}
