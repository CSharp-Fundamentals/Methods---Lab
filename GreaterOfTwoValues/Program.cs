using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine(MaxInt(firstNum, secondNum));
            }
            else if (type=="char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());
                Console.WriteLine(MaxChar(ch1,ch2));
            }
            else if (type=="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(MaxString(first,second));
            }
        }
        static int MaxInt(int firstNum, int secondNum) {
            if (firstNum>secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        static char MaxChar(char ch1, char ch2) {
            if (ch1>ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }
        static string MaxString(string first, string second) {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
