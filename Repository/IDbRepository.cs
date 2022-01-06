using Design_Patterns_Assignment.Repository.Models;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.Repository
{
    // Tightly bound to Customer/Animal due to assignment only encompassing Repository pattern
    internal interface IDbRepository
    {
        string GetDataset();
        void SaveDataset();

        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(string name);
        void SaveCustomer(Customer customer);

        IEnumerable<Animal> GetAnimals();
        Animal GetAnimal(Customer owner);
        void SaveAnimal(Animal animal);
    }
}
