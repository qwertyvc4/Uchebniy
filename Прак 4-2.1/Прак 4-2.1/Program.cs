namespace Прак_4_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int s = 0;
            int k = 0;
            do
            {
                Console.WriteLine(",,,");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    s = s + a;
                }
            }
            while (a != 0);

            if (k > 0)
            {
                Console.WriteLine("dfg = " + s);
            }
            else
                Console.WriteLine("---");
        }
    }
}