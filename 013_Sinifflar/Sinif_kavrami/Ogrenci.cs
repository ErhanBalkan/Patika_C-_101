class Ogrenci
{
    private string ad;
    private string soyad;
    private int no;
    private int sinifNo;

    public string Ad { 
        get{return ad;} 
        set{ad = value;}
        }
    
    public string Soyad { 
        get{return soyad;}  
        set{ soyad = value;}
        }

    public int No { 
        get{return no;} 
        set{ no = value;}
        }

        public int SinifNo { 
        get{return sinifNo;} 
        set{
            if (value < 1)
            {
                System.Console.WriteLine("Sınıf en az 1 olabilir.");
                sinifNo = 1;
            }
            sinifNo = value;
        }
        }

        public Ogrenci(string ad, string soyad, int no, int sinifNo)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.SinifNo = sinifNo;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir(){
            System.Console.WriteLine("***** Öğrenci Bilgileri *****");
            System.Console.WriteLine($"Öğrenci Ad: {Ad}");
            System.Console.WriteLine($"Öğrenci Soyad: {Soyad}");
            System.Console.WriteLine($"Öğrenci No: {No}");
            System.Console.WriteLine($"Öğrenci Sınıf No: {SinifNo}");
        }

        public void SinifAtlat(){
            this.SinifNo += 1;
        }
        public void SinifDusur(){
            this.SinifNo -= 1;
        }
}