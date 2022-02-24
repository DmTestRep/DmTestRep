using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)           
        {
            double X, Y, Z;
            do
            {
                try
                {
                Console.Write("X:");
                    X = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numeric value");
                }
            }
            while (true);

            do
            {
                try
                {
                Label1: Console.Write("Y:");
                    Y = Convert.ToDouble(Console.ReadLine());
                    if (Y == 0)
                    {
                        Console.WriteLine("Value cannot be zero");
                        goto Label1;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numeric value");
                }
            }
            while (true);


            do
            {
                try
                {
                Label2: Console.Write("Z:");
                    Z = Convert.ToDouble(Console.ReadLine());
                    if (Z == 0)
                    {
                        Console.WriteLine("Value cannot be zero");
                        goto Label2;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numeric value");
                }
            }
            while (true);


            // Case 1 - Cумма x и y, умноженная на увеличенный на единицу квадрат z
            // Case 2 - Уменьшенный на единицу остаток от деления x на z, умноженный на квадратный корень из y
            // Case 3 - Сумма умножений пар чисел х и y & y и z, разделенная на куб числа z
        
            Console.WriteLine($"First expression result: {(X + Y) * (Math.Pow(Z, 2) + 1)}");
            Console.WriteLine($"Second expression result: {(X % Z - 1) * Math.Sqrt(Y)}");
            Console.WriteLine($"Third expression result: {(X * Y + Y * Z) / Math.Pow(Z, 3)}");
            Console.ReadLine();
        }
    }
}


        
