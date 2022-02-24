using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, W, H;
        Label1: Console.Write("Length:");
            string str1 = Console.ReadLine();
            if (int.TryParse(str1, out int check))
            {
                goto Label2;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(str1))
                {
                    Console.WriteLine("Enter at least one symbol");
                    goto Label1;
                }
                else
                    Console.WriteLine("Please enter a numeric value");
                goto Label1;
            }
        Label2: Console.Write("Width:");
            string str2 = Console.ReadLine();
            if (int.TryParse(str2, out int check1))
            {
                goto Label3;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(str2))
                {
                    Console.WriteLine("Enter at least one symbol");
                    goto Label2;
                }
                else
                    Console.WriteLine("Please enter a numeric value");
                goto Label2;
            }
        Label3: Console.Write("Height:");
            string str3 = Console.ReadLine();
            if (int.TryParse(str3, out int check2))
            {
                L = Convert.ToInt32(str1, 16);
                W = Convert.ToInt32(str2, 16);
                H = Convert.ToInt32(str3, 16);
                Console.WriteLine($"Parallelepiped diagonal length: {Math.Sqrt(Math.Pow(L, 2) + Math.Pow(W, 2) + Math.Pow(H, 2))}");
                Console.ReadLine();
            }
            else
            {
                if (String.IsNullOrWhiteSpace(str3))
                {
                    Console.WriteLine("Enter at least one symbol");
                    goto Label3;
                }
                else
                    Console.WriteLine("Please enter a numeric value");
                goto Label3;
            }
        }
    }
}
