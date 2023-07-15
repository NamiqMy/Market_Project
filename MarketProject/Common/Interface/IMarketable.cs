using MarketProject.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Common.Interface
{
    public interface IMarketable
    {
        int Sales();
        string Product();
        void AddSale();
        void ReturnSale();
        void RefundWholeSale();
        List<Sale> RefundSalesByDueDate();
        List<Sale> RefundSalesByGivenDate();
        List<Sale> RefundSalesByGivenAmount();
        List<Sale> RefundSalesByGivenNumber();
        void AddNewProduct();
        List<Product> EditProduct();
        List<Product> RefundProductByCategory();
        List<Product> RefundProductsByPriceRange();
        List<Product> RefundProductByName();


    }

    
}
