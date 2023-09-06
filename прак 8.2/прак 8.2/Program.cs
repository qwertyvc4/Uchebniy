namespace прак_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Двоичный поиск + Задание №2");
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Искомый элемент в массиве: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int l = 0;
            int r = n - 1;
            int k;
            int f = 0;
            while (l <= r)
            {
                k = (r + l) / 2;
                if (a[k] == b)
                {
                    Console.WriteLine("Позиция искомого элемента: " + k);
                    f = 1;
                    break;
                }
                else
                if (a[k] < b)
                    l = k + 1;
                else
                    r = k - 1;
            }
            if (f == 0)
                Console.WriteLine("Искомый элемент не найден");

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}