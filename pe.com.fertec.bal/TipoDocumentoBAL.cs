using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class TipoDocumentoBAL
    {
        TipoDocumentoDAL dal = new TipoDocumentoDAL();

        public List<TipoDocumentoBO> findAll() => dal.findAll();
        public List<TipoDocumentoBO> findAllCustom() => dal.findAllCustom();
        public bool add(TipoDocumentoBO t) => dal.add(t);
        public TipoDocumentoBO findById(int id) => dal.findById(id);
        public bool update(TipoDocumentoBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
