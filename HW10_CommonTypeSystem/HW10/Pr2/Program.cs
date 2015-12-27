using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customens = new List<Customer>()
            {
                new Customer("Ivancho", "Ivanchev", "Draganchev", 1, "some address","088888888", "ivancho@vankata.bg", CustomerType.Diamond),
                new Customer("Petkancho", "Ivanchev", "Draganchev", 2, "some address", "088888888", "petkancho@vankata.bg", CustomerType.Regular),
            };
            
            Console.WriteLine("Customers To String");
            foreach (var customer in customens)
            {
                Console.WriteLine(customer);
            }
           
            Console.Write("\ncheck equals: ");
            Console.WriteLine(customens[0] == customens[1]);
            Console.WriteLine("\ncheck clone");
            customens.Add((Customer)customens[0].Clone());
            foreach (var customer in customens)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\n check add payment");
            customens[0].AddPayment(new Payment("boza", 0.50m), new Payment("banichka", 1.2m));
            foreach (var customer in customens)
            {
                Console.WriteLine(customer);
            }

        }
    }
}
