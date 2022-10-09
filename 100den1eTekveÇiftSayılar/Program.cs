using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100den1eTekveÇiftSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("cift sayılar");
            for (int i = 100; i > 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+ " ");
                }
            }

            Console.WriteLine("\n  Tek sayılar");
            for (int i = 99; i > 1; i-=2)
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
