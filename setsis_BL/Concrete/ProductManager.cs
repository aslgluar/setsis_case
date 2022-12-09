using setsis_BL.Abstract;
using setsis_DAL.Abstract;
using setsis_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_BL.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepo _efproductRepo;
        public ProductManager(IProductRepo productRepo) //constructor
        {
            _efproductRepo = productRepo;
        }

        public List<Product> GetAll()
        {
            return _efproductRepo.GetAll(); 
        }

        public Product GetById(int id)
        {
            return _efproductRepo.GetByID(id);
        }

        public List<Product> GetProductListWithCategory()
        {
            return _efproductRepo.GetProductWithCategory();
        }

        public void ProductAdd(Product product)
        {
            _efproductRepo.Add(product);
        }

        public void ProductDelete(Product product)
        {
           _efproductRepo.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _efproductRepo.Update(product);
        }
    }
}

