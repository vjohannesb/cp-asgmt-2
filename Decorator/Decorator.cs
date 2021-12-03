
using System;

namespace Design_Patterns_Assignment.Decorator
{
    internal class Decorator
    {
        internal static void Run()
        {
            Console.WriteLine("-- Decorator-- ");
            Console.WriteLine("Please enter text to HTML:ify.");

            var textInput = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Bold");
            Console.WriteLine("Deleted");
            Console.WriteLine("Emphasized");
            Console.WriteLine("Important");
            Console.WriteLine("Inserted");
            Console.WriteLine("Italic");
            Console.WriteLine("Marked");
            Console.WriteLine("Smaller");
            Console.WriteLine("SubScript");
            Console.WriteLine("SuperScript");
            Console.WriteLine();

            Console.WriteLine("Type the tags you want separated by space");

            var tagSelection = Console.ReadLine();
            var result = HTMLGenerator.TagProcessor(tagSelection, textInput);

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}