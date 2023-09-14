using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Auditoria
    {
        public int IdAuditoria { get; set; }
        public int IdDetAuditoria { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public int IdInstitucion { get; set; }
        public int IdUsuario { get; set; }
        public string UsuarioMod { get; set; }

    }
}
