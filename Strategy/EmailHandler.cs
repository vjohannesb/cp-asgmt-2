using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class EmailHandler : IMessageHandler
    {
        public void SendMessage(string message)
            => Console.WriteLine($"Sending '{message}' as an email.");
    }
}
