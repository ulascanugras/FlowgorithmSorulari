using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezegenAgırlık
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan dunyadaki agırlık bılgısını kg cınsınden alarak ay, gunes,mars, uranus, neptun,saturn,jupıter,merkur,venus,pluton,ceres,eris,hauema,makemake uydu/gezenen/cuce gezegenlerındekı agırlıklarını hesaplayınız.
            // agırlıgın formulu 
            //G= m*g  m kutle g yer cekımı ,g agırlık
            Console.WriteLine("dunyadaki agırlıgınızı gırınız");
            double kg;
            kg = Convert.ToDouble(Console.ReadLine());
            double ay, gunes, mars, uranus, neptun, saturn, jupıter, merkur, venus, pluton, ceres, eris, hauema, makemake, s1;
            s1 = kg / (9.81);
            ay = s1*(1.62);
            gunes = s1*274;
            mars = s1*(3.721);
            uranus = s1*(8.87);
            neptun = s1* (1.15);
            saturn =s1* (10.44);
            jupıter =s1*(24.79);
            merkur =s1* (3.7);
            venus =s1* (8.87);
            pluton =s1* (0.62);
            ceres =s1* (0.27);
            eris = s1*(0.82);
            hauema = s1*(0.401);
            makemake = s1 * (0.5);

            Console.WriteLine($"aydaki deger= {ay},\n gunestekı deger= {gunes},\n marstaki deger {mars} \n,uranustekı deger={uranus}\n nepturndekı deger = {neptun}\n saturndekı deger ={saturn}\n jupıterdekı deger = {jupıter}\n merkurdekı deger= {merkur}\n venustekı deger ={venus}\n plutondakı deger {pluton}\n ceresdekı deger={ceres}\n erisdeki deger {eris}\n haumeadaki deger = {hauema} \n makemakedekı deger = {makemake}");

            //Cw("kutledegeri"+ Math.Round(m,2)); // Math.Round ondalıklı sayılar ıcın yuvarlama ıslemı yapar 2 degerı ıse vurgulden sonra 2 basamak goster demek.




            Console.ReadKey();

        }
    }
}
