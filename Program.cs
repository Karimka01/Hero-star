using System;
using System.Collections.Generic;
using System.Text;



using Persona;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Person artem = new Person("Vasilev", "Evgeniy", "Mihailovich", 25, 98, "Red");


            Console.WriteLine(artem);
            Random rnd = new Random();
            bool flag = true;
            int value = rnd.Next(1, 5);
            int previousValue = value;
            while (flag)
            {
                Console.WriteLine("Напишите begin/stop:");
                string name = Console.ReadLine();
                if (name == "begin")
                {
                    switch (value)
                    {
                        case 1:
                            artem.runInWork();
                            break;
                        case 2:
                            artem.eatDonut();
                            break;
                        case 3:
                            artem.sleeping();
                            break;
                        case 4:
                            artem.eatSoup();
                            break;
                    }
                }
                else if(name == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректные данные!!");
                }
                Console.WriteLine(value);
                value = rnd.Next(1, 5);
                while(value == previousValue){
                   value = rnd.Next(1, 5);
                }
                previousValue = value;

            }

        }
    }
}