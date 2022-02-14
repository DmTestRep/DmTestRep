using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2) + Math.Pow(height, 2));

            Console.WriteLine("diagonal: {0}", diagonal);
            Console.ReadLine();
        }
    }
}
