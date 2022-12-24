Calisan calisan1 = new Calisan();
calisan1.Ad = "Erhan";
calisan1.Soyad = "Balkan";
calisan1.No = 24506;
calisan1.Departman = "İskelet Robot Operatörü";

calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan{
    Ad = "Atakan",
    Soyad = "Aydın",
    No = 24500,
    Departman = "İskelet Robot Operatörü"
};

calisan2.CalisanBilgileri();

Calisan calisan3 = new Calisan{
    Ad = "Adnan",
    Soyad = "Namlucuoğlu",
};

calisan3.CalisanBilgileri();

Calisan.CalisanSayisiniGetir();

// ----------------------------------------------------------------
System.Console.WriteLine("-----------------------------------------");

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Ad = "Ali";
ogrenci1.Soyad = "Veli";
ogrenci1.No = 555;
ogrenci1.SinifNo = 3;

ogrenci1.OgrenciBilgileriniGetir();

ogrenci1.SinifAtlat();

ogrenci1.OgrenciBilgileriniGetir();

// ----------------------------------------------------------------
System.Console.WriteLine("-----------------------------------------");

Dikdortgen dikdortgen1 = new Dikdortgen();
dikdortgen1.KisaKenar = 3;
dikdortgen1.UzunKenar = 4;

System.Console.WriteLine($"Class alan hesabı: {dikdortgen1.AlanHesapla()}");

Dikdortgen_struct dikdortgen_Struct1;
dikdortgen_Struct1.KisaKenar = 3;
dikdortgen_Struct1.UzunKenar = 4;

System.Console.WriteLine($"Struct alan hesabı: {dikdortgen_Struct1.AlanHesapla()}");
