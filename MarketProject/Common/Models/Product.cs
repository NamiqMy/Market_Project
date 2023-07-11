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

        public string Pr_Name { get; set; }
        public double Pr_Price { get; set;}
        public int Pr_Count { get; set; }
        public int Pr_Code { get; set; }
        public Category Category { get; set; }
    }
}
