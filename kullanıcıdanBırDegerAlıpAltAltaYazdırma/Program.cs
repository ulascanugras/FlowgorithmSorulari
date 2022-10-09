using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdanBırDegerAlıpAltAltaYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir ifade giriniz");
            string ad = Console.ReadLine();

            //for (int i =0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);// girilen ifadenin degerlerini 0 olsa 0. değerini 1 olsa 1. değerini yaxdırıyo.
            //}

            for (int i = ad.Length-1; i >=0; i--)
            {
                Console.Write(ad[i]);// girilen ifadenin degerlerini 0 olsa 0. değerini 1 olsa 1. değerini yaxdırıyo.
            }// burada yazılan ısmın tersını yazdırdık.

            Console.ReadKey();

        }
    }
}
