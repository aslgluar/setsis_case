using setsis_DAL.Abstract;
using setsis_DAL.Repositories;
using setsis_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_DAL.EntityFtamework
{
    public class EFUserRepo:GenericRepository<User>,IUserRepo
    {
    }
}
