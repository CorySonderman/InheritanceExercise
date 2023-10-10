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
            var  bird = new Bird();
            bird.Color = "blue";
            bird.CanTalk = true;
            bird.CanFly = true;
            bird.Migrate = false;
            bird.LandSeaOrAir = "air";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile();
            snake.Color = "brown with a diamond pattern";
            snake.LandSeaOrAir = "brush and under dead trees";
            Console.WriteLine($"These snakes are {snake.Color}.  They are often " +
                $"found in {snake.LandSeaOrAir}.");
            Console.WriteLine();
            Console.WriteLine($"One of my favorite birds is the macaw.  Especially " +
                $"the {bird.Color} and gold macaw.  They are large birds that rule the {bird.LandSeaOrAir}.");
            Console.WriteLine();
        }
    }
}
