using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bo
{
    public class ProductoBO
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public DateTime fecharegistro { get; set; }
        public bool estado { get; set; }

        // claves foraneas
        public CategoriaBO categoria { get; set; }
        public MarcaBO marca { get; set; }
    }
}
