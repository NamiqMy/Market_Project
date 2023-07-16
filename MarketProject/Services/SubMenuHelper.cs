using MarketProject.Services;

namespace MarketProject
{
    public static class SubMenuHelper
    {
        public static void ProductsSubMenu()
        {
            Console.Clear();
            int option;
            do
            {
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Update product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Show all products");
                Console.WriteLine("5. Show products according to their categories");
                Console.WriteLine("6. Show products according to their price interval");
                Console.WriteLine("7. Find products according to their name");
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
                        MenuService.MenuAddProduct();
                        Console.WriteLine("Added product");
                        break;
                    case 2:
                        MenuService.UpdateProduct();
                        Console.WriteLine("Updated product");
                        break;
                    case 3:
                        MenuService.MenuDeleteProduct();
                        Console.WriteLine("Deleted product");
                        break;
                    case 4:
                        MenuService.MenuProducts();
                        Console.WriteLine("Showing all products");
                        break;
                    case 5:
                        MenuService.MenuShowProductAccordingToCategory();
                        Console.WriteLine("Showing products according to their categories");
                        break;
                    case 6:
                        MenuService.MenuProductAccordingToPriceInterval();
                        Console.WriteLine("Showing products according to their price interval");
                        break;
                    case 7:
                        MenuService.MenuProductAccordingToName();
                        Console.WriteLine("Finding products according to their name");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }

            } while (option != 0);
        }

        public static void SalesSubMenu()
        {
            Console.Clear();
            int option;
            do
            {
                Console.WriteLine("1. Add sale");
                Console.WriteLine("2. Decline sale");
                Console.WriteLine("3. Remove sale");
                Console.WriteLine("4. Show all sales");
                Console.WriteLine("5. Show sales according to their time interval");
                Console.WriteLine("6. Show sales according to their price interval");
                Console.WriteLine("7. Show sales on the given date");
                Console.WriteLine("8. Show sales according to their numbers");
                Console.WriteLine("0. Go back...");
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
                        Console.Clear();
                        MenuService.MenuAddSales();
                        Console.WriteLine("Added sale");
                        break;
                    case 2:
                        Console.Clear();
                        MenuService.RefundProduct();
                        Console.WriteLine("Refund sale");
                        break;
                    case 3:
                        Console.Clear();
                        MenuService.RemoveSale();
                        Console.WriteLine("Removed sale");
                        break;
                    case 4:
                        Console.Clear();
                        MenuService.MenuShowAllSales();
                        Console.WriteLine("Showing all sales");
                        break;
                    case 5:
                        Console.Clear();
                        MenuService.ShowSaleByTimeInterval();
                        Console.WriteLine("Showing sales according to their time interval");
                        break;
                    case 6:
                        Console.Clear();
                        MenuService.ShowSaleByPriceInterval();
                        Console.WriteLine("Showing sales according to their price interval");
                        break;
                    case 7:
                        Console.Clear();
                        MenuService.ShowSaleByTimeInterval();
                        Console.WriteLine("Showing sales on the given date");
                        break;
                    case 8:
                        Console.Clear();
                        MenuService.MenuShowAllSales();
                        var currentSaleId = Int32.Parse(Console.ReadLine());
                        MenuService.ShowSaleDetailsById(currentSaleId);
                        Console.WriteLine("Show sales according to their numbers");                        
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
    

