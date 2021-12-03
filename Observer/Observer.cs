using System;

namespace Design_Patterns_Assignment.Observer
{
    internal class Observer
    {
        internal static void Run()
        {
            Console.WriteLine("-- Observer --");

            var index = 1;
            EmailServer.AddClient(new EmailClient(index++));
            EmailServer.AddClient(new EmailClient(index++));

            EmailServer.Listen();

            Console.WriteLine();
        }
    }
}
