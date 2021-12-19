using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Selin ";
            musteri1.Soyadi = "DEVECİ";
            musteri1.TelNo = 5555555555;
        

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Furkan";
            musteri2.Soyadi = "Dedee";
            musteri2.TelNo = 56645;
   

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager Musteri = new MusteriManager();
            Musteri.Ekle(Musteriler);
            Musteri.Listeleme(Musteriler);
            Musteri.Silme(Musteriler);
            Musteri.Guncelleme(Musteriler);


        }
    }
}