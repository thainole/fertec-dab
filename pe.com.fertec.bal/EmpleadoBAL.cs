using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class EmpleadoBAL
    {
        EmpleadoDAL dal = new EmpleadoDAL();

        public List<EmpleadoBO> findAll() => dal.findAll();
        public List<EmpleadoBO> findAllCustom() => dal.findAllCustom();
        public bool add(EmpleadoBO t) => dal.add(t);
        public EmpleadoBO findById(int id) => dal.findById(id);
        public bool update(EmpleadoBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
        public List<EmpleadoBO> login(string usuario, string clave) => dal.login(usuario, clave);
    }
}
