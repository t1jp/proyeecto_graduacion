using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Informe
    {
        public int IdInforme { get; set; }
        public int IdAuditoria { get; set; }
        public DateTime Fecha_hora_informe { get; set; }
        public int IdUsuario { get; set; }
        public string DescripcionDocumento { get; set; }
    }
}
