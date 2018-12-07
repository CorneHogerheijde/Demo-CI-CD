using System;

namespace Prefab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! We're about to calculate the square of your input.");
            Console.WriteLine("Please input a number and press enter:");
            var userInput = Console.ReadLine();

            var system = new TheSystem(new CalculationService());
            var output = system.ProcessUserInput(userInput);

            Console.WriteLine($"The output of the system is: {output}");
            Console.ReadLine();
        }
    }
}
