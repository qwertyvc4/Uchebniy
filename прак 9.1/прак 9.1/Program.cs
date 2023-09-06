namespace прак_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string t = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
                int a=(int)Char.GetNumericValue(t[i]);
                s = s + a;
            }
            Console.WriteLine("Сумма = " + s);

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}