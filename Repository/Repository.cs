
using Design_Patterns_Assignment.Repository.Models;
using System;

namespace Design_Patterns_Assignment.Repository
{
    internal static class Repository
    {
        internal static IDbRepository Database { get; private set; } = new DbRepository();

        // Using firstRun to simulate switching repository to show that pattern is working as intended
        internal static void Run(bool firstRun = true)
        {
            if (firstRun) Console.WriteLine("-- Repository --");
            var data = Database.GetDataset();
            Console.WriteLine($"- {data} -");

            Animal animal;
            Customer customer = Database.GetCustomer("steve");
            if (customer != null)
            {
                Console.WriteLine($"{customer.Name} found!");
                animal = Database.GetAnimal(customer);
                if (animal != null)
                {
                    Console.WriteLine($"{customer.Name} owns {animal.Name}.");
                    Database.SaveAnimal(animal);
                }
                else
                {
                    Console.WriteLine($"{customer.Name} has no animals.");
                }

                Database.SaveCustomer(customer);
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }

            if (firstRun)
            {
                Database = new DbRepository2();
                Run(false);
            }

            Console.WriteLine();
        }
    }
}