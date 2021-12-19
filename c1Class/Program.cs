// See https://aka.ms/new-console-template for more information


string adi = "selin";
int yas = 20;



Kurs kurs1 = new Kurs(); //class değişkeni //kendi veri tipini oluşturabilirsin.// class oldugu için birden fazla veri tipi içerebilir 
kurs1.kursAdi = "C#";
kurs1.egitmen = "Selin DEVECİ";
kurs1.izlenmeOrani = 88;

Kurs kurs2 = new Kurs(); 
kurs2.kursAdi = "Java";
kurs2.egitmen = "Engin DEVECİ";
kurs2.izlenmeOrani = 77;

Kurs kurs3 = new Kurs(); 
kurs3.kursAdi = "Python";
kurs3.egitmen = "Elif DEVECİ";
kurs3.izlenmeOrani = 68;

//Console.WriteLine(kurs1.kursAdi+ ":" +kurs1.egitmen);

//string[] kurslar = new string[] { } //boyle yazarsan ancak string tutabilirsin içinde.

Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

foreach (var kurs in kurslar)
{
    //Console.WriteLine(kurs.kursAdi);  //sadece kurs adı
   Console.WriteLine(kurs.kursAdi+ ":" +kurs.egitmen); //kurs adı ve eğitmenleri gosterir


}



class Kurs
{
    public string kursAdi { get; set; }
    public string egitmen { get; set; }
    public int izlenmeOrani { get; set; }

}