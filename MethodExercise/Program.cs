using System;

namespace MethodExercise
{
    class Program
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        public static int Subtract(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static int Multiply(params int[] numbers)
        {
            int sum = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum *= numbers[i];
            }
            return sum;
        }
        public static int Divide(int var1, int var2)
        {
            return var1 / var2;
        }
        public static int Modulus(int var1, int var2)
        {
            return var1 % var2;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            //Console.WriteLine("What is a name for a dog?");
            //string dogName = Console.ReadLine();

            //Console.WriteLine("What color is your dog?");
            //string dogColor = Console.ReadLine();

            //Console.WriteLine($"Where was a man named {name}, he was {age} years old.");
            //Console.WriteLine($"He had a {dogColor} dog named {dogName}.");
            //Console.WriteLine($"{name} loved {dogName}, but he did not love being {age} years old.");

            Console.WriteLine("Numbers to add:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The total is {Add(num1, num2)}\n");

            Console.WriteLine("Numbers to subtract:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The total is {Subtract(num1, num2)}\n");

            Console.WriteLine("Numbers to multiply:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The total is {Multiply(num1, num2)}\n");

            Console.WriteLine("Numbers to divide:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The total is {Divide(num1, num2)}\n");

            Console.WriteLine("Numbers to modulus:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The total is {Modulus(num1, num2)}\n");
        }
    }
}