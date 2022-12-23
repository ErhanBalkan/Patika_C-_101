using System.Collections.Generic;

List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

// Count => eleman sayısı
System.Console.WriteLine(sayiListesi.Count);
System.Console.WriteLine(renkListesi.Count);

foreach (int sayi in sayiListesi)
{
    System.Console.WriteLine(sayi);
}

renkListesi.ForEach(sayi => System.Console.WriteLine(sayi));

// Remove - RemoveAt(indexteki elemanı siler)
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");

// Contains => sayı varmı kontrol eder varsa true yoksa false
sayiListesi.Contains(2);

// Eleman ile indexe erişmek
renkListesi.BinarySearch("Sarı");

