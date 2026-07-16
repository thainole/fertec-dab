using Microsoft.Data.SqlClient;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace pe.com.fertec.dal
{
    public class ProductoDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;

        private int res = 0;

        public List<ProductoBO> findAll()
        {
            List<ProductoBO> lista = new List<ProductoBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarProductoTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ProductoBO obj = new ProductoBO();
                    CategoriaBO objcat = new CategoriaBO();
                    MarcaBO objmar = new MarcaBO();

                    obj.codigo = Convert.ToInt32(dr["codpro"]);
                    obj.nombre = dr["nompro"].ToString();
                    obj.descripcion = dr["despro"].ToString();
                    obj.precio = Convert.ToDecimal(dr["prepro"]);
                    obj.stock = Convert.ToInt32(dr["stopro"]);
                    obj.fecharegistro = Convert.ToDateTime(dr["fecregis"]);
                    obj.estado = Convert.ToBoolean(dr["estpro"]);

                    objcat.nombre = dr["nomcat"].ToString();
                    obj.categoria = objcat;

                    objmar.nombre = dr["nommar"].ToString();
                    obj.marca = objmar;

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

        public List<ProductoBO> findAllCustom()
        {
            List<ProductoBO> lista = new List<ProductoBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarProducto";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ProductoBO obj = new ProductoBO();
                    CategoriaBO objcat = new CategoriaBO();
                    MarcaBO objmar = new MarcaBO();

                    obj.codigo = Convert.ToInt32(dr["codpro"]);
                    obj.nombre = dr["nompro"].ToString();
                    obj.descripcion = dr["despro"].ToString();
                    obj.precio = Convert.ToDecimal(dr["prepro"]);
                    obj.stock = Convert.ToInt32(dr["stopro"]);
                    obj.fecharegistro = Convert.ToDateTime(dr["fecregis"]);
                    obj.estado = Convert.ToBoolean(dr["estpro"]);

                    objcat.nombre = dr["nomcat"].ToString();
                    obj.categoria = objcat;

                    objmar.nombre = dr["nommar"].ToString();
                    obj.marca = objmar;

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

        public bool add(ProductoBO obj)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarProducto";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
                cmd.Parameters.AddWithValue("@precio", obj.precio);
                cmd.Parameters.AddWithValue("@stock", obj.stock);
                cmd.Parameters.AddWithValue("@fecregis", obj.fecharegistro);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@codcat", obj.categoria.codigo);
                cmd.Parameters.AddWithValue("@codmar", obj.marca.codigo);

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

        public ProductoBO findById(int id)
        {
            ProductoBO obj = new ProductoBO();
            CategoriaBO objcat = new CategoriaBO();
            MarcaBO objmar = new MarcaBO();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BuscarProductoXCodigo";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    obj.codigo = Convert.ToInt32(dr["codpro"]);
                    obj.nombre = dr["nompro"].ToString();
                    obj.descripcion = dr["despro"].ToString();
                    obj.precio = Convert.ToDecimal(dr["prepro"]);
                    obj.stock = Convert.ToInt32(dr["stopro"]);
                    obj.fecharegistro = Convert.ToDateTime(dr["fecregis"]);
                    obj.estado = Convert.ToBoolean(dr["estpro"]);

                    objcat.nombre = dr["nomcat"].ToString();
                    obj.categoria = objcat;

                    objmar.nombre = dr["nommar"].ToString();
                    obj.marca = objmar;
                }

                return obj;
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

        public bool update(ProductoBO obj, int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarProducto";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);
                cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
                cmd.Parameters.AddWithValue("@precio", obj.precio);
                cmd.Parameters.AddWithValue("@stock", obj.stock);
                cmd.Parameters.AddWithValue("@fecregis", obj.fecharegistro);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@codcat", obj.categoria.codigo);
                cmd.Parameters.AddWithValue("@codmar", obj.marca.codigo);

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

        public bool delete(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarProducto";
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
                cmd.CommandText = "SP_HabilitarProducto";
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
                cmd.CommandText = "SP_CodigoProducto";
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
