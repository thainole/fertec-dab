using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class RolBAL
    {
        RolDAL dal = new RolDAL();

        public List<RolBO> findAll() => dal.findAll();
        public List<RolBO> findAllCustom() => dal.findAllCustom();
        public bool add(RolBO t) => dal.add(t);
        public RolBO findById(int id) => dal.findById(id);
        public bool update(RolBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
