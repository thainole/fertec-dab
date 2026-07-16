using Microsoft.Data.SqlClient;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace pe.com.fertec.dal
{
    public class VentaDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;

        SqlTransaction transaccion = null;

        private int res = 0;

        // Listar ventas con total (maestro-detalle)
        public List<VentaBO> findAll()
        {
            List<VentaBO> lista = new List<VentaBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarVentaDetalle";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    VentaBO obj = new VentaBO();
                    ClienteBO cliente = new ClienteBO();
                    EmpleadoBO empleado = new EmpleadoBO();

                    obj.numventa = Convert.ToInt32(dr["codven"]);
                    obj.fecha = Convert.ToDateTime(dr["fecven"]);
                    obj.estado = Convert.ToBoolean(dr["estven"]);
                    obj.total = Convert.ToDecimal(dr["TotalVenta"]);

                    cliente.nombre = dr["nomcli"].ToString() + ' ' + dr["apepcli"].ToString() + ' ' + dr["apemcli"].ToString();
                    obj.cliente = cliente;

                    empleado.nombre = dr["nomemp"].ToString() + ' ' + dr["apepemp"].ToString() + ' ' + dr["apememp"].ToString();
                    obj.empleado = empleado;

                    lista.Add(obj);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }

        // Listar solo ventas (sin detalle/total)
        public List<VentaBO> getVentas()
        {
            List<VentaBO> lista = new List<VentaBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarVenta";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    VentaBO obj = new VentaBO();
                    ClienteBO cliente = new ClienteBO();
                    EmpleadoBO empleado = new EmpleadoBO();

                    obj.numventa = Convert.ToInt32(dr["codven"]);
                    obj.fecha = Convert.ToDateTime(dr["fecven"]);
                    obj.estado = Convert.ToBoolean(dr["estven"]);

                    cliente.nombre = dr["nomcli"].ToString() + ' ' + dr["apepcli"].ToString() + ' ' + dr["apemcli"].ToString();
                    obj.cliente = cliente;

                    empleado.nombre = dr["nomemp"].ToString() + ' ' + dr["apepemp"].ToString() + ' ' + dr["apememp"].ToString();
                    obj.empleado = empleado;

                    lista.Add(obj);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }

        // Obtener detalle de una venta por su código
        public List<DetalleVentaBO> findSaleDetails(int cod)
        {
            List<DetalleVentaBO> lista = new List<DetalleVentaBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarDetalleVenta";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", cod);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DetalleVentaBO obj = new DetalleVentaBO();
                    ProductoBO producto = new ProductoBO();

                    obj.numventa = Convert.ToInt32(dr["codven"]);
                    obj.cantidad = Convert.ToInt32(dr["cantidad"]);
                    obj.precio = Convert.ToDecimal(dr["precio"]);

                    producto.codigo = Convert.ToInt32(dr["codpro"]);
                    producto.nombre = dr["nompro"].ToString();
                    obj.producto = producto;

                    lista.Add(obj);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }

        // Registrar venta con sus detalles en transacción
        public bool add(VentaBO obj)
        {
            try
            {
                SqlConnection xcon = objconexion.Conectar();
                transaccion = xcon.BeginTransaction();

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarVenta";
                cmd.Connection = xcon;
                cmd.Transaction = transaccion;

                cmd.Parameters.AddWithValue("@codcli", obj.cliente.codigo);
                cmd.Parameters.AddWithValue("@codemp", obj.empleado.codigo);
                cmd.Parameters.AddWithValue("@estado", obj.estado);

                SqlParameter paramSalida = new SqlParameter("@codven", SqlDbType.Int);
                paramSalida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramSalida);

                cmd.ExecuteNonQuery();

                int codigoVenta = Convert.ToInt32(paramSalida.Value);

                foreach (DetalleVentaBO detalle in obj.detalles)
                {
                    SqlCommand cmddetalle = new SqlCommand("SP_RegistrarDetalleVenta", xcon, transaccion);
                    cmddetalle.CommandType = CommandType.StoredProcedure;
                    cmddetalle.Parameters.AddWithValue("@codven", codigoVenta);
                    cmddetalle.Parameters.AddWithValue("@codpro", detalle.codigoproducto);
                    cmddetalle.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    cmddetalle.Parameters.AddWithValue("@precio", detalle.precio);

                    cmddetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                return false;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }

        public bool disable(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AnularVenta";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);

                res = cmd.ExecuteNonQuery();
                return res == 1;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }

        public bool enable(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_HabilitarVenta";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);

                res = cmd.ExecuteNonQuery();
                return res == 1;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }

        public int setCode()
        {
            int code = 0;

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CodigoVenta";
                cmd.Connection = objconexion.Conectar();
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    code = Convert.ToInt32(res);
                }

                return code;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                if (objconexion != null) objconexion.CerrarConexion();
                if (dr != null) dr.Close();
            }
        }
    }
}
