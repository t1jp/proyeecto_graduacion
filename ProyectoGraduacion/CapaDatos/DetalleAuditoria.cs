using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleAuditoria
    { 
        public int IdDetAuditoria { get; set; }
        public string InfoEntrevista { get; set; }
        public string InfoEncuesta { get; set; }
        public int NoDocsAnalizar { get; set; }
        public string InfoFortaleza { get; set; }
        public string InfoOportunidades { get; set; }
        public string InfoDebilidades { get; set; }
        public string InfoAmenazas { get; set; }
        public string InfoCausaEfecto { get; set; }
        public string Objetivo { get; set; }
        public string Alcance { get; set; }
        public int IdRiesgo { get; set; }
        public int IdMaterialidad { get; set; }
        public string InfoPlaneacion { get; set; }
        public int IdPruebas { get; set; }
        public int IdTecnicasMu { get; set; }
        public int IdEvidencias { get; set; }
        public int IdPapeles { get; set; }
        public string Hallazgo_Criterio { get; set; }
        public string Hallazgo_Condicion { get; set; }
        public string Hallazgo_Causa { get; set; }
        public string Hallazgo_Efecto { get; set; }

    }
}
