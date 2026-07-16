using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class ClienteBAL
    {
        ClienteDAL dal = new ClienteDAL();

        public List<ClienteBO> findAll() => dal.findAll();
        public List<ClienteBO> findAllCustom() => dal.findAllCustom();
        public bool add(ClienteBO t) => dal.add(t);
        public ClienteBO findById(int id) => dal.findById(id);
        public bool update(ClienteBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
