using Microsoft.Data.SqlClient;
using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace pe.com.fertec.dal
{
    public class EmpleadoDAL
    {
        private ConexionDAL objconexion = new ConexionDAL();
        private SqlCommand cmd;
        private SqlDataReader dr;

        private int res = 0;

        public List<EmpleadoBO> findAll()
        {
            List<EmpleadoBO> lista = new List<EmpleadoBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarEmpleadoTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmpleadoBO obj = new EmpleadoBO();
                    DistritoBO objdis = new DistritoBO();
                    SexoBO objsex = new SexoBO();
                    TipoDocumentoBO objtipdoc = new TipoDocumentoBO();
                    RolBO objrol = new RolBO();

                    obj.codigo = Convert.ToInt32(dr["codemp"]);
                    obj.nombre = dr["nomemp"].ToString();
                    obj.apellidopaterno = dr["apepemp"].ToString();
                    obj.apellidomaterno = dr["apememp"].ToString();
                    obj.numerodocumento = dr["numdoc"].ToString();
                    obj.fechanacimiento = Convert.ToDateTime(dr["fecnac"]);
                    obj.fechaingreso = Convert.ToDateTime(dr["fecing"]);
                    obj.direccion = dr["diremp"].ToString();
                    obj.telefono = dr["telemp"].ToString();
                    obj.celular = dr["celemp"].ToString();
                    obj.correo = dr["coremp"].ToString();
                    obj.usuario = dr["usuemp"].ToString();
                    obj.clave = dr["claemp"].ToString();
                    obj.sueldo = Convert.ToDecimal(dr["sueemp"]);
                    obj.estado = Convert.ToBoolean(dr["estemp"]);

                    objdis.nombre = dr["nomdis"].ToString();
                    obj.distrito = objdis;

                    objsex.nombre = dr["nomsex"].ToString();
                    obj.sexo = objsex;

                    objtipdoc.nombre = dr["nomtipd"].ToString();
                    obj.tipodocumento = objtipdoc;

                    objrol.nombre = dr["nomrol"].ToString();
                    obj.rol = objrol;

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

        public List<EmpleadoBO> findAllCustom()
        {
            List<EmpleadoBO> lista = new List<EmpleadoBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarEmpleado";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmpleadoBO obj = new EmpleadoBO();
                    DistritoBO objdis = new DistritoBO();
                    SexoBO objsex = new SexoBO();
                    TipoDocumentoBO objtipdoc = new TipoDocumentoBO();
                    RolBO objrol = new RolBO();

                    obj.codigo = Convert.ToInt32(dr["codemp"]);
                    obj.nombre = dr["nomemp"].ToString();
                    obj.apellidopaterno = dr["apepemp"].ToString();
                    obj.apellidomaterno = dr["apememp"].ToString();
                    obj.numerodocumento = dr["numdoc"].ToString();
                    obj.fechanacimiento = Convert.ToDateTime(dr["fecnac"]);
                    obj.fechaingreso = Convert.ToDateTime(dr["fecing"]);
                    obj.direccion = dr["diremp"].ToString();
                    obj.telefono = dr["telemp"].ToString();
                    obj.celular = dr["celemp"].ToString();
                    obj.correo = dr["coremp"].ToString();
                    obj.usuario = dr["usuemp"].ToString();
                    obj.clave = dr["claemp"].ToString();
                    obj.sueldo = Convert.ToDecimal(dr["sueemp"]);
                    obj.estado = Convert.ToBoolean(dr["estemp"]);

                    objdis.nombre = dr["nomdis"].ToString();
                    obj.distrito = objdis;

                    objsex.nombre = dr["nomsex"].ToString();
                    obj.sexo = objsex;

                    objtipdoc.nombre = dr["nomtipd"].ToString();
                    obj.tipodocumento = objtipdoc;

                    objrol.nombre = dr["nomrol"].ToString();
                    obj.rol = objrol;

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

        public bool add(EmpleadoBO obj)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarEmpleado";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@nomemp", obj.nombre);
                cmd.Parameters.AddWithValue("@apepemp", obj.apellidopaterno);
                cmd.Parameters.AddWithValue("@apememp", obj.apellidomaterno);
                cmd.Parameters.AddWithValue("@numdoc", obj.numerodocumento);
                cmd.Parameters.AddWithValue("@fecnac", obj.fechanacimiento);
                cmd.Parameters.AddWithValue("@fecing", obj.fechaingreso);
                cmd.Parameters.AddWithValue("@diremp", obj.direccion);
                cmd.Parameters.AddWithValue("@telemp", obj.telefono);
                cmd.Parameters.AddWithValue("@celemp", obj.celular);
                cmd.Parameters.AddWithValue("@coremp", obj.correo);
                cmd.Parameters.AddWithValue("@usuemp", obj.usuario);
                cmd.Parameters.AddWithValue("@claemp", obj.clave);
                cmd.Parameters.AddWithValue("@sueemp", obj.sueldo);
                cmd.Parameters.AddWithValue("@estemp", obj.estado);
                cmd.Parameters.AddWithValue("@coddis", obj.distrito.codigo);
                cmd.Parameters.AddWithValue("@codsex", obj.sexo.codigo);
                cmd.Parameters.AddWithValue("@codtipd", obj.tipodocumento.codigo);
                cmd.Parameters.AddWithValue("@codrol", obj.rol.codigo);

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

        public EmpleadoBO findById(int id)
        {
            EmpleadoBO obj = new EmpleadoBO();
            DistritoBO objdis = new DistritoBO();
            SexoBO objsex = new SexoBO();
            TipoDocumentoBO objtipdoc = new TipoDocumentoBO();
            RolBO objrol = new RolBO();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BuscarEmpleadoXCodigo";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    obj.codigo = Convert.ToInt32(dr["codemp"]);
                    obj.nombre = dr["nomemp"].ToString();
                    obj.apellidopaterno = dr["apepemp"].ToString();
                    obj.apellidomaterno = dr["apememp"].ToString();
                    obj.numerodocumento = dr["numdoc"].ToString();
                    obj.fechanacimiento = Convert.ToDateTime(dr["fecnac"]);
                    obj.fechaingreso = Convert.ToDateTime(dr["fecing"]);
                    obj.direccion = dr["diremp"].ToString();
                    obj.telefono = dr["telemp"].ToString();
                    obj.celular = dr["celemp"].ToString();
                    obj.correo = dr["coremp"].ToString();
                    obj.usuario = dr["usuemp"].ToString();
                    obj.clave = dr["claemp"].ToString();
                    obj.sueldo = Convert.ToDecimal(dr["sueemp"]);
                    obj.estado = Convert.ToBoolean(dr["estemp"]);

                    objdis.nombre = dr["nomdis"].ToString();
                    obj.distrito = objdis;

                    objsex.nombre = dr["nomsex"].ToString();
                    obj.sexo = objsex;

                    objtipdoc.nombre = dr["nomtipd"].ToString();
                    obj.tipodocumento = objtipdoc;

                    objrol.nombre = dr["nomrol"].ToString();
                    obj.rol = objrol;
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

        public bool update(EmpleadoBO obj, int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarEmpleado";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigo", id);
                cmd.Parameters.AddWithValue("@nomemp", obj.nombre);
                cmd.Parameters.AddWithValue("@apepemp", obj.apellidopaterno);
                cmd.Parameters.AddWithValue("@apememp", obj.apellidomaterno);
                cmd.Parameters.AddWithValue("@numdoc", obj.numerodocumento);
                cmd.Parameters.AddWithValue("@fecnac", obj.fechanacimiento);
                cmd.Parameters.AddWithValue("@fecing", obj.fechaingreso);
                cmd.Parameters.AddWithValue("@diremp", obj.direccion);
                cmd.Parameters.AddWithValue("@telemp", obj.telefono);
                cmd.Parameters.AddWithValue("@celemp", obj.celular);
                cmd.Parameters.AddWithValue("@coremp", obj.correo);
                cmd.Parameters.AddWithValue("@usuemp", obj.usuario);
                cmd.Parameters.AddWithValue("@claemp", obj.clave);
                cmd.Parameters.AddWithValue("@sueemp", obj.sueldo);
                cmd.Parameters.AddWithValue("@estemp", obj.estado);
                cmd.Parameters.AddWithValue("@coddis", obj.distrito.codigo);
                cmd.Parameters.AddWithValue("@codsex", obj.sexo.codigo);
                cmd.Parameters.AddWithValue("@codtipd", obj.tipodocumento.codigo);
                cmd.Parameters.AddWithValue("@codrol", obj.rol.codigo);

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
                cmd.CommandText = "SP_EliminarEmpleado";
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
                cmd.CommandText = "SP_HabilitarEmpleado";
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
                cmd.CommandText = "SP_CodigoEmpleado";
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

        public List<EmpleadoBO> login(string usuario, string clave)
        {
            List<EmpleadoBO> lista = new List<EmpleadoBO>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ValidarEmpleado";
                cmd.Connection = objconexion.Conectar();
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmpleadoBO obj = new EmpleadoBO();

                    obj.codigo = Convert.ToInt32(dr["codemp"]);
                    obj.nombre = dr["nomemp"].ToString();
                    obj.apellidopaterno = dr["apepemp"].ToString();
                    obj.apellidomaterno = dr["apememp"].ToString();
                    obj.usuario = dr["usuemp"].ToString();
                    obj.estado = Convert.ToBoolean(dr["estemp"]);

                    RolBO objrol = new RolBO();
                    objrol.codigo = Convert.ToInt32(dr["codrol"]);
                    objrol.nombre = dr["nomrol"].ToString();
                    obj.rol = objrol;

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
    }
}
