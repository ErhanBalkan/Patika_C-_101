/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.
*/

void Odev1 (){
    int sayac = 0;
    System.Console.Write("Lütfen pozitif bir sayi giriniz: ");
    int girilenSayi = Convert.ToInt32(Console.ReadLine());
    if (girilenSayi <= 0)
        System.Console.WriteLine("Sayi pozitif olmali!");
    else 
        sayac = girilenSayi;
        int[] sayilar = new int[sayac];


    for (int i = 1; i < sayac; i++)
    {
        System.Console.Write($"Lütfen {i}. sayiyi giriniz: ");
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
    }

System.Console.WriteLine("Çift sayılar");
    foreach (int sayi in sayilar)
    {
        if (sayi % 2 == 0 && sayi != 0)
        {
            System.Console.WriteLine(sayi);
        }
    }
}

// ---------------------------------------------------------------------------------------

/*
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
*/

void Odev2(){
    int n = 0;
    int m = 0;
    int[] sayilar2; 
    System.Console.Write("1. sayiyi giriniz: ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());
    if (sayi1 <= 0){
        System.Console.WriteLine("Sayi pozitif olmali !");
        Environment.Exit(0); // Programı sonlandırır.
    }
    else 
        n = sayi1;
    System.Console.Write("2. sayiyi giriniz: ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());
    if (sayi2 <= 0){
        System.Console.WriteLine("Sayi pozitif olmali !");
        Environment.Exit(0); // Programı sonlandırır.
    }
    else 
        m = sayi2;

    sayilar2 = new int[n];
    for (int i = 0; i < n; i++)
    {
        System.Console.Write($"Lütfen {i+1}. sayiyi giriniz: ");
        int girilenSayi = Convert.ToInt32(Console.ReadLine()); 
        if (girilenSayi <= 0)
            System.Console.WriteLine("Sayi pozitif olmali !");
        else 
            sayilar2[i] = girilenSayi;
    }

    foreach (int sayi in sayilar2)
    {
        if (sayi == m || sayi % m == 0)
        {
            System.Console.WriteLine(sayi);
        }
    }
}

/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/

void Odev3(){
    System.Console.Write("Lütfen pozitif bir sayi giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] kelimeler = new string[n];
    for (int i = 0; i < n; i++)
    {
        System.Console.Write($"Lütfen {i+1}. kelimeyi giriniz: ");
        string girilenKelime = Console.ReadLine().ToString();
        kelimeler[i] = girilenKelime;
    }

    foreach (string kelime in kelimeler.Reverse())
    {
        System.Console.WriteLine(kelime);
    }
} 

/*
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/

void Odev4(){
    System.Console.Write("Lütfen bir cümle giriniz: ");
    string girilenCumle = Console.ReadLine().ToString();
    string[] cumledekiKelimeler = girilenCumle.Split(' ');
    char[] cumledekiHarfler = new char[girilenCumle.Length];
    for (int i = 0; i < girilenCumle.Length; i++)
    {
        cumledekiHarfler[i] = girilenCumle[i];
    }

    System.Console.WriteLine("Toplam kelime sayisi: " + cumledekiKelimeler.Length);
    System.Console.WriteLine("Toplam harf sayisi: " + cumledekiHarfler.Length);
}
