using MarketProject.Services;

namespace MarketProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {
                Console.WriteLine("1. Transaction on products");                
                Console.WriteLine("2. Sales of product");                
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
                        SubMenuHelper.ProductsSubMenu();
                        break;
                    case 2:
                        SubMenuHelper.SalesSubMenu();
                        break;                 
                    case 0:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);

        }
    }
}