using Design_Patterns_Assignment.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Data
{
    // Simulates a different database/data storage for the purpose of the examination
    internal class MockDb2
    {
        private readonly List<Customer> _customers;
        private readonly List<Animal> _animals;

        public MockDb2()
        {
            var steve = new Customer() { Name = "Steve" };
            var stevesDog = new Animal() { Name = "Steves dog", Owner = steve };
            _customers = new() { steve };
            _animals = new() { stevesDog };
        }

        public List<Customer> GetCustomers() => _customers;
        public void AddCustomer(Customer customer) => _customers.Add(customer);

        public List<Animal> GetAnimals() => _animals;
        public void AddAnimal(Animal animal) => _animals.Add(animal);
    }
}
