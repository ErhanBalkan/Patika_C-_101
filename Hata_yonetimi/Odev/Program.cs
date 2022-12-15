using System;


try{
    Console.Write("Bir sayi giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girdiğiniz sayi: " + sayi);
}
catch (Exception ex) {
    Console.WriteLine("Hata: " + ex.Message);
}
finally{
    Console.WriteLine("İşlem tamamlandi.");
}

try{
    int a = int.Parse(null);
}
catch (ArgumentNullException ex){
    Console.WriteLine("Hata: " + ex.Message);
    Console.WriteLine("Hata TR: Boş değer girdiniz!");
}


try{
    int b = int.Parse("test");
}
catch (FormatException ex){
    Console.WriteLine("Hata: " + ex.Message);
    Console.WriteLine("Hata TR: Yanlis veri tipi");
}


try{
    int c = int.Parse("20000000000");
}
catch (OverflowException ex){
    Console.WriteLine("Hata: " + ex.Message);
    Console.WriteLine("Hata TR: Değer disina cikildi.");
}