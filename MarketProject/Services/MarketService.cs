using MarketProject.Common.Enum;
using MarketProject.Common.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Services
{
    public class MarketService
    {
        public List<Product> Products;
        public List<Sale> Sales;

        public MarketService() 
        {
            Products = new();
            Sales = new();
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public int AddProduct(string name, decimal price, int quantity, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new FormatException("Name is empty!");
            
            if (price <= 0)
                throw new FormatException("Please enter the correct amount!");

            if (quantity < 0)
                throw new FormatException("The quantity of products can not be lower than zero!"); 
            
            if (string.IsNullOrWhiteSpace(category))
                throw new FormatException("Please add category of product");

            bool isSuccessful = Enum.TryParse(typeof(Category),category, true, out object parsedCategory);

            if (!isSuccessful)
            {
                throw new InvalidDataException("Category not found!");
            }

            var newProduct = new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity,                
                Category = (Category)parsedCategory
            };

            Products.Add(newProduct);
            return newProduct.Id; 
        }

        public void EditProduct(int Id, string name, decimal price, int quantity, object category)
        {
            // Find the product to update
            var Edit = Products.FirstOrDefault(x => x.Id == Id);
            if (Edit == null)
                throw new Exception($"{Id} is invalid");
            if (price < 0)
                throw new FormatException("Price is lower than 0!");
            if (quantity < 0)
                throw new FormatException("Invalid count!");
            Edit.Name = name;
            Edit.Price = price;
            Edit.Quantity = quantity;           
        }

        public int DeleteProduct(int Id)
        {
            var existingProduct = Products.FirstOrDefault(x => x.Id == Id);
            if (existingProduct == null)
                throw new FormatException($"Product with code {Id} does not exist!");
            Products = Products.Where(x => x.Id != Id).ToList();

            
            return existingProduct.Id;            
        }

        public int ShowAllProducts(string name, decimal price, int quantity, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new FormatException("Name is empty!");            

            if (price <= 0)
                throw new FormatException("Please enter a positive price!");

            if (quantity < 0)
                throw new FormatException("The quantity of products cannot be lower than zero!");
            
            if (string.IsNullOrWhiteSpace(category))
                throw new FormatException("Please add a category of the product!");

            bool isSuccessful = Enum.TryParse(typeof(Category), category, true, out object parsedCategory);

            if (!isSuccessful)
                throw new InvalidDataException("Category not found!");                       

            Console.WriteLine($"Sales for product '{name}' in category '{parsedCategory}' - {quantity}");

            return quantity;
        }


        public List<Product> MenuShowProductsAccordingtoCategeries(Category selectedCategory)
        {
            var data = Product.Where(x => x.Category == selectedCategory).ToList();
            return data;
        }

        public List<Product> MenuShowProductsAccordingToPriceRange(int lowestprice, int highestprice)
        {
            var data = Product.Where(x => x.lowestprice < x.highestprice).ToList();
            return data;
        }

        public List<Product> MenuSHowProductToName(string inputname)
        {
            var data = Product.Where(x => x.Name == inputname).ToList();
            return data;
        }


    }

    
}
