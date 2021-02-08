using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;

            switch (command)
            {
                case "add": result=Add(firstNum,secondNum); break;
                case "multiply": result = Multiply(firstNum, secondNum); break;
                case "subtract": result = Subtract(firstNum, secondNum); break;
                case "divide": result = Divide(firstNum, secondNum); break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }
        private static int Add(int firstNum,int secondNum) {
            return firstNum + secondNum;
        }
        private static int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        private static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        private static int Divide(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
