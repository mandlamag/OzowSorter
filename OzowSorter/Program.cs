using System;

namespace OzowSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">  Please enter arbitrary string: ");
            var input = Console.ReadLine();

            Console.WriteLine($">  sorted output is: {input.TrimAndSort()}");
        }
    }
}
