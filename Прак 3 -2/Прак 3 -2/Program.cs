using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Прак_3__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Вводим x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводим y: ");
            y = Convert.ToInt32(Console.ReadLine());
            if((y <= 6) && (y >= 0) && (x >= 0) && (y <= -2 * x + 4) && (y <= -1 * x + 6))
            {
                Console.WriteLine("Принадлежит");
            }
            else
            {
                Console.WriteLine("Не принадлежит");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;

        }
    }
}