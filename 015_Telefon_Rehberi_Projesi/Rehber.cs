public class Rehber
{
    List<Kisi> Kisiler = new List<Kisi>();

    public void AnaSayfa(){
        System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        System.Console.WriteLine("*******************************************");
        System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
        System.Console.WriteLine("(2) Varolan Numarayı Silmek");
        System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        System.Console.WriteLine("(4) Rehberi Listelemek");
        System.Console.WriteLine("(5) Rehberde Arama Yapmak");

        string cevap = System.Console.ReadLine();
        switch (cevap)
        {
            case "1": 
            YeniNumaraKaydet();
            break;

            case "2": 
            NumaraSil();
            break;

            case "3": 
            NumaraGuncelle();
            break;

            case "4": 
            RehberiListele();
            break;

            case "5": 
            RehberdeKisiAra();
            break;
        }
    }
    public void YeniNumaraKaydet(){
        System.Console.Write("Lütfen isim giriniz: ");
        string isim = System.Console.ReadLine();
        System.Console.Write("Lütfen soyisim giriniz: ");
        string soyisim = System.Console.ReadLine();
        System.Console.Write("Lütfen telefon numarası giriniz: ");
        string telefonNo = System.Console.ReadLine();
        Kisi kisi = new Kisi(isim, soyisim, telefonNo);
        Kisiler.Add(kisi);
        System.Console.WriteLine("Kişi eklendi.");
        AnaSayfa();
    }

    public void NumaraSil(){
        System.Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz: ");
        string silinecekKisi = System.Console.ReadLine();
        Kisiler.ForEach(k => {
            if (k.Ad.ToLower() + " " + k.Soyad.ToLower() == silinecekKisi.ToLower())
            {
                System.Console.Write($"{k.Ad} {k.Soyad} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() == "y")
                {
                    Kisiler.Remove(k);
                    System.Console.WriteLine("Kişi silindi.");
                    AnaSayfa();
                }else if (cevap.ToLower() == "n"){
                    System.Console.WriteLine("İşlem iptal edildi.");
                    AnaSayfa();
                }else{
                    System.Console.WriteLine("Yanlış karakter girildi.");
                    NumaraSil();
                }
            }else{
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("Yeniden denemek için        : (2)");
                string cevap = Console.ReadLine();
                if (cevap == "1")
                {
                    System.Console.WriteLine("İşlem sonlandırıldı.");
                    AnaSayfa();
                }else if (cevap == "2"){
                    NumaraSil();
                }
            }

            AnaSayfa();
        });
    }

    public void NumaraGuncelle(){
        System.Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz: ");
        string guncellenecekKisi = Console.ReadLine();
        Kisiler.ForEach(k => {
            if (k.Ad.ToLower() + " " + k.Soyad.ToLower() == guncellenecekKisi.ToLower())
            {
                System.Console.Write("Yeni numara giriniz: ");
                string yeniNo = System.Console.ReadLine();
                Kisi kisi = new Kisi(k.Ad, k.Soyad, yeniNo);
                Kisiler.Remove(k);
                Kisiler.Add(kisi);
            }else{
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                System.Console.WriteLine("* Yeniden denemek için              : (2)");
                string cevap = System.Console.ReadLine();
                if (cevap == "1")
                {
                    AnaSayfa();
                }else if(cevap == "2"){
                    NumaraGuncelle();
                }else{
                    System.Console.WriteLine("Yanlış karakter.");
                    NumaraGuncelle();
                }
            }
            AnaSayfa();
        });
    }

    public void RehberiListele(){
        System.Console.WriteLine("Telefon Rehberi");
        System.Console.WriteLine("**********************************************");
        Kisiler.ForEach(k => {
            System.Console.WriteLine($"İsim: {k.Ad}");
            System.Console.WriteLine($"Soyisim: {k.Soyad}");
            System.Console.WriteLine($"Numara: {k.TelefonNo}");
            System.Console.WriteLine();
            System.Console.WriteLine("-");
        });
        AnaSayfa();
    }

    public void RehberdeKisiAra(){
        System.Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        System.Console.WriteLine("**********************************************");
        System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        string cevap = System.Console.ReadLine();

        if (cevap == "1"){
            IsmeGoreAramaYap();
        }else if(cevap == "2"){
            NumarayaGoreAramaYap();
        }
        AnaSayfa();

}

    public void IsmeGoreAramaYap(){
        System.Console.Write("İsim giriniz: ");
        string isim = System.Console.ReadLine();
        Kisiler.ForEach(k => {
            if (k.Ad.ToLower().Contains(isim.ToLower()))
            {
                System.Console.WriteLine($"İsim: {k.Ad}");
                System.Console.WriteLine($"Soyisim: {k.Soyad}");
                System.Console.WriteLine($"Numara: {k.TelefonNo}");
            }else{
                System.Console.WriteLine("Arama sonucuna uygun kişi bulunamadı.");
                AnaSayfa();
            }
            AnaSayfa();
        });
}

    public void NumarayaGoreAramaYap(){
        System.Console.Write("Numara giriniz: ");
        string no = System.Console.ReadLine();
        Kisiler.ForEach(k => {
            if (k.TelefonNo.Contains(no))
            {
                System.Console.WriteLine($"İsim: {k.Ad}");
                System.Console.WriteLine($"Soyisim: {k.Soyad}");
                System.Console.WriteLine($"Numara: {k.TelefonNo}");
            }else{
                System.Console.WriteLine("Arama sonucuna uygun kişi bulunamadı.");
                AnaSayfa();
            }
            AnaSayfa();
        });
}


}