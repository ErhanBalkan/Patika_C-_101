public class Kisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string TelefonNo { get; set; }

    public Kisi(string ad, string Soyad, string TelefonNo)
    {
        this.Ad = ad;
        this.Soyad = Soyad;
        this.TelefonNo = TelefonNo;
    }
}