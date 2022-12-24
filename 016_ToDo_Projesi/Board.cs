public class Board
{
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public int Buyukluk { get; set; }
    public Kisi Kisi { get; set; }
    public bool Durum { get; set; }

    public Board(string baslik, string icerik, int buyukluk, Kisi kisi, bool durum)
    {
        this.Baslik = baslik;
        this.Icerik = icerik;
        this.Buyukluk = buyukluk;
        this.Kisi = kisi;
        this.Durum = durum;
    }
    public Board()
    {
        
    }
}