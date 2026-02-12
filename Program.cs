using System;
namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- C# Math Power-Up ---");

            double val = -10.75;
            
            // 1. Math.Abs - Absolute value
            Console.WriteLine($"Absolute: The distance of {val} from zero is {Math.Abs(val)}");

            // 2. Math.Pow - Power/Exponents
            double baseNum = 3;
            double exponent = 4;
            Console.WriteLine($"{baseNum} to the power of {exponent} is {Math.Pow(baseNum, exponent)}");

            // 3. Math.Sqrt - Square Root
            double squareMe = 81;
            Console.WriteLine($"The square root of {squareMe} is {Math.Sqrt(squareMe)}");

            // 4. Math.Floor - Always rounds DOWN
            Console.WriteLine($"Floor of {val}: {Math.Floor(val)} (Moves toward negative infinity)");

            // 5. Math.Round - Rounds to the nearest whole number
            double roundMe = 10.5;
            Console.WriteLine($"Rounding {roundMe} gives you: {Math.Round(roundMe)}"); 

            Console.WriteLine("\nDone! Press any key to close.");
            Console.ReadKey();
        }
    }
}