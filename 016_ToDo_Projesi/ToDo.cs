public class ToDo
{
    List<Board> DevamEdenler = new List<Board>();
    List<Board> Tamamlananlar = new List<Board>();
    List<Kisi> Kisiler = new List<Kisi>();

    Kisi kisi1 = new Kisi(1,"Erhan","Balkan");
    Kisi kisi2 = new Kisi(2,"Büşra","Balkan");

    public ToDo()
    {
        Kisiler.Add(kisi1);
        Kisiler.Add(kisi2);
    }
    public void Anasayfa(){
    System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
    System.Console.WriteLine("*******************************************");
    System.Console.WriteLine("(1) Board Listelemek");
    System.Console.WriteLine("(2) Board'a Kart Eklemek");
    System.Console.WriteLine("(3) Board'dan Kart Silmek");
    System.Console.WriteLine("(4) Kart Taşımak");

    string cevap = System.Console.ReadLine();

    switch (cevap)
    {
        case "1": 
        BoardListele();
        break;

        case "2": 
        KartEkle();
        break;

        case "3": 
        KartSil();
        break;

        case "4": 
        KartTasi();
        break;
    }
    
}

public void BoardListele(){
    System.Console.WriteLine("IN PROGRESS Line");
    System.Console.WriteLine("************************");
    if (DevamEdenler.Count == 0)
    {
        System.Console.WriteLine("~ BOŞ ~");
    }
    DevamEdenler.ForEach(dv => {
        System.Console.WriteLine($"Başlık: {dv.Baslik}");
        System.Console.WriteLine($"İçerik: {dv.Icerik}");
        System.Console.WriteLine($"Atanan Kişi: {dv.Kisi.Ad} {dv.Kisi.Soyad}");
        System.Console.WriteLine($"Büyüklük: {dv.Buyukluk}");
        System.Console.WriteLine($"Durum: {dv.Durum}");
        System.Console.WriteLine();
        System.Console.WriteLine("-");
    });
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine();

    System.Console.WriteLine("DONE Line");
    System.Console.WriteLine("************************");
    if (Tamamlananlar.Count == 0)
    {
        System.Console.WriteLine("~ BOŞ ~");
    }
    Tamamlananlar.ForEach(tm => {
        System.Console.WriteLine($"Başlık: {tm.Baslik}");
        System.Console.WriteLine($"İçerik: {tm.Icerik}");
        System.Console.WriteLine($"Atanan Kişi: {tm.Kisi.Ad} {tm.Kisi.Soyad}");
        System.Console.WriteLine($"Büyüklük: {tm.Buyukluk}");
        System.Console.WriteLine();
        System.Console.WriteLine("-");
    });
    Anasayfa();
}


public void KartEkle(){
    System.Console.Write("Başlık giriniz: ");
    string baslik = System.Console.ReadLine();
    System.Console.Write("İçerik giriniz: ");
    string icerik = System.Console.ReadLine();
    System.Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):  ");
    int buyukluk = int.Parse(System.Console.ReadLine());
    Kisiler.ForEach(k => System.Console.WriteLine($"{k.Id-1} - {k.Ad} {k.Soyad}"));
    System.Console.Write("Kişi seçiniz: ");
    int kisiId = int.Parse(System.Console.ReadLine());

    Board board = new Board(baslik, icerik, buyukluk, Kisiler[kisiId],false);
    DevamEdenler.Add(board);
    System.Console.WriteLine("Kart eklendi.");
    Anasayfa();
}

public void KartSil(){
    System.Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
    System.Console.Write("Lütfen kart başlığını yazınız: ");
    string baslik = System.Console.ReadLine();
    DevamEdenler.ForEach(dv => {
        if (dv.Baslik.ToLower() == baslik.ToLower())
        {
            DevamEdenler.Remove(dv);
            System.Console.WriteLine("Kart silindi.");
            Anasayfa();
        }else{
            System.Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            System.Console.WriteLine("* İşlemi sonlandırmak için : (1)");
            System.Console.WriteLine("* Yeniden denemek için : (2)");
            string cevap = System.Console.ReadLine();
            if (cevap == "1")
            {
                Anasayfa();
            }else if(cevap == "2"){
                KartSil();
            }else{
                System.Console.WriteLine("Hatalı tuşlama.");
                Anasayfa();
            }
        }
    });
}

