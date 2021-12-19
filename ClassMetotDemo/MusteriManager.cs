using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Ekle(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("--------------------Müşteri Ekleme Paneli-------------------");
                Console.WriteLine("Id: " + Musteri.Id);
                Console.WriteLine("Müşteri Adı: " + Musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + Musteri.Soyadi);
                Console.WriteLine("Telefon Numarası: " + Musteri.TelNo);
                Console.WriteLine("Tebrikler!Müşteri başarılı bir şekilde eklenmiştir.");
                Console.WriteLine("------------------------------------------------------------");
            }
        }
        public void Listeleme(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("------------------Müşteri Listeleme Paneli------------------");
                Console.WriteLine("Id: " + Musteri.Id);
                Console.WriteLine("Müşteri Adı: " + Musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + Musteri.Soyadi);
                Console.WriteLine("Telefon Numarası: " + Musteri.TelNo);
                Console.WriteLine("------------------------------------------------------------");
            }
        }
        public void Silme(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("--------------------Müşteri Silme Paneli-------------------");
                Console.WriteLine("Id'si: " + Musteri.Id + " ve Adı: " + Musteri.Adi + " olan müşteri silinmiştir!");
                Console.WriteLine();

                Console.WriteLine("------------------------------------------------------------");
            }
        }
        public void Guncelleme(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("------------------Müşteri Güncelleme Paneli-----------------");
                Console.WriteLine("Id: " + Musteri.Id);
                Console.WriteLine("Müşteri Adı: " + Musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + Musteri.Soyadi);
                Console.WriteLine("Telefon Numarası: " + Musteri.TelNo);
                Console.WriteLine("Tebrikler!Müşteri başarılı bir şekilde güncellenmiştir.");
                Console.WriteLine("------------------------------------------------------------");
            }
        }
    }
}
