using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string Scales { get; set; }
        public string Tail { get; set; }
        public int Claws { get; set; }
        public int Teeth { get; set; }
        public void PrintProperties()
        {
            Console.WriteLine($"The Scale Colors: {Scales}");
            Console.WriteLine($"The Tail Colors: {Tail}");
            Console.WriteLine($"Number of Claws: {Claws}");
            Console.WriteLine($"Number of Teeth: {Teeth}");
            Console.WriteLine();
        }
    }
}
