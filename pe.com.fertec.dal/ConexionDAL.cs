using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pe.com.fertec.dal
{
    public class ConexionDAL
    {
        //conexion omar
        private string cadena = "Data Source=DESKTOP-V0PI1FI; Initial Catalog=bdferreteria2026; Integrated Security=True; TrustServerCertificate=True;";
        //private string cadena = "Data Source=THAISWIFT; Initial Catalog=bdferreteria2026; Integrated Security=True; TrustServerCertificate=True;";

        // private string cadena = "Data Source=.; Initial Catalog=bdferreteria2026; Integrated Security=True; TrustServerCertificate=True;";
        //ce610b7e67b4d3f29a5fe733ce2bacaa422ff8f2

        private SqlConnection xcon;

        public SqlConnection Conectar()
        {
            try
            {
                xcon = new SqlConnection(cadena);
                xcon.Open();
                return xcon;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public void CerrarConexion()
        {
            xcon.Close();
            xcon.Dispose();
        }
    }
}
