using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenİsminUzunluguKadarYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("biri isim giriniz");
            //string ad = Console.ReadLine();
            //int uzunluk = ad.Length;
            //int i;
            //i = 1;

            //while (i<=ad.Length)
            //{
            //    Console.WriteLine(ad);
            //    i = i + 1;
            //}


            Console.WriteLine("biri isim giriniz");
            string ad = "";
            
            giris:
            try
            {
                 ad = Console.ReadLine();
                int sayi = Convert.ToInt32(ad);
            }
            catch (Exception)
            {

                int uzunluk = ad.Length;
                for (int i = 0; i < ad.Length; i++)
                {
                    Console.WriteLine(ad);
                }
                
            }
            Console.WriteLine("lutfen sayı girmeyiniz");
            goto giris;
            ////while (ad.Contains("1"))
            //{
            //    Console.WriteLine( "ad ıcersınde sayısal deger olamaz");
            //    ad = Console.ReadLine;
            //}

            Console.ReadLine();

        }
        
    }
}
