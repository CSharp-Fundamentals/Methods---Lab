using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            RepeatString(text,repeat);
        }
        static void RepeatString(string text, int repeat) {
            for (int i = 0; i < repeat; i++)
            {
                Console.Write(text);
            }
        }
    }
}
