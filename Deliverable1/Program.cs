// See https://aka.ms/new-console-template for more information
namespace Deliverable1
{
    internal class Program
    {
        static void Main()
        {
            int sodaStock = 100;
            int sodaRestockValue = 40;

            int chipsStock = 40;
            int chipsRestockValue = 20;

            int candyStock = 60;
            int candyRestockValue = 40;

            Console.WriteLine("Welcome to Tommy's restocking tool.");

            Console.WriteLine($"How many Sodas have been sold today? {sodaStock} are in stock");
            if (int.TryParse(Console.ReadLine(), out int sodasSold) && sodasSold <= sodaStock)
            {
                sodaStock -= sodasSold;
            }
            else
            {
                Console.WriteLine("Invalid input or value too high. Stock not adjusted.");
            }
            Console.WriteLine($"There are {sodaStock} Sodas left.");

            Console.WriteLine($"How many Chips have been sold today? {chipsStock} are in stock");
            if (int.TryParse(Console.ReadLine(), out int chipsSold) && chipsSold <= chipsStock)
            {
                chipsStock -= chipsSold;
            }
            else
            {
                Console.WriteLine("Invalid input or value too high. Stock not adjusted.");
            }
            Console.WriteLine($"There are {chipsStock} Chips left.");

            Console.WriteLine($"How many Candy items have been sold today? {candyStock} are in stock");
            if (int.TryParse(Console.ReadLine(), out int candySold) && candySold <= candyStock)
            {
                candyStock -= candySold;
            }
            else
            {
                Console.WriteLine("Invalid input or value too high. Stock not adjusted.");
            }
            Console.WriteLine($"There are {candyStock} Candy items left.");

            Console.WriteLine("\nThank you for filling out the values. Here’s what needs to be restocked.");

            if (sodaStock <= sodaRestockValue)
            {
                Console.WriteLine("Soda needs to be restocked.");
            }

            if (chipsStock <= chipsRestockValue)
            {
                Console.WriteLine("Chips need to be restocked.");
            }

            if (candyStock <= candyRestockValue)
            {
                Console.WriteLine("Candy needs to be restocked.");
            }

            Console.WriteLine("\nGoodbye!");
        }
    }
}
