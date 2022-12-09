using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace setsis_EL.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryStatus{ get; set; }    
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Product> products { get; set; }
    }
}
