using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE Be sure to follow best practice when creating your classes

            // DONE a class Animal
            // give this class 4 members that all Animals have in common


            // DONE a class Bird
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

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.CanFly = true;
            myBird.beakLength = 3.5;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };

            var myAnimal = new Animal[] { myBird, lizard };

            foreach (var animal in myAnimal)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} Years Old");
                Console.WriteLine($"It Has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");
            }
                            
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
