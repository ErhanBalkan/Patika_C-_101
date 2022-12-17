int Topla(int sayi1, int sayi2){
    return sayi1 + sayi2;
}

int result = Topla(3,3);
System.Console.WriteLine(result);

Metotlar ornek = new Metotlar();
ornek.EkranaYazdir("Merhaba");
ornek.EkranaYazdir((3+5).ToString());
int a = ornek.ArttırVeTopla(2,2);
System.Console.WriteLine(a);
class Metotlar
{
    public void EkranaYazdir(string data){
        System.Console.WriteLine(data);
    }
    public int ArttırVeTopla(int sayi1, int sayi2){
        sayi1 += 1;
        sayi2 += 1;
        return sayi1 + sayi2;
    }
}
