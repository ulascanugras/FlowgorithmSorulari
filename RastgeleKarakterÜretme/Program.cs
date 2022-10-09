using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleKarakterÜretme
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan kaç adet karakter uretmek ıstedıgını sorarak kucuk harflerden olusan bır metın olusturunuz ve ekrana yazdırınız.
            Console.WriteLine("kac adet karakter uretmek ıstıyorsunuz");
            //int n = Convert.ToInt32(Console.ReadLine());


            //Random rnd = new Random();
            //for (int i = 0; i <n; i++)
            //{
            //    int sayi = rnd.Next(97, 127);
            //    Console.Write((Convert.ToChar(sayi)) + " ");
            //}



            //-------------------------------------------------------------------
            // yöntem 1
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(Convert.ToChar(rnd.Next('a','z'+1)) + "");
            //}


            //Console.ReadKey();
            // yöntem 2---------------------------------------------------------------------------------------------------
            //Console.WriteLine("kac adet karakter uretmek ıstıyosunuz");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string uretilenKelime = "";

            //Random rnd = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    uretilenKelime += Convert.ToChar(rnd.Next('a', 'z' + 1));
            //}
            //Console.WriteLine(uretilenKelime);

            // yöntem 3--------------------------------------------------------------------------------------------------------

            int n = Convert.ToInt32(Console.ReadLine());
            string karakterHavuzu = "1234567890";
            Random rnd = new Random();
            string uretilenKelime2 = "";
            for (int i = 0; i < n; i++)
            {
                uretilenKelime2 += karakterHavuzu[rnd.Next(0, karakterHavuzu.Length)];
            }
            Console.WriteLine(uretilenKelime2);
            Console.ReadKey();
            //home ve end tusları satırın en basına ve en sonuna gıder
            // sıfte basılı tutarak sag sol yada asagı yukarı yaparsan secerek gıder
            // ctrl g yaparsan ckan yere gıdıcegın satırı yazarsan gıdersın



        }
    }
}
