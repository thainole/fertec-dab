using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bo
{
    public class VentaBO
    {
        public int numventa { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }
        public bool estado { get; set; }

        // claves foraneas
        public ClienteBO cliente { get; set; }
        public EmpleadoBO empleado { get; set; }

        // detalle
        public List<DetalleVentaBO> detalles { get; set; }
    }
}
