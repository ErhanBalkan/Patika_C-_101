using System;
// Dizi tanımlama
string[] renkler = new string[5];
string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"}; 
int[] dizi;
dizi = new int[5];

// Dizilere değer atama ve erişim
renkler[0] = "Mavi";
dizi[3] = 10;
Console.WriteLine(hayvanlar[0]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngüler ile dizi kullanımı
// Konsoldan girilen n tane sayının ortalamasını hesaplayan program;
Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];
for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write($"Lütfen {i+1}. sayıyı giriniz: ");
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayiDizisi)
    toplam += sayi;

Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Array sınıfı methodları
int[] sayilar = {23,12,4,86,72,3,11,17};
Console.WriteLine("*** Sırasız dizi ***");
foreach (var sayi in sayilar)
    System.Console.WriteLine(sayi);
// ----------------------------------------------------------------
System.Console.WriteLine("*** Sıralı Dizi ***");
Array.Sort(sayilar);
foreach (var sayi in sayilar)
    System.Console.WriteLine(sayi);
// ----------------------------------------------------------------
System.Console.WriteLine("*** Clear ***");
Array.Clear(sayilar,2,2);
// sayilar dizisinde 2. indexten itibaren 2 elemanı SIFIRLAR.
foreach (var sayi in sayilar)
    System.Console.WriteLine(sayi);
// ----------------------------------------------------------------
System.Console.WriteLine("*** Reverse ***");
Array.Reverse(sayilar);
foreach (var sayi in sayilar)
    System.Console.WriteLine(sayi);
// ----------------------------------------------------------------
System.Console.WriteLine("*** IndexOf ***");
System.Console.WriteLine(Array.IndexOf(sayilar,23));
// ----------------------------------------------------------------
System.Console.WriteLine("*** Resize ***");
Array.Resize<int>(ref sayilar, 9);
sayilar[8] = 99;
foreach (var sayi in sayilar)
    System.Console.WriteLine(sayi);