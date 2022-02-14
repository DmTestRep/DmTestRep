using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X: ");
            double X_value = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double Y_value = Convert.ToDouble(Console.ReadLine());
            Console.Write("Z: ");
            double Z_value = Convert.ToDouble(Console.ReadLine());

            double Case1 = (X_value + Y_value) * (Math.Pow(Z_value, 2) + 1);
            double Case2 = (X_value % Z_value - 1) * Math.Sqrt(Y_value);
            double Case3 = (X_value * Y_value + Y_value * Z_value) / Math.Pow(Z_value, 3);

            Console.WriteLine("Case1: {0}", Case1);
            Console.WriteLine("Case2: {0}", Case2);
            Console.WriteLine("Case3: {0}", Case3);
            Console.ReadLine();
        }
    }
}
