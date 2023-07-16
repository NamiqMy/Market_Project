using MarketProject.Common.Base;
using MarketProject.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Common.Models
{
    public class Product : BaseEntity
    {
        private static int _count = 0;
        public Product()
        {
            Id = _count;
            _count++;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }

    }
    
}
