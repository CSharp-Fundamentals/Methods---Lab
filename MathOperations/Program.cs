using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            Operation(firstNum,operation,secondNum);
        }
        static void Operation(int firstNum, string operation, int secondNum) {
            int sum = 0;
            if (operation=="+")
            {
                sum =firstNum + secondNum;
            }
            else if (operation=="-")
            {
                sum =firstNum - secondNum;
            }
            else if (operation == "/")
            {
                sum =firstNum / secondNum;
            }
            else if (operation == "*")
            {
                sum =firstNum * secondNum;
            }
            Console.WriteLine(sum);
        }
    }
}
