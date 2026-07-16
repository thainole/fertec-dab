using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bo
{
    public class ClienteBO
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
        public string numerodocumento { get; set; }
        public DateTime fecharegistro { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }

        // claves foraneas
        public DistritoBO distrito { get; set; }
        public SexoBO sexo { get; set; }
        public TipoDocumentoBO tipodocumento { get; set; }
    }
}
