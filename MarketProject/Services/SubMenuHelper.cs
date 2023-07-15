using MarketProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    public static class SubMenuHelper
    {
        public static void ProductSubMenu()
        {            
            Console.Clear();
            int option;
            do
            {
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Edit the product");
                Console.WriteLine("3. Delete the product");
                Console.WriteLine("4. Show all products");
                Console.WriteLine("5. Show products according to category");
                Console.WriteLine("6. Show products by price range");
                Console.WriteLine("7. Search products by name");
                Console.WriteLine("0. Exit");

                Console.WriteLine("-----------");
                Console.WriteLine("Enter option:");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Enter option:");
                }

                switch (option)
                {
                    case 1:
                        MenuService.MenuAddProduct();
                        Console.WriteLine("Added new product");
                        break;
                    case 2:
                        MenuService.MenuEditProduct();
                        Console.WriteLine("Edited the product");
                        break;
                    case 3:
                        MenuService.MenuDeleteProduct();
                        Console.WriteLine("Deleted the product");
                        break;
                    case 4:
                        MenuService.MenuProducts();
                        Console.WriteLine("Shown all products");
                        break;
                    case 5:
                        MenuService.MenuShowProductsAccordingtoCatogeries();
                        Console.WriteLine("Shown products according to category");
                        break;
                    case 6:
                        Console.WriteLine("Shown products by price range");
                        break;
                    case 7:
                        Console.WriteLine("Searched products by name");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }

            } while (option != 0);

        }

        public static void SaleSubMenu()
        {
            Console.Clear();
            int option;
            do
            {
                Console.WriteLine("1. Add new sale");
                Console.WriteLine("2. Return of product");
                Console.WriteLine("3. Deletion of sale");
                Console.WriteLine("4. Show all sales");
                Console.WriteLine("5. Show sales for a given date range");
                Console.WriteLine("6. Show sales by given amount range");
                Console.WriteLine("7. Showing sales for a given date");
                Console.WriteLine("8. Show sales information based on a given number");
                Console.WriteLine("0. Go back");

                Console.WriteLine("-----------");
                Console.WriteLine("Enter option:");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Enter option:");
                }

                switch (option)
                {
                    case 1:
                        
                        Console.WriteLine("Added new sale");
                        break;
                    case 2:
                        
                        Console.WriteLine("The product was returned");
                        break;
                    case 3:
                        
                        Console.WriteLine("The product has been deleted");
                        break;
                    case 4:
                        
                        Console.WriteLine("Displayed all sales");
                        break;
                        case 5:
                        Console.WriteLine("Displayed of sales for a given date range");
                        break;
                        case 6:
                        Console.WriteLine("Displayed sales by given amount range");
                        break;
                        case 7:
                        Console.WriteLine("Showed sales for a given date");
                        break;
                        case 8:
                        Console.WriteLine("Displayed sales information based on a given number");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }

            } while (option != 0);
        }
    }
}
    

