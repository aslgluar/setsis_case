using setsis_BL.Abstract;
using setsis_DAL.Abstract;
using setsis_DAL.EntityFtamework;
using setsis_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_BL.Concrete
{
    public class CategoriyManager : ICategoryService
    {
        ICategoriyRepo _efCategoriyRepo;
        public CategoriyManager(ICategoriyRepo categoriyRepo) //constructor
        {
           _efCategoriyRepo= categoriyRepo;
        }
        public void CategoryAdd(Category category)
        {
            _efCategoriyRepo.Add(category);
        }
        public void CategoryDelete(Category category)
        {
            _efCategoriyRepo.Delete(category);
        }
        public void CategoryUpdate(Category category)
        {
            _efCategoriyRepo.Update(category);
        }
        public Category GetById(int id)
        {
            return _efCategoriyRepo.GetByID(id);
        }
        public List<Category> GetAll() {

            return _efCategoriyRepo.GetAll();

        }
    }
}
