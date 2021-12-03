using System;

namespace Design_Patterns_Assignment.Strategy
{
    internal class FacebookHandler : IMessageHandler
    {
        public void SendMessage(string message)
            => Console.WriteLine($"Sending '{message}' as a Facebook-message.");
    }
}
