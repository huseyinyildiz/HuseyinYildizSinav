using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseyinYildizSinav.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Supplier { get; set; }
       
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
