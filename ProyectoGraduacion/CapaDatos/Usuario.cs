using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public int Cargo { get; set; }
        public int Direccion { get; set; }
    }
}
