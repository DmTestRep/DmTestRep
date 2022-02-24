using System;

namespace Exercise_4
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

        Label3: Console.Write("Symbol: ");
            string str3 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(str3))
            {
                Console.WriteLine("Enter at least one symbol");
                goto Label3;
            }
            else
            {
                do
                {
                    try
                    {
                        char symb = Convert.ToChar(str3);
                        string concat = str1 + str2;
                        int lastindex = concat.LastIndexOf(symb);
                        Console.WriteLine("Index of {0} in {1}:{2}", symb, concat, lastindex);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter only one symbol");
                        goto Label3;
                    }
                }
                while (true);
            }

            

            // Index of XX in YY: ZZ”, где XX считанный символ, YY – результат конкатенации строк, ZZ – индекс посл. вхождения.

        }
    }
}
