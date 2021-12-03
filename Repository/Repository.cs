
using System;

namespace Design_Patterns_Assignment.Repository
{
    internal static class Repository
    {
        internal static IDbContext Database { get; private set; } = new SimulatedDatabase();

        internal static void Run(bool firstRun = true)
        {
            if (firstRun) Console.WriteLine("-- Repository --");

            Console.WriteLine($"- {Database.Name} -");
            var data = Database.Load("Dataset A");
            var customer = Database.Load("From Table Customer Where Name==Steve");
            var animal = Database.Load("From Table Animal Where Owner==Steve");

            Database.Save(data);
            Database.Save(customer);
            Database.Save(animal);

            if (firstRun)
            {
                Database = new SimulatedAPI();
                Run(false);
            }

            Console.WriteLine();
        }
    }
}