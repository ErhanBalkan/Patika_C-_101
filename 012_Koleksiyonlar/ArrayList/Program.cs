using System.Collections;
using System.Collections.Generic;

ArrayList liste = new ArrayList();
liste.Add("Erhan");
liste.Add(2);
liste.Add(true);
liste.Add('A');

System.Console.WriteLine(liste[1]);
foreach (var item in liste)
{
    System.Console.WriteLine(item);
}

// Add range
string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

liste.AddRange(renkler);
liste.AddRange(sayilar);

// listeye liste ekledik

