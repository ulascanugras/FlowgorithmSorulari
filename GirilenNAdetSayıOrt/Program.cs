using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenNAdetSayıOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            //double n, toplam, ortalama, temp;
            //toplam = 0;
            //Console.WriteLine("kac adet sayı gırmek ıstıyonuz ");
            //n = Convert.ToDouble(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"{i} girmeye baslayınız");
            //    temp = Convert.ToDouble(Console.ReadLine());
            //    toplam = toplam + temp;
            //    Console.WriteLine("sayıların toplamı " + toplam);

            //}
            //ortalama = toplam / n;
            //Console.WriteLine("gırılen sayıların ortalaması" + ortalama);
            
            Console.Write(" sayı girin ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            giris:
            Console.WriteLine("sayı girmek istiyormusun girmek için 1, çıkmak için 2 basınız");
            string cevap = Console.ReadLine();
            if (cevap=="1")
            {
                Console.WriteLine("sayı giriniz");
                sayi += Convert.ToInt32(Console.ReadLine());
                sayac++;
                goto giris;

            }
            int ortalama = sayi / sayac;
            Console.WriteLine("ortalama " + ortalama);


            Console.ReadKey();

        }
    }
}
