namespace MarketProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {
                Console.WriteLine("1. Products");
                Console.WriteLine("2. Add new product");
                Console.WriteLine("3. Make corrections on the product");
                Console.WriteLine("4. Delete the product");
                Console.WriteLine("5. Show all products");
                Console.WriteLine("6. Show products by category");
                Console.WriteLine("7. Show products by price range");
                Console.WriteLine("8. Search products by name");
                Console.WriteLine("9. Sales of product");
                Console.WriteLine("10. Add new sales");
                Console.WriteLine("11. Returning any product on sale");
                Console.WriteLine("12. Deletion of sales");
                Console.WriteLine("13. Display of all sales");
                Console.WriteLine("14. Display of sales according to the given date range");
                Console.WriteLine("15. Display of sales according to the given amount range");
                Console.WriteLine("16. Showing sales on a given date");
                Console.WriteLine("17. Displaying sales data based on a given number");
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
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
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