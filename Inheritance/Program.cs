using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird1 = new Bird()
            {
                Feather = "Blue",
                Beak = "Black",
                Wings = "Green",
                Talons = 6,
                Eyes = true,
                Legs = true,
                Ears = true,
                Feet = true
            };
            Console.WriteLine();
            Console.WriteLine("The Properties of this bird are: ");
            Console.WriteLine();
            bird1.PrintProperties();

            var rep1 = new Reptile();
            rep1.Scales = "Red";
            rep1.Tail = "Black";
            rep1.Claws = 0;
            rep1.Teeth = 52;
            rep1.Eyes = true;
            rep1.Legs = true;
            rep1.Ears = true;
            rep1.Feet = false;
            Console.WriteLine();
            Console.WriteLine("The Properties of this reptile are: ");
            Console.WriteLine();
            rep1.PrintProperties();


            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
