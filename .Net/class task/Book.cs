using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static int quantity = 0;
        static string title = "";
        static string author = "";
        static decimal price = 0;
        static string customerName = "";

        public static void AddBook()
        {
            Console.WriteLine("Enter book title:");
            title = Console.ReadLine();
            Console.WriteLine("Enter author:");
            author = Console.ReadLine();
            Console.WriteLine("Enter price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter quantity:");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Book added successfully!");

        }
        public static void SellBook()
        {
            Console.WriteLine("Enter book title to sell:");
            title = Console.ReadLine();
            Console.WriteLine("Enter quantity to sell:");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            int quantity = 10 - Quantity; 
            Console.WriteLine($"Sold {quantity} copies of '{title}' to {customerName}");
        }
        public static void ViewBook()
        {
            Console.WriteLine("--- Book Inventory ---");
            Console.WriteLine($"Title \t {title}  Author \t {author} Price \t {price} Quantity \t {quantity}");
        }

        public static void ViewSalesReport()
        {
            Console.WriteLine("--- Sales Report ---");
            Console.WriteLine($"Customer Name \t {customerName} Book \t {title} Quantity Purchased \t {quantity} Amount \t {price}");
            Console.WriteLine($"Total Amount Spent : {price}");

        }

        static void Main(string[] args)
        {
            int num1 = 0;
            do
            {
                Console.WriteLine("======= BOOK  SHOP MENU=======");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sell Book");
                Console.WriteLine("3. View Books");
                Console.WriteLine("4. View Sales Report");
                Console.WriteLine("5. Exit");
                Console.WriteLine("===============================");
                Console.WriteLine("Choices: ");
                num1 = Convert.ToInt32(Console.ReadLine());
            
           


            switch (num1)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    SellBook();
                    break;
                case 3:
                    ViewBook();
                    break;
                case 4:
                    ViewSalesReport();
                    break;
                
                default:
                    Console.WriteLine("Thanks for using Book Shop Management!");
                    break;
            }
            } while (num1 != 5);

        }
    }
}
