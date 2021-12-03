using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class SMSHandler : IMessageHandler
    {
        public void SendMessage(string message)
            => Console.WriteLine($"Sending '{message}' as an SMS.");
    }
}
