string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
string degisken2 = "Dersimiz CSharp";
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Length => Karakter sayısı
System.Console.WriteLine(degisken.Length);
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ToUpper - ToLower => Büyük - küçük harflere çevirme
System.Console.WriteLine(degisken.ToUpper());
System.Console.WriteLine(degisken.ToLower());
// ----------------------------------------------------------------
// Concat => String birleştirme
System.Console.WriteLine(String.Concat(degisken," Merhaba!"));
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Compare - CompareTo
System.Console.WriteLine(degisken.CompareTo(degisken2));
/*
Birinci değişken ile ikinci değişken eşitse '0' döndürür.
Birinci değişken ikinci değişkenden karakter olarak uzunsa '1' döndürür.
İkinci değişken birinci değişkenden karakter olarak daha uzunsa '-1' döndürür.
*/
System.Console.WriteLine(String.Compare(degisken,degisken2,true));
/* 
3. parametre ignore case'dir. true olursa büyük-küçük harf
duyarlılığı olmaz, false olursa büyük küçük harfe duyarlı olur.
*/
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Contains
System.Console.WriteLine(degisken.Contains(degisken2));
// birinci değişkenin içinde 2. değişken geçiyorsa, varsa true döner. yoksa false döner.
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Endswith - startswith
System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
System.Console.WriteLine(degisken.StartsWith("Merhaba!"));
/*
EndsWith => degisken verilen string ile bitiyorsa true döner.
StartsWith => değişken verilen string ile başlıyorsa true döner. 
*/
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// IndexOf - LastIndexOf
System.Console.WriteLine(degisken.IndexOf("CS"));
/*
verilen parametrenin kaçıncı indexte olduğunu döner.
Bulamazsa -1 döner.
*/
System.Console.WriteLine(degisken.LastIndexOf("i"));
// IndexOf ile aynı tek farkı aramaya sondan başlaması.
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Insert
System.Console.WriteLine(degisken.Insert(0,"Merhaba! "));
/*
0. indexten sonra verilen parametreyi ekler.
*/
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
/*
PadLeft ve PadRight
degisken2'nin sonuna 30 karakter olacak kadar boşluk ekler karakter
sayısı 30'dan fazlaysa bişey yapmaz.
*/
System.Console.WriteLine(degisken + degisken2.PadLeft(30));
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
/*
Remove
10. karakterden sonrasını siler.
*/
System.Console.WriteLine(degisken.Remove(10));
System.Console.WriteLine(degisken.Remove(5,3)); // 5. karakterden başla 3 karakter sil
System.Console.WriteLine(degisken.Remove(0,1)); // en baştaki elemanı siler
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Replace
System.Console.WriteLine(degisken.Replace("CSharp","C#"));
System.Console.WriteLine(degisken.Replace(" ","*"));
// ilk parametreyi bulur ikinci parametreyle değiştirir.
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Split
System.Console.WriteLine(degisken.Split(" ")[1]);
/*
boşluklardan bölüp liste haline getirecek ve biz burda
1. indexteki elemanı aldık.
parametrede başka bir karakter verilseydi onlardan bölerdi.
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
*/
// SubString
System.Console.WriteLine(degisken.Substring(4));
// 4. indexten başlayarak cümlenin sonuna kadar getirir.
System.Console.WriteLine(degisken.Substring(4,6));
// 4. indexten başlayarak 6 karakter getirir.




