using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Strategy
    {
        private static IMessageHandler _handler;
        private static readonly EmailHandler _emailHandler = new();
        private static readonly SMSHandler _smsHandler = new();
        private static readonly FacebookHandler _facebookHandler = new();
        internal static void Run()
        {
            Console.WriteLine("-- Strategy --");
            var message = "This is the message";

            Console.WriteLine("1. Send message as email");
            Console.WriteLine("2. Send message as SMS");
            Console.WriteLine("3. Send message as Facebook-message");
            Console.WriteLine("0. Exit");

            (var left, var top) = Console.GetCursorPosition();

            while (true)
            {
                var input = Console.ReadKey(true).KeyChar;
                if (input == '1') _handler = _emailHandler;
                else if (input == '2') _handler = _smsHandler;
                else if (input == '3') _handler = _facebookHandler;
                else if (input == '0') break;
                else continue;

                Console.SetCursorPosition(left, top);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(left, top);

                _handler.SendMessage(message);
            }
            Console.WriteLine();
        }
    }
}