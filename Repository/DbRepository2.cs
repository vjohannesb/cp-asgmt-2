using Design_Patterns_Assignment.Repository.Data;
using Design_Patterns_Assignment.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment.Repository
{
    // Second DbRepository simulates a repository to a DbContext
    // where it uses functions (such as GetAnimals()) to load data
    // from a database
    internal class DbRepository2 : IDbRepository
    {
        private readonly MockDb2 _dbContext;

        public DbRepository2()
        {
            _dbContext = new MockDb2();
        }

        // Animal
        public Animal GetAnimal(Customer owner)
            => _dbContext.GetAnimals().FirstOrDefault(a => a.Owner == owner);

        public IEnumerable<Animal> GetAnimals()
            => _dbContext.GetAnimals();

        public void SaveAnimal(Animal animal) 
            => _dbContext.GetAnimals().Add(animal);

        // Customer
        public Customer GetCustomer(string name)
            => _dbContext.GetCustomers()
                .FirstOrDefault((c) => c.Name.ToLower() == name.ToLower());

        public IEnumerable<Customer> GetCustomers()
            => _dbContext.GetCustomers();

        public void SaveCustomer(Customer customer)
            => _dbContext.GetCustomers().Add(customer);

        // Dataset
        public string GetDataset()
            => "Data from Database 2";

        public void SaveDataset() => Console.WriteLine("Data saved to Database 2");
    }
}
