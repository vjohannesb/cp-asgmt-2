using Design_Patterns_Assignment.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment.Repository
{
    internal class DbRepository : IDbRepository
    {
        private readonly List<Customer> _customers;
        private readonly List<Animal> _animals;

        public DbRepository()
        {
            var steve = new Customer() { Name = "Steve" };
            var stevesDog = new Animal() { Name = "Steves dog", Owner = steve };
            _customers = new() { steve };
            _animals = new() { stevesDog };
        }

        public Animal GetAnimal(Customer owner)
            => _animals.FirstOrDefault((a) => a.Owner == owner);
        public IEnumerable<Animal> GetAnimals()
            => _animals;
        public void SaveAnimal(Animal animal)
            => Console.WriteLine($"{animal.Name} saved.");

        public Customer GetCustomer(string name)
            => _customers.FirstOrDefault((c) => c.Name.ToLower() == name.ToLower());
        public IEnumerable<Customer> GetCustomers()
            => _customers;
        public void SaveCustomer(Customer customer)
            => Console.WriteLine($"{customer.Name} saved.");

        public string GetDataset() => "Dataset A";
        public void SaveDataset() => Console.WriteLine("Dataset A saved.");
    }
}
