using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string Feather { get; set; }
        public string Wings { get; set; }
        public string Beak { get; set; }
        public int Talons { get; set; }
        public void PrintProperties()
        {
            Console.WriteLine($"The Feather Colors: {Feather}");
            Console.WriteLine($"The Wing Colors: {Wings}");
            Console.WriteLine($"The Beak Color: {Beak}");
            Console.WriteLine($"Number of Talons: {Talons}");
            Console.WriteLine();
        }
    }
    
    
}
