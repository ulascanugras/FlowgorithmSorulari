using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1den100eTekveÇiftSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cift sayılar");
            for (int i = 1; i < 100; i++)
            {
                if (i%2==0)
                {
                    Console.Write(i+ " ");
                }
            }
            Console.WriteLine("\n  Tek sayılar");
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();

        }
    }
}
