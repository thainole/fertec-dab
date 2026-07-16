using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class CategoriaBAL
    {
        CategoriaDAL dal = new CategoriaDAL();

        public List<CategoriaBO> findAll() => dal.findAll();
        public List<CategoriaBO> findAllCustom() => dal.findAllCustom();
        public bool add(CategoriaBO t) => dal.add(t);
        public CategoriaBO findById(int id) => dal.findById(id);
        public bool update(CategoriaBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
