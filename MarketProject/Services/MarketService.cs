﻿using MarketProject.Common.Enum;
using MarketProject.Common.Interface;
using MarketProject.Common.Models;
using MarketProject.Common.Models.Exceptions;

namespace MarketProject.Services
{
    public class MarketService : IMarketService
    {
        public List<Product> Products { get; set; } = new List<Product>();      
        public List<Sale> Sales { get; set; } = new List<Sale>();
        public List<SaleItem> SaleItems { get; set; } = new List<SaleItem>();

        public MarketService()
        {

        }

        public List<Product> GetProducts()
        {
            return this.Products;
        }

        // This method is for checking added products if there are exceptions.
        public int AddProduct(string name, decimal price, string category, int count)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new FormatException("Name is empty!");

            if (price <= 0)
                throw new FormatException("Price is lower than 0!");

            if (string.IsNullOrWhiteSpace(category))
                throw new FormatException("Category is empty!");

            if (count < 0)
                throw new FormatException("Count is lower than 0!");            

            bool isSuccessful
                = Enum.TryParse(typeof(Category), category, true, out object parsedCategory);

            if (!isSuccessful)
            {
                throw new InvalidDataException("Category not found!");
            }

            var newProduct = new Product
            {
                Name = name,
                Price = price,
                Category = (Category)parsedCategory,
                Count = count,
            };

            Products.Add(newProduct);
            return newProduct.Id;
        }

        //This method is for checking deleted products' exceptions
        public void DeleteProduct(int Id)
        {
            var currentProduct = Products.FirstOrDefault(e => e.Id == Id);

            if (currentProduct is not null)
            {
                Products.Remove(currentProduct);
            }
            else
            {
                throw new NotFoundException($"There is no any product to delete with Id : {Id}");
            }
        }

        //This method shows the quantity of product after deletion and sale.
        public bool CheckProductQuantity(int productId, int quantity)
        {
            var currentProduct = Products.FirstOrDefault(e => e.Id == productId);

            if (currentProduct is not null)
            {
                return currentProduct.Count > quantity;
            }
            else
            {                
                throw new NotFoundException($"There is no any product with that Id : {productId}");               
            }
        }

        //This method make to decrease quantity of product in table after deletion and sale.
        public void DecreaseProductQuantity(int productId, int quantity)
        {
            var currentProduct = Products.FirstOrDefault(e => e.Id == productId);

            if (currentProduct is not null)
            {
                currentProduct.Count -= quantity;
            }
            else
            {                
                throw new NotFoundException($"There is no any product to decrease with Id : {productId}");
            }
        }

        //This method make to increase quantity of product in table after refund.
        public void IncreaseProductQuantity(int productId, int quantity)
        {
            var currentProduct = Products.FirstOrDefault(e => e.Id == productId);

            if (currentProduct is not null)
            {
                currentProduct.Count += quantity;
            }
            else
            {                
                throw new NotFoundException($"There is no any product to increase with Id : {productId}");
            }
        }


        //This method shows the all listed products according to category which has already been added.
        public List<Product> ShowProductAccordingToCategory(Category selectedCategory)
        {
            var data = Products.Where(x => x.Category == selectedCategory).ToList();
            return data;
        }

        //This method shows the all listed products according to Price range which has already been added.
        public List<Product> ShowProductAccordingToPrice(int lowest, int highest)
        {
            var data = Products.Where(x => x.Price >= lowest && x.Price <= highest).ToList();
            return data;
        }

        //This method shows the all listed products according to Name which has already been added.
        public List<Product> ShowProductAccordingToName(string inputname)
        {
            var data = Products.Where(x => x.Name == inputname).ToList();
            return data;
        }

        //This method allows us to check if there some exceptions. 
        public void UpdateProduct(int Id, string name, int count, object category, decimal price)
        {
            // Find the product to update
            var update = Products.FirstOrDefault(x => x.Id == Id);
            if (update == null)
                throw new Exception($"{Id} is invalid");
            if (price < 0)
                throw new FormatException("Price is lower than 0!");
            if (count < 0)
                throw new FormatException("Invalid count!");
            update.Name = name;
            update.Price = price;
            update.Count = count;
            update.Category = (Category)category;
        }

        //This method shows us the quantity of sold products and exceptions.
        public void AddSale(Sale sale)
        {
            foreach (var saleItem in sale.SaleItems)
            {
                var tmp = CheckProductQuantity(saleItem.Product.Id, saleItem.Count);
                if (!tmp)
                {                    
                    throw new Exception($"Not enough {saleItem.Count} {saleItem.Product.Name} in Stock");
                }
            }

            Sales.Add(sale);

            foreach (var saleItem in sale.SaleItems)
            {
                DecreaseProductQuantity(saleItem.Product.Id, saleItem.Count);
            }

        }

        
    }

}
