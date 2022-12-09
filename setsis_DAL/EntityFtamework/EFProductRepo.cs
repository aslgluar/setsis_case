using Microsoft.EntityFrameworkCore;
using setsis_DAL.Abstract;
using setsis_DAL.Concrete;
using setsis_DAL.Repositories;
using setsis_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_DAL.EntityFtamework
{
    public class EFProductRepo : GenericRepository<Product>, IProductRepo
    {
        public List<Product> GetProductWithCategory()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x=>x.Category).ToList();
            }
        }
    }
}
