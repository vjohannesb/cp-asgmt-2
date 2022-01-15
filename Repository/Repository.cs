
using Design_Patterns_Assignment.Repository.Models;
using System;

namespace Design_Patterns_Assignment.Repository
{
    internal static class Repository
    {
        private static readonly IDbRepository _database = new DbRepository();

        internal static void Run()
        {
            var data = _database.GetDataset();
            Console.WriteLine("-- Repository --");
            Console.WriteLine($"- {data} -");

            Customer customer = _database.GetCustomer("steve");
            if (customer is null)
            {
                Console.WriteLine("Customer not found!");
                return;
            }

            Console.WriteLine($"{customer.Name} found!");

            Animal animal = _database.GetAnimal(customer);
            if (animal is null)
            {
                Console.WriteLine($"{customer.Name} has no animals.");
                return;
            }

            Console.WriteLine($"{customer.Name} owns {animal.Name}.");
            _database.SaveCustomer(customer);

            Console.WriteLine();
        }
    }
}