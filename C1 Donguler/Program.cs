// See https://aka.ms/new-console-template for more information



string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
string kurs3 = "Java";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);   
Console.WriteLine(kurs3);


//boyle olmaz dizilerde tanımlamak gerekir.//array 

string[] kurslar= new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs","Java" , "python"};

for (int i = 0; i < kurslar.Length; i++) //kurslar.Length: kursların eleman sayısı kadar.= 4 demek yerine //for genel amaçlar için kullanılır
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for bitti");


//farklı for yontemi asagıda

foreach (string kurs in kurslar) //foreach dizi temelli yapıların tek tek dolaşmasını saglar.//kursları dolaş //foreach dizilere uygulanır.
{
    Console.WriteLine(kurs);
}




Console.WriteLine("Sayfa Sonu-footer");


//for (int i = 1; i < 10; i++) //1 den başla 10 dan küçük oldugu sürece çalış ve bir bir arttır.// i=i+2, i+=2 veya i=i+1 iki iki arttır demek//
//{
//    Console.WriteLine(i);
//}
