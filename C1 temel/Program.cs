// See https://aka.ms/new-console-template for more information


    //type safety-tip güvenliği (c# ve javada veri tipi yazılmak zorunda.)
    //do not repeat yourself- kendini tekrarlama(değişken kullan)
    //kategoriEtiketi(deger tutucu/alias)

string kategoriEtiketi = "kategoriler";
int ogrenciSayisi = 32000; //tamsayı
double faizOrani = 1.45;//ondalıklı sayı //float
bool sistemeGirisYapmisMi = true; //evet - hayır /boolean dan gelir.
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if(dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi Butonu");
}




if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{ 
    Console.WriteLine("Sisteme Giriş Yap Butonu");
}

Console.WriteLine(kategoriEtiketi);




