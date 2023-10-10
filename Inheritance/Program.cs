using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var  firstBird = new Bird();
            firstBird.Color = "blue";
            firstBird.CanTalk = true;
            firstBird.CanFly = true;
            firstBird.Migrate = false;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile();
            snake.LivingSpace = "trees";
            snake.Color = "brown with a diamond pattern";

            Console.WriteLine($"These snakes are {snake.Color}.  They live " +
                $"in {snake.LivingSpace}.");
            Console.WriteLine();
            Console.WriteLine($"One of my favorite birds is the macaw.  Especially " +
                $"the {firstBird.Color} and gold macaw.");
            Console.WriteLine();
        }
    }
}
