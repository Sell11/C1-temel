// See https://aka.ms/new-console-template for more information





urun urun1 = new urun();
urun1.urunAdi = "Kazak";
urun1.urunKodu = 2345342;
urun1.urunModel = "Bisiklet yaka";

urun urun2 = new urun();
urun2.urunAdi = "Etek";
urun2.urunKodu = 2678909;
urun2.urunModel = "Deri etek";

urun urun3 = new urun();
urun3.urunAdi = "Pantolon";
urun3.urunKodu = 67835423;
urun3.urunModel = "jean";


urun[] urunler = new urun[] { urun1, urun2, urun3 };

foreach (var urun in urunler)
{

    Console.WriteLine(urun.urunAdi + ":" + urun.urunKodu);


}

//*************************************************************************************************************************

for (int i = 0; i < urunler.Length; i++)
{
    Console.WriteLine(urunler[i].urunAdi + "  " + urunler[i].urunKodu + "  " + urunler[i].urunModel);
}

//*************************************************************************************************************************

int a = 0;
while (a < urunler.Length)
{
    Console.WriteLine(urunler[j].urunAdi + " : " + urunler[j].urunKodu);
    Console.WriteLine("Ürün Modeli: " + urunler[j].urunModel);
    
    a++;
}



class urun
{
 public string urunAdi { get; set; }   
 public int urunKodu { get; set; }   
 public string urunModel { get; set; }   
}
