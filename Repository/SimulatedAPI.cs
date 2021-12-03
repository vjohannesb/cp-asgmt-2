using System;

namespace Design_Patterns_Assignment.Repository
{
    public class SimulatedAPI : IDbContext
    {
        public string Name { get; set; } = "Simulated API";

        public string Load(string v) => "{ query: " + v + " }";

        public void Save(string data) => Console.WriteLine($"[POST] '{data}'");
    }
}
