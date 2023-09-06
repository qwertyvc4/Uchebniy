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
            Console.Write("Вводим A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вводим B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            
            while (A <= B)
            {
                int i;
                for (i = B; i >= A; i--)
                {
                    Console.Write(i * i * i + " ");
                }
                break;
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;

        }
    }
}