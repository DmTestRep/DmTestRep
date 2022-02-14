using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            double Diagonal = Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2) + Math.Pow(Height, 2));

            Console.WriteLine("diagonal: {0}", Diagonal);
            Console.ReadLine();
        }
    }
}
