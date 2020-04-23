using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Vova Zhdanov";
            string location = "Rexburg, ID";

            Console.WriteLine($"My name is: {name}");
            Console.WriteLine($"My location is: {location}");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
