using System.Globalization;
using Udemy.CSharp.Aula132.Exercicio01.Entities;
using Udemy.CSharp.Aula132.Exercicio01.Enums;

namespace Udemy.CSharp.Aula132.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = null;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order = new Order(DateTime.Now, Enum.Parse<OrderStatus>(status), client);
            }




        }
    }
}