using ConsoleTables;
using MarketProject.Common.Models;
using MarketProject.Common.Enum;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Services
{
    public class MenuService
    {
        private static MarketService marketService = new ();

        #region Product

        public static void MenuProducts()
        {
            try
            {
                var products = marketService.GetProducts();
                var table = new ConsoleTable("Id", "Name", "Price", "Quantity", "Category");

                if (products.Count == 0)
                {
                    Console.WriteLine("No products yet.");
                    return;
                }
                foreach (var product in products)
                {
                    table.AddRow(product.Id, product.Name, product.Price, product.Quantity, product.Category);
                }

                table.Write();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There are some errors");
                Console.WriteLine(ex.Message);
            }
        }

        public static void MenuAddProduct()
        {
            try
            {                
                Console.WriteLine("Enter product's name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter product's price: ");
                decimal price = decimal.Parse(Console.ReadLine());                

                Console.WriteLine("Enter product's quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter product's category: ");
                string category = Console.ReadLine();

                int productId = marketService.AddProduct(name, price, quantity, category);
                Console.WriteLine($"Added product with ID: {productId}");                
            }
            catch (Exception ex)    
            {
                Console.WriteLine("There some errors appeared");
                Console.WriteLine(ex.Message);
            }
        }

        public static void MenuEditProduct()
        {
            try
            {
                Console.WriteLine("Enter the Id:");
                int Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new name:");
                string newName = Console.ReadLine();

                Console.WriteLine("Enter the new quantity:");
                int newQuantity = int.Parse(Console.ReadLine());                                

                Console.WriteLine("Available categories:");
                foreach (Category category in Enum.GetValues(typeof(Category)))
                {
                    Console.WriteLine($"{(int)category}. {category}");
                }
                Console.WriteLine("Enter the category (number) of the new product:");
                int categoryNumber = int.Parse(Console.ReadLine());

                if (!Enum.IsDefined(typeof(Category), categoryNumber))
                {
                    Console.WriteLine("Invalid category number!");
                    return;
                }
                Category newCategory = (Category)categoryNumber;

                Console.WriteLine("Enter the new price:");
                decimal newPrice = decimal.Parse(Console.ReadLine());

                marketService.EditProduct(Id, newName, newQuantity, categoryNumber, newPrice);
            }

            catch (Exception ex)
            {
                Console.WriteLine("There are some errors appeared!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void MenuDeleteProduct()
        {
            try
            {
                Console.WriteLine("Enter product's ID: ");
                int productId = int.Parse(Console.ReadLine());

                marketService.DeleteProduct(productId);

                Console.WriteLine($"Successfully deleted product with ID: {productId}");
            }

            catch (Exception ex)
            {

                Console.WriteLine("There are some errors appeared!");
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Sale

        public static void MenuSaleItem()
        {
            try
            {
                var saleItems = marketService.GetSales();
                var table = new ConsoleTable("Id","Qauntity");

                if (saleItems.Count == 0) 
                {
                    Console.WriteLine("No sales yet!");
                    return;
                }

                foreach ( var item in saleItems )
                {
                    table.AddRow(item.Id, item.Name, item.Quantity);
                }

                table.Write();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Sale()
        {
            try
            {
                Console.WriteLine("Enter product's name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter product's price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter product's quantity: ");
                int quantity = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

    }
}
