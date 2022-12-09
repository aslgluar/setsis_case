using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_EL.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(30)]
        public string ProductName { get; set; }    
        public string ProductThumbnail { get; set; }
        public string ProductStatus { get; set; }
        public string ProductType { get; set; }
        public int CategoryID { get; set; }
        public Category Category  { get; set; }
    }
}
