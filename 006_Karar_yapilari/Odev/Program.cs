using System;
int time = DateTime.Now.Hour;

if(time >= 6 && time < 11){
    Console.WriteLine("Günaydın!");
}
else if (time <= 18)
{
    Console.WriteLine("İyi günler!");
}else{
    Console.WriteLine("İyi geceler!");
}
// -----------------------------
// Ternary if
string sonuc = time <= 18 ? "İyi günler!" : "İyi geceler!";
sonuc = time >= 6 && time <= 11 ? "Günaydın!" : time <= 18 ? "İyi günler!" : "İyi geceler!"; 
Console.WriteLine(sonuc);
// -----------------------------
// Switch Case
int month = DateTime.Now.Month;
switch (month)
{
    case 1:
    Console.WriteLine("Ocak ayındasınız.");
    break;

    case 2:
    Console.WriteLine("Şubat ayındasınız.");
    break;
    
    case 3:
    Console.WriteLine("Mart ayındasınız.");
    break;
    
    default:
    Console.WriteLine("Yanlış veri girdiniz.");
    break;
}


switch (month)
{
    case 12:
    case 1:
    case 2:
    Console.WriteLine("Kış ayındasınız.");
    break;
    case 3:
    case 4:
    case 5:
    Console.WriteLine("İlkbahar ayındasınız.");
    break;
    case 6:
    case 7:
    case 8:
    Console.WriteLine("Yaz ayındasınız.");
    break;
    case 9:
    case 10:
    case 11:
    Console.WriteLine("Sonbahar ayındasınız.");
    break;
}