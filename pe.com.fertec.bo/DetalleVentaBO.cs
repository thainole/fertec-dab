using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bo
{
    public class DetalleVentaBO
    {
        public int codigo { get; set; }
        public int numventa { get; set; }
        public int codigoproducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

        // clave foranea
        public ProductoBO producto { get; set; }
    }
}
