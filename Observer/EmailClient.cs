using System;

namespace Design_Patterns_Assignment.Observer
{
    internal class EmailClient
    {
        public EmailClient(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public void HandleEmail(string email)
            => Console.WriteLine($"[Client {Id}] {email}");
    }
}