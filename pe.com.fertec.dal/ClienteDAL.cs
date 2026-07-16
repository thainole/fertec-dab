using Microsoft.Data.SqlClient;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace pe.com.fertec.dal
{
    public class ClienteDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;

        private int res = 0;

        public List<ClienteBO> findAll()
        {
            List<ClienteBO> lista = new List<ClienteBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarClienteTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteBO obj = new ClienteBO();
                    DistritoBO objdis = new DistritoBO();
                    SexoBO objsex = new SexoBO();
                    TipoDocumentoBO objtipdoc = new TipoDocumentoBO();

                    obj.codigo = Convert.ToInt32(dr["codcli"]);
                    obj.nombre = dr["nomcli"].ToString();
                    obj.apellidopaterno = dr["apepcli"].ToString();
                    obj.apellidomaterno = dr["apemcli"].ToString();
                    obj.numerodocumento = dr["numdoc"].ToString();
                    obj.fecharegistro = Convert.ToDateTime(dr["fecreg"]);
                    obj.direccion = dr["dircli"].ToString();
                    obj.telefono = dr["telcli"].ToString();
                    obj.celular = dr["celcli"].ToString();
                    obj.correo = dr["corcli"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estcli"]);

                    objdis.nombre = dr["nomdis"].ToString();
                    obj.distrito = objdis;

                    objsex.nombre = dr["nomsex"].ToString();
                    obj.sexo = objsex;

                    objtipdoc.nombre = dr["nomtipd"].ToString();
                    obj.tipodocumento = objtipdoc;

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

        public List<ClienteBO> findAllCustom()
        {
            List<ClienteBO> lista = new List<ClienteBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarCliente";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClienteBO obj = new ClienteBO();
                    DistritoBO objdis = new DistritoBO();
                    SexoBO objsex = new SexoBO();
                    TipoDocumentoBO objtipdoc = new TipoDocumentoBO();

                    obj.codigo = Convert.ToInt32(dr["codcli"]);
                    obj.nombre = dr["nomcli"].ToString();
                    obj.apellidopaterno = dr["apepcli"].ToString();
                    obj.apellidomaterno = dr["apemcli"].ToString();
                    obj.numerodocumento = dr["numdoc"].ToString();
                    obj.fecharegistro = Convert.ToDateTime(dr["fecreg"]);
                    obj.direccion = dr["dircli"].ToString();
                    obj.telefono = dr["telcli"].ToString();
                    obj.celular = dr["celcli"].ToString();
                    obj.correo = dr["corcli"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estcli"]);

                    objdis.nombre = dr["nomdis"].ToString();
                    obj.distrito = objdis;

                    objsex.nombre = dr["nomsex"].ToString();
                    obj.sexo = objsex;

                    objtipdoc.nombre = dr["nomtipd"].ToString();
                    obj.tipodocumento = objtipdoc;

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

        public bool add(ClienteBO obj)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarCliente";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@nomcli", obj.nombre);
                cmd.Parameters.AddWithValue("@apepcli", obj.apellidopaterno);
                cmd.Parameters.AddWithValue("@apemcli", obj.apellidomaterno);
                cmd.Parameters.AddWithValue("@numdoc", obj.numerodocumento);
                cmd.Parameters.AddWithValue("@fecreg", obj.fecharegistro);
                cmd.Parameters.AddWithValue("@dircli", obj.direccion);
                cmd.Parameters.AddWithValue("@telcli", obj.telefono);
                cmd.Parameters.AddWithValue("@celcli", obj.celular);
                cmd.Parameters.AddWithValue("@corcli", obj.correo);
                cmd.Parameters.AddWithValue("@estcli", obj.estado);
                cmd.Parameters.AddWithValue("@coddis", obj.distrito.codigo);
                cmd.Parameters.AddWithValue("@codsex", obj.sexo.codigo);
                cmd.Parameters.AddWithValue("@codtipd", obj.tipodocumento.codigo);

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

        public ClienteBO findById(int id)
        {
            ClienteBO obj = new ClienteBO();
            DistritoBO objdis = new DistritoBO();
            SexoBO objsex = new SexoBO();
            TipoDocumentoBO objtipdoc = new TipoDocumentoBO();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BuscarClienteXCodigo";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    obj.codigo = Convert.ToInt32(dr["codcli"]);
                    obj.nombre = dr["nomcli"].ToString();
                    obj.apellidopaterno = dr["apepcli"].ToString();
                    obj.apellidomaterno = dr["apemcli"].ToString();
                    obj.numerodocumento = dr["numdoc"].ToString();
                    obj.fecharegistro = Convert.ToDateTime(dr["fecreg"]);
                    obj.direccion = dr["dircli"].ToString();
                    obj.telefono = dr["telcli"].ToString();
                    obj.celular = dr["celcli"].ToString();
                    obj.correo = dr["corcli"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estcli"]);

                    objdis.nombre = dr["nomdis"].ToString();
                    obj.distrito = objdis;

                    objsex.nombre = dr["nomsex"].ToString();
                    obj.sexo = objsex;

                    objtipdoc.nombre = dr["nomtipd"].ToString();
                    obj.tipodocumento = objtipdoc;
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

        public bool update(ClienteBO obj, int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarCliente";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);
                cmd.Parameters.AddWithValue("@nomcli", obj.nombre);
                cmd.Parameters.AddWithValue("@apepcli", obj.apellidopaterno);
                cmd.Parameters.AddWithValue("@apemcli", obj.apellidomaterno);
                cmd.Parameters.AddWithValue("@numdoc", obj.numerodocumento);
                cmd.Parameters.AddWithValue("@fecreg", obj.fecharegistro);
                cmd.Parameters.AddWithValue("@dircli", obj.direccion);
                cmd.Parameters.AddWithValue("@telcli", obj.telefono);
                cmd.Parameters.AddWithValue("@celcli", obj.celular);
                cmd.Parameters.AddWithValue("@corcli", obj.correo);
                cmd.Parameters.AddWithValue("@estcli", obj.estado);
                cmd.Parameters.AddWithValue("@coddis", obj.distrito.codigo);
                cmd.Parameters.AddWithValue("@codsex", obj.sexo.codigo);
                cmd.Parameters.AddWithValue("@codtipd", obj.tipodocumento.codigo);

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
                cmd.CommandText = "SP_EliminarCliente";
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
                cmd.CommandText = "SP_HabilitarCliente";
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
                cmd.CommandText = "SP_CodigoCliente";
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
