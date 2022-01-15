using Design_Patterns_Assignment.Repository.Data;
using Design_Patterns_Assignment.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment.Repository
{
    internal class DbRepository : IDbRepository
    {
        private readonly MockDb _dbContext;

        public DbRepository()
        {
            _dbContext = new MockDb();
        }

        // Animal
        public Animal GetAnimal(Customer owner)
            => _dbContext.Animals.FirstOrDefault(a => a.Owner == owner);

        public IEnumerable<Animal> GetAnimals()
            => _dbContext.Animals;

        public void SaveAnimal(Animal animal)
            => _dbContext.Animals.Add(animal);

        // Customer
        public Customer GetCustomer(string name)
            => _dbContext.Customers
                    .FirstOrDefault((c) => c.Name.ToLower() == name.ToLower());

        public IEnumerable<Customer> GetCustomers()
            => _dbContext.Customers;

        public void SaveCustomer(Customer customer)
            => _dbContext.Customers.Add(customer);

        // Dataset
        public string GetDataset()
        {
            return "Data from Database 1";
        }

        public void SaveDataset()
        {
            Console.WriteLine("Data saved to Database 1");
        }
    }
}
