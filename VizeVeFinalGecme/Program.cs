using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeVeFinalGecme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vize ve final notlarınızı giriniz");
            double vize, final,ortalama;
            Console.Write("vize=");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("final=");
            final = Convert.ToDouble(Console.ReadLine());
            ortalama = ((vize * 30) / 100) + ((final * 70) / 100);
            if (ortalama>50)
            {
                if (final>50)
                {
                    Console.WriteLine("gectınız");
                }
                else
                {
                    Console.WriteLine("kaldınız");
                }
            }
            else
            {
                Console.WriteLine("kaldınız");
            }

            Console.ReadKey();
        }
        
    }
}
