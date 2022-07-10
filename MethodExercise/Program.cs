using System;

namespace MethodExercise
{
    class Program
    {
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        public int Subtract(int var1, int var2)
        {
            return var1 - var2;
        }
        public int Multiply(int var1, int var2)
        {
            return var1 * var2;
        }
        public int Divide(int var1, int var2)
        {
            return var1 / var2;
        }
        public int Modulus(int var1, int var2)
        {
            return var1 % var2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("What about your favorite color?");
            string? color = Console.ReadLine();
            Console.WriteLine("And your favorite animal?");
            string? animal = Console.ReadLine();
            Console.WriteLine("Lastly, your favorite band?");
            string? band = Console.ReadLine();

            Console.WriteLine($"{name} was excited to go see the {color} {animal}s, their second favorite band right behind {band}.");


        }
    }
}