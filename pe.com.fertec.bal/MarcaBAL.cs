using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class MarcaBAL
    {
        MarcaDAL dal = new MarcaDAL();

        public List<MarcaBO> findAll() => dal.findAll();
        public List<MarcaBO> findAllCustom() => dal.findAllCustom();
        public bool add(MarcaBO t) => dal.add(t);
        public MarcaBO findById(int id) => dal.findById(id);
        public bool update(MarcaBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
