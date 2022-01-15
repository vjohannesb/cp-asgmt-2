using Design_Patterns_Assignment.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository.Data
{
    // Simulates a data storage for the purpose of the examination
    internal class MockDb
    {
        public List<Customer> Customers { get; set; }
        public List<Animal> Animals { get; set; }

        public MockDb()
        {
            var steve = new Customer() { Name = "Steve" };
            var stevesDog = new Animal() { Name = "Steves dog", Owner = steve };
            Customers = new() { steve };
            Animals = new() { stevesDog };
        }
    }
}
