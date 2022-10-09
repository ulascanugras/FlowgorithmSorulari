using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanAlınanİ2Sayi
{
    class Program
    {
        static void Main(string[] args)//PascalCase
        {
            //int sayiBir = 5;// CamelCase
            double sayi1, sayi2, toplam, carpım, bölum, fark;
            Console.WriteLine("2 tane sayı giriniz");
            tekrar:
            Console.Write("sayı1:");
            sayi1 =Convert.ToDouble( Console.ReadLine());
            Console.Write("sayı2:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            if(sayi1==0 || sayi2==0)
            {
                goto tekrar;
            }
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2; //Marh.abs(sayi1-sayi2) sayıların farkının - olmasını saglar
            carpım = sayi1 * sayi2;
            //double bolum=sayi1/sayi2;
            bölum = sayi1 / sayi2;
            //bolum= Conver.ToDouble(sayiBir)/Convert.ToDouble.(sayi2);

            Console.WriteLine($" sayılaırın farkı= {fark} \n sayıların toplamı ={toplam} \n sayıların carpımı= {carpım} \n sayıların bolumu {bölum} dır");
            
            //Console.WriteLine(Environment.NewLine); bu asagı satıra bosluk atar
            Console.ReadKey();
        }
    }
}
