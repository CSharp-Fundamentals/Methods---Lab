using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string result = Sign(num);
            Console.WriteLine(result);
        }
        static string Sign(int number) {
            string sign = null;
            if (number>0)
            {
                sign = "positive";
            }
            else if (number<0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }
            return $"The number {number} is {sign}.";
        }
    }
}
