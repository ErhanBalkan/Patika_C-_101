class Calisan
{
    private static int calisanSayisi;
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string Soyad, int No, string Departman)
    {
        this.Ad = ad;
        this.Soyad = Soyad;
        this.No = No;
        this.Departman = Departman;
        calisanSayisi++;
    }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        calisanSayisi++;
    }
    // static constructor ilk çalışır ve sadece 1 kez çalışır.
    static Calisan(){
        calisanSayisi = 0;
    }
    public Calisan(){
        calisanSayisi++;
    }
    public void CalisanBilgileri(){
        System.Console.WriteLine($"Çalışanın Adı: {Ad}");
        System.Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
        System.Console.WriteLine($"Çalışanın Numarası: {No}");
        System.Console.WriteLine($"Çalışanın Departmanı: {Departman}");
    }

    public static void CalisanSayisiniGetir(){
        System.Console.WriteLine($"Çalışan Sayısı: {calisanSayisi}");
    }
}