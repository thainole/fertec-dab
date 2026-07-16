using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class SexoBAL
    {
        SexoDAL dal = new SexoDAL();

        public List<SexoBO> findAll() => dal.findAll();
        public List<SexoBO> findAllCustom() => dal.findAllCustom();
        public bool add(SexoBO t) => dal.add(t);
        public SexoBO findById(int id) => dal.findById(id);
        public bool update(SexoBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
