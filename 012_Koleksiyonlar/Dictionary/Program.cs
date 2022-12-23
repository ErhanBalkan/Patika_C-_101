using System.Collections.Generic;

Dictionary<int,string> kullanicilar = new Dictionary<int,string>();

kullanicilar.Add(10,"Erhan Balkan");
kullanicilar.Add(12,"Adnan Namlucuoğlu");
kullanicilar.Add(18,"Atakan Aydın");

// Elemenlara erişim
Console.WriteLine(kullanicilar[12]); // 12 key'ine sahip eleman
foreach (var item in kullanicilar)
{
    System.Console.WriteLine(item);
}

// Count
System.Console.WriteLine(kullanicilar.Count);

// Contains
System.Console.WriteLine(kullanicilar.ContainsKey(12));
System.Console.WriteLine(kullanicilar.ContainsValue("Ali Veli"));


