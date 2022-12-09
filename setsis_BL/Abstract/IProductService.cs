using setsis_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_BL.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Product product);
        void ProductDelete(Product product);
        void ProductUpdate(Product product);
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> GetProductListWithCategory();
    }
}
