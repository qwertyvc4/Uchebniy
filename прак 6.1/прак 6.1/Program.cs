using System;

namespace прак_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int w = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[w];
            int i;
            for (i = 0; i < w; i++)
            {
                Console.Write("Введите элемент массива: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int r = a[1] - a[0];
            for (i = 1; i < w; i++)
            {
                if (r != a[i] - a[i - 1])
                {
                    r = 0;                   
                }
            }
            if (r > 0)
            {
                Console.WriteLine("Разность: " + r);
            }
            if (r == 0)
            {
                Console.WriteLine("Нет ариф. п: " + r);
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}