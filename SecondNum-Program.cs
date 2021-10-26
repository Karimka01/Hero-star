using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int width;
            int height;
            Console.ForegroundColor = ConsoleColor.Green;
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            string text = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ/-+=/][.,";
            while (true)
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(rand.Next(0, width), rand.Next(0, height));
                    Console.WriteLine(text[rand.Next(0, 45)]);

                }
                for (int i = 0; i < 20; i++)
                {
                    Console.SetCursorPosition(rand.Next(0, width), rand.Next(0, height));
                    Console.Write(" ");

                }


            }


        }
    }
}
