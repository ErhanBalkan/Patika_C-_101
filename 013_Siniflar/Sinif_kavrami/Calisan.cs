class Calisan
{
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
    }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public Calisan(){}
    public void CalisanBilgileri(){
        System.Console.WriteLine($"Çalışanın Adı: {Ad}");
        System.Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
        System.Console.WriteLine($"Çalışanın Numarası: {No}");
        System.Console.WriteLine($"Çalışanın Departmanı: {Departman}");
    }
}