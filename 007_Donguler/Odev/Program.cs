using System;
Console.WriteLine("--------------- For Döngüsü ---------------");
// Ekrandan girilen sayıya kadar olan tek sayıları konsola yazdır.
Console.Write("Lütfen bir sayı giriniz: ");
int sayac = int.Parse(Console.ReadLine());
for (int i = 0; i <= sayac; i++)
// i değişkeni sayaç değişkeninden küçük veya eşit olduğu sürece i değişkenini 1 arttır.
{
    if(i % 2 == 1){
        // i değişkeninin 2'ye bölümünden kalan 1 ise yazdır.
        Console.WriteLine(i);
    }
}
// 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını bul.
int tekToplam = 0;
int ciftToplam = 0;
for (int i = 0; i <= 1000; i++)
{
    if (i % 2 == 1)
        tekToplam += i; // tekToplam = tekToplam + i;
    if (i % 2 == 0)
        ciftToplam += i; // ciftToplam = ciftToplam + i;
}
Console.WriteLine("Tek toplam: " + tekToplam);
Console.WriteLine("Çift toplam: " + ciftToplam);
// ---------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
Console.WriteLine("--------------- Break ve Continue ---------------");
for (int i = 1; i < 10; i++)
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}

for (int i = 1; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}
// ---------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
Console.WriteLine("--------------- While ---------------");
// 1'den başlayarak konsoldan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp yazdır.
Console.Write("Lütfen bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac2 = 1;
int toplam = 0;
while (sayac2 <= sayi)
{
    toplam += sayac;
    sayac2++;
}
Console.WriteLine("Ortalama: " + toplam / sayi);

// a'dan z'ye kadar tüm harfleri yazdır.
char character = 'a';
while (character <= 'z')
{
    Console.Write(character);
    character++;
}
Console.WriteLine();
// ---------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
Console.WriteLine("--------------- ForEach ---------------");
string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
foreach (string araba in arabalar)
{
    Console.WriteLine(araba);
}