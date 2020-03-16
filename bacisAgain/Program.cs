using System;
using System.Linq;
using NUnit.Framework;

namespace wish
{
    class Program
    {
        static void Main(string[] args)
        {
            Digits dig = new Digits();
            Math math = new Math();
            Random rnd = new Random();

            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 15);
            //Console.Beep(37, 10000);

            Console.WriteLine("----------------------КАЛЬКУЛИРУЕМ!----------------------");

            do
            {
                try
                {
                    math.DoMath(
                        dig.GetFirstNumber(),
                        dig.GetSecondNumber(),
                        dig.GetSymbol()
                               );
                }
                catch { Console.WriteLine("Ну и чего ты добился этим?"); }
         
                Console.WriteLine(".............................Еще раз? (да\\нет).............................");

            }
            while (Console.ReadLine() == "да");
 
        }
    }

    class Digits
    {
        public float GetFirstNumber()
        {
            Console.WriteLine("Введи число");
            return float.Parse(Console.ReadLine());
        }

        public float GetSecondNumber()
        {
            Console.WriteLine("Норм, введи еще число");
            float x = float.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Хехе, ты же не собрался на ноль делить, да?");
            }
            return x;
        }

        public string GetSymbol()
        {
            Console.WriteLine("Ок, а что делать то будем? + - : * ");
            return Console.ReadLine();
        }

    }

    class Math
    {
        public void DoMath(float x1, float z1, string e)
        {
            if (e == "+")
            {
                float res = x1 + z1;
                Console.WriteLine($"{x1} + {z1} = " + res);
            }
            else if (e == "-")
            {
                float res = x1 - z1;
                Console.WriteLine($"{x1} - {z1} = " + res);
            }
            else if (e == ":")
            {
                float res = x1 / z1;
                Console.WriteLine($"{x1} : {z1} =  {res}");
            }
            else if (e == "*")
            {
                float res = x1 * z1;
                Console.WriteLine($"{x1} * {z1} = " + res);
            }
            else
            {
                Console.WriteLine("ТЫ ВВЕЛ ДИЧЬ И СЛОМАЛ МЕНЯ ДОВОЛЕН???");
            }

        }
    }

}
