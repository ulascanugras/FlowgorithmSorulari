using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArananIfade
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ifade, arananİfade;
            //int adet;
            //adet = 0;

            //Console.WriteLine("bir ifade giriniz");
            //ifade = Console.ReadLine();
            //Console.WriteLine("aranacak gelımeyı gırınız");
            //arananİfade = Console.ReadLine();
            //for (int i = 0; i < ifade.Length-1; i++)
            //{

            //    //if (ifade[i].ToString() == arananİfade)
            //    //{
            //    //    adet = adet + 1;

            //    //}
            //    if (ifade[i] == Convert.ToChar(arananİfade)) // yöntem iki
            //    {
            //        adet++;
            //    }
            //    Console.WriteLine(adet);
            //    Console.ReadKey();

            //}
            //---------------------------------------------------------------------------------------------------------------------
            // metin icinde aranan kelimeyi bulma ======
            string metin = Console.ReadLine(); // "ankara'da bilge bilgeadama bisiklet ile gidiyor. bi"; olursa patlıyor bunu düzelt
            string kelime = Console.ReadLine(); // "bilge;
            int adet = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i]==kelime[0])
                {
                    bool iceriyorMu = true;
                    for (int j = 0; j < kelime.Length; j++)
                    {
                        if (metin[i + j]!=kelime[j] && i+j<metin.Length-1)
                        {
                            iceriyorMu = false;
                        }

                    }
                    if (iceriyorMu)
                    {
                        adet++;
                    }
                }
            }
            Console.WriteLine(adet);
            // ödev : metinde aranan kelimenin ilk harfi ile bitiyor ve uzunlugu kadar karakter kalmadıgı durumda program hata verıyor bunu nasıl cozebılırız?
            Console.ReadKey();



        }
    }
}