public void KartTasi(){
    System.Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
    System.Console.Write("Lütfen kart başlığını yazınız: ");
    string baslik = Console.ReadLine();
    DevamEdenler.ForEach(dv=>{
        if (baslik.ToLower() == dv.Baslik.ToLower())
        {
            System.Console.WriteLine("Bulunan kart bilgileri");
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"Başlık: {dv.Baslik}");
            System.Console.WriteLine($"İçerik: {dv.Icerik}");
            System.Console.WriteLine($"Atanan kişi: {dv.Kisi.Ad} {dv.Kisi.Soyad}");
            switch (dv.Buyukluk)
            {
                case 1:
                System.Console.WriteLine($"Büyüklük: XS");
                break;

                case 2:
                System.Console.WriteLine($"Büyüklük: S");
                break;

                case 3:
                System.Console.WriteLine($"Büyüklük: M");
                break;

                case 4:
                System.Console.WriteLine($"Büyüklük: L");
                break;

                case 5:
                System.Console.WriteLine($"Büyüklük: XL");
                break;
            }

            System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
            System.Console.WriteLine("(1) IN PROGRESS");
            System.Console.WriteLine("(2) DONE");
            string cevap = System.Console.ReadLine();
            if (cevap == "1")
            {
                System.Console.WriteLine("Kart zaten IN PROGRESS alanında.");
                Anasayfa();
            }else if (cevap == "2"){
                dv.Durum = true;
                ListeyeAktar(dv);
                Anasayfa();
            }
            }

    });


        Tamamlananlar.ForEach(tm=>{
        if (baslik.ToLower() == tm.Baslik.ToLower())
        {
            System.Console.WriteLine("Bulunan kart bilgileri");
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine($"Başlık: {tm.Baslik}");
            System.Console.WriteLine($"İçerik: {tm.Icerik}");
            System.Console.WriteLine($"Atanan kişi: {tm.Kisi.Ad} {tm.Kisi.Soyad}");
            switch (tm.Buyukluk)
            {
                case 1:
                System.Console.WriteLine($"Büyüklük: XS");
                break;

                case 2:
                System.Console.WriteLine($"Büyüklük: S");
                break;

                case 3:
                System.Console.WriteLine($"Büyüklük: M");
                break;

                case 4:
                System.Console.WriteLine($"Büyüklük: L");
                break;

                case 5:
                System.Console.WriteLine($"Büyüklük: XL");
                break;
            }

            System.Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
            System.Console.WriteLine("(1) IN PROGRESS");
            System.Console.WriteLine("(2) DONE");
            string cevap = System.Console.ReadLine();
            if(cevap == "2"){
                System.Console.WriteLine("Kart zaten DONE alanında.");
                Anasayfa();
            }else if(cevap == "1"){
                tm.Durum = false;
                ListeyeAktar(tm);
                Anasayfa();
            }

            }
    });
}

public void ListeyeAktar(Board kart){
    if (kart.Durum == true)
    {
        Tamamlananlar.Add(kart);
        DevamEdenler.ForEach(d =>{
            if (d.Baslik == kart.Baslik){
                DevamEdenler.Remove(d);
            }
        });
        
    }else if(kart.Durum == false){
        DevamEdenler.Add(kart);
        Tamamlananlar.ForEach(t => {
            if (t.Baslik == kart.Baslik)
            {
                Tamamlananlar.Remove(t);
            }
        });
    }
}
enum Buyuklukler{
    XS=1, S=2, M=3, L=4, XL=5
}    




}