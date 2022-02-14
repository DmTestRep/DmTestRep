using System;

namespace AT_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            bool repeat = true;
            while (repeat)
            {
                do
                {
                    Console.Write("A = ");
                }
                while (!int.TryParse(Console.ReadLine(), out a));
                do
                {
                    Console.Write("B = ");
                }
                while (!int.TryParse(Console.ReadLine(), out b));
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Ошибка, попробовать еще раз? Y/N");
                    var ki = Console.ReadKey(true);
                    if (ki.Key != ConsoleKey.Y)
                        repeat = false;
                    continue;
                }
                Console.WriteLine("A: {0}, B: {1}, SSSS: {2}", a, b, a * b);
                repeat = false;
                Console.ReadKey();
            }
        }
    }
}
