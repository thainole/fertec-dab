using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pe.com.fertec.dal
{
    public class ConexionDAL
    {
        private string cadena = "Data Source=THAISWIFT; Initial Catalog=bdferreteria2026; Integrated Security=True; TrustServerCertificate=True;";

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
