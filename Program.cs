using System;

namespace ProcDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<5;i++)
            {
                int A = Convert.ToInt16(Console.ReadLine());
                var c = OddEvenNum(A);
                Console.WriteLine(c);
            }
        }

        static string OddEvenNum(int a)
        {
            if (a % 2 == 0)
            {
                return "even";
                
            }
            else
            {
                return  "odd";
            }
        }
    }
}