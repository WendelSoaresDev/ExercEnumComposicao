using System;
using ExercicioEnumComp.Entities;
using ExercicioEnumComp.Entities.Enums;
namespace ExercicioEnumComp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Client c1 = new Client(name, email, birthDate);
            
            Console.WriteLine();
            Console.WriteLine("Enter order data>");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int nOrders = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, c1);
            
            for (int i = 1; i <= nOrders; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string name2 = Console.ReadLine();
                Console.Write("Product price: $");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product product = new Product(name2, price);
                OrderItem item = new OrderItem(qtd, price, product) ;

                order.AddItem(item);

            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
            

        }
    }
}