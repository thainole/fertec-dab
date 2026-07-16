using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class VentaBAL
    {
        VentaDAL dal = new VentaDAL();

        public List<VentaBO> findAll() => dal.findAll();
        public List<VentaBO> getVentas() => dal.getVentas();
        public List<DetalleVentaBO> findSaleDetails(int cod) => dal.findSaleDetails(cod);
        public bool add(VentaBO t) => dal.add(t);
        public bool disable(int id) => dal.disable(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
