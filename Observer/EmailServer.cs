using System;
using System.Collections.Generic;
using System.Threading;

namespace Design_Patterns_Assignment.Observer
{
    internal static class EmailServer
    {
        private static readonly List<EmailClient> _clients = new();

        public static void AddClient(EmailClient client)
            => _clients.Add(client);

        public static void RemoveClient(EmailClient client)
            => _clients.Remove(client);

        public static void NotifyClients(string email)
        {
            foreach (EmailClient client in _clients)
                client.HandleEmail(email);
        }

        // Simulate server
        public static void Listen()
        {
            Console.WriteLine("Email server is running and listening on port 3000.");

            // Simulate listening for connections
            while (DateTime.Now.Second % 5 != 0) { }

            // On Connection
            HandleConnection();
        }

        private static void HandleConnection()
        {
            Console.WriteLine("[Server] Email received! Notifying clients...");

            var email = $"{DateTime.Now} This is an email.";
            NotifyClients(email);
        }
    }
}