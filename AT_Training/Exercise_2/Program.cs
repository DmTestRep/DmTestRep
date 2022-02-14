using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("length: ");
            double length = int.Parse(Console.ReadLine());
            Console.Write("width: ");
            double width = int.Parse(Console.ReadLine());
            Console.Write("height: ");
            double height = int.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt (length + width + height);

            Console.WriteLine("diagonal: {0}", diagonal);
            Console.ReadLine();
        }
    }
}
