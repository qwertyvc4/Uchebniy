using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рязанова Юлия");
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Вывод старых и новых цен");
            Console.WriteLine("*******************");
            int a, c, b, d, p;
            Console.WriteLine("Процент:");
            p = Convert.ToInt32(Console.ReadLine ());
            Console.WriteLine("Старая цена-1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Старая цена-2:");
            c = Convert.ToInt32(Console.ReadLine());
            b = a + a * p / 100;
            d = c + c * p / 100;
            Console.WriteLine("Новая цена-1 = " + b);
            Console.WriteLine("Новая цена-2 = " + d);

            while (Console.ReadKey().Key!=ConsoleKey.Escape) ;

        }

    }
}
