public class Kisi
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public Kisi(int id, string ad, string Soyad)
    {
        this.Id = id;
        this.Ad = ad;
        this.Soyad = Soyad;
    }
}