using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class DistritoBAL
    {
        DistritoDAL dal = new DistritoDAL();

        public List<DistritoBO> findAll() => dal.findAll();
        public List<DistritoBO> findAllCustom() => dal.findAllCustom();
        public bool add(DistritoBO t) => dal.add(t);
        public DistritoBO findById(int id) => dal.findById(id);
        public bool update(DistritoBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
