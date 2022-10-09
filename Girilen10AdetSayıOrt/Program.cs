using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen10AdetSayıOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo.CurrentCulture = new CultureInfo("en-US); // console kultur degıstırme  // kultur tr ıse en-us gırılır

            
            //Console.WriteLine(CultureInfo.CurrentCulture); // sistem kultur bılgısını console a yazar
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine((5.5).ToString("c2")); // ondalıklı sayıyı para formatında ekrana yazar birimi ile 
            double ort, sayi1,toplam;
            double sayi2;
              

            sayi1 = 11;
            toplam = 0;
            //here:
            //if (sayi1<=10)
            //    {
            //    Console.WriteLine("10 adet sayı giriniz");
            //    goto here; 
            //    toplam = toplam + sayi1;
            //    Console.WriteLine(toplam);
            //}
            //Console.WriteLine("lutfen 10 adet sayı gırınız" );
            for (int i = 1; i < sayi1; i++)
            {
                Console.WriteLine($"lutfen {i} .adet sayı gırınız");
                sayi2 = Convert.ToDouble(Console.ReadLine());
                toplam = toplam + sayi2;
                
            }
            Console.WriteLine($" girilen sayıların toplamı = {toplam}");

            ort = toplam / 10;
            Console.WriteLine("girilen sayıların otalaması " + ort);
            Console.ReadLine();
        }
    }
}
