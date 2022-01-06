using Design_Patterns_Assignment.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment.Repository
{
    internal class DbRepository2 : IDbRepository
    {
        private readonly List<Customer> _customers;
        private readonly List<Animal> _animals;

        public DbRepository2()
        {
            _customers = new();
            _animals = new();
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

        public string GetDataset() => "Dataset B";
        public void SaveDataset() => Console.WriteLine("Dataset B saved.");
    }
}
