using System;

namespace MethodExercise
{
    class Program
    {
        public static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        public static int Subtract(int var1, int var2)
        {
            return var1 - var2;
        }
        public static int Multiply(int var1, int var2)
        {
            return var1 * var2;
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
            int added = Add(1, 2, 3);
            int subtracted = Subtract(3, 2);
            int multiplied = Multiply(3, 2);
            int divided = Divide(6, 2);
            int modulus = Modulus(7, 2);
            Console.WriteLine($"1+2+3={added}\n3-2={subtracted}\n3*2={multiplied}\n6/2={divided}\n7%2={modulus}");
        }
    }
}