using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int col = int.Parse(Console.ReadLine());
            Order(product, col);
        }
        static void Order(string product, int col) {
            double result = 0.0;
            switch (product)
            {
                case "coffee": result = col * 1.50; break;
                case "water": result = col * 1.00; break;
                case "coke": result = col * 1.40; break;
                case "snacks": result = col * 2.00; break;
                default:
                    break;
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
