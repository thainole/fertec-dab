using pe.com.fertec.bo;
using pe.com.fertec.dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace pe.com.fertec.bal
{
    public class ProductoBAL
    {
        ProductoDAL dal = new ProductoDAL();

        public List<ProductoBO> findAll() => dal.findAll();
        public List<ProductoBO> findAllCustom() => dal.findAllCustom();
        public bool add(ProductoBO t) => dal.add(t);
        public ProductoBO findById(int id) => dal.findById(id);
        public bool update(ProductoBO t, int id) => dal.update(t, id);
        public bool delete(int id) => dal.delete(id);
        public bool enable(int id) => dal.enable(id);
        public int setCode() => dal.setCode();
    }
}
