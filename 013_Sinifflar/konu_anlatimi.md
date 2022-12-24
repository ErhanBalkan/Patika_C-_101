# Sinif Sözdizimi, Field ve Metot Tanımlama, Erişim Belirleyiciler
---
## Sınıf Nedir, Neden İhtiyaç Duyarız ?
Sınıflar Nesne Yönelimli Programlamanın en öneeli öğesidir. C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.

Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine, parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır demiştik. Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.

Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.

Bir sınıfın temelde 2 tipte öğesi vardır; field/özellik ve metotlar. Aşağıda örnek bir sınıf tanımının söz dizimini görebilirsiniz.

```
class SinifAdi
{
    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
    [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
    {
        //Metot Gövdesi
    }
}
```
## Erişim Belirleyiciler
Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.

```
1. Public : Her yerden erişilebilir.

2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
```

---
---
--- 
---
---

# Constructor Kavramı
Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan `yapıcı metotlara kurucu` yada `constructor` denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:

```
1. Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
2. Public olarak bildirilmeleri gerekir.
3. Geri dönüş değerleri yoktur.
```

Kurucu metotların imzasını değiştirerek `overload` edebiliriz yani aşırı yükleyebiliriz. Metotları anlatırken aşırı yüklemeden bahsetmiştik. 

## Varsayılan Kurucu Metot
Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna `varsayılan kurucu metot (default constructor)` denir.

Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda `null` olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.