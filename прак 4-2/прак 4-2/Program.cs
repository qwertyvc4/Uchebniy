using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace прак_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вводим a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вводим b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = a; i <= b; i++)
                s += i;
            Console.WriteLine("Сумма = " + s);
            Console.ReadKey();

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}