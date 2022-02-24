using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
        Label1: Console.Write("1st string: ");
            string str1 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(str1))
            {
                Console.WriteLine("Enter at least one symbol");
                goto Label1;
            }

        Label2: Console.Write("2nd string: ");
            string str2 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("Enter at least one symbol");
                goto Label2;
            }

        Label3: Console.Write("3nd string: ");
            string str3 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(str3))
            {
                Console.WriteLine("Enter at least one symbol");
                goto Label3;
            }

            string STR1 = str1.ToUpper();
            string STR2 = str2.ToUpper();
            string STR3 = str3.ToUpper();


            bool A = STR1.StartsWith(STR2);
            Console.WriteLine("String {0} starts from {1}:{2}", STR1, STR2, A);

            bool B = STR1.EndsWith(STR3);
            Console.WriteLine("String {0} ends with {1}:{2}", STR1, STR3, B);
        }
    }
}
