using MarketProject.Common.Base;
using MarketProject.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Common.Models
{
    public class Sale : BaseEntity
    {
        public static int _count = 0;
        public Sale() 
        {
            Id = _count;
            _count++;
        }
        public int Number { get; set; }
        public decimal Amount { get; set; }
        public int SalesItems {get; set; }
        public DateTime Date { get; set; }      

    }
}
