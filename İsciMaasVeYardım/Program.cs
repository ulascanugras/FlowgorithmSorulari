using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsciMaasVeYardım
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saat, haftalikUcret, aylikUcret, cocukSayisi, fazlaMesaiSaati;
            aylikUcret = 0;
          
                for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("calısma saatinizi giriniz");
                saat = Convert.ToDecimal(Console.ReadLine());
                if (saat>40)
                {
                    fazlaMesaiSaati = saat - 40;
                    haftalikUcret = 40 * 15;
                    haftalikUcret = haftalikUcret + (fazlaMesaiSaati * 2 * 15);
                }
                else
                {
                    haftalikUcret = 15 * saat;
                    
                }
                aylikUcret = aylikUcret + haftalikUcret;
            }
            Console.WriteLine("cocuk sayısını giriniz");
            cocukSayisi = Convert.ToDecimal(Console.ReadLine());
            if (cocukSayisi>0 )
            {
                if (cocukSayisi>3)
                {
                    cocukSayisi =3;
                }
                aylikUcret = aylikUcret * ((cocukSayisi * 0.05m) + 1); // aylikUcret*=((cocukSayisi*0.05m)+1)
            }
            

            Console.WriteLine(" AYLIK UCRETINIZ == "  + aylikUcret);
            Console.ReadKey();
        }
    }
}
