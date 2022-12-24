class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri(){
        System.Console.WriteLine($"Çalışanın Adı: {Ad}");
        System.Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
        System.Console.WriteLine($"Çalışanın Numarası: {No}");
        System.Console.WriteLine($"Çalışanın Departmanı: {Departman}");
    }
}