using System;

namespace Design_Patterns_Assignment.Repository
{
    public class SimulatedDatabase : IDbContext
    {
        public string Name { get; set; } = "Simulated Database";

        public string Load(string v) => v;

        public void Save(string data) => Console.WriteLine($"Saving data '{data}'");
    }
}
