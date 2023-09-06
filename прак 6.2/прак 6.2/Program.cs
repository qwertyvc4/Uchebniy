namespace прак_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[x];
            int i;
            for (i = 0; i < x; i++)
            {
                Console.Write("Введите элемент массива: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("По возрастанию - 1 / по убыванию - 2: ");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("По возрастанию: ");
                    Array.Sort(a);
                    foreach (int n in a)
                        Console.WriteLine(n);
                    break;
                case 2:
                    Console.WriteLine("По убыванию: ");
                    Array.Sort(a);
                    Array.Reverse(a);
                    foreach (int n in a)
                        Console.WriteLine(n);
                    break;
            }

            int v = 1;
            for (i = 1; i < x; i++)
            {
                if (a[i - 1] != a[i])                
                    v++;               
            }
            Console.WriteLine("Кол-во различных: " + v);
            
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}