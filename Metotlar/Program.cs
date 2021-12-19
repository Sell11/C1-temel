using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tekrar tekrar kullanılabilirlik:metotlar/fonksiyon
// dont repeat yourself - DRY - Clean Code - Best Practice-

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 70;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler =new Urun[] {urun1,urun2};

            //type safe--tip güvenli
            foreach (Urun urun in urunler)//in urunler:urunler dizisinin elemanlarını tek tek gez//urun:veri tipi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------------------------");
            }

            Console.WriteLine("-----------------metotlar-----------------");

            //instance-ornek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);//yanlış yontem //
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,3);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,6);
           

        }



    }
}
