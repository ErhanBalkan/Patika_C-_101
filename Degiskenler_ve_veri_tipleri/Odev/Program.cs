// ----------------------------------------------------------------
byte b = 5;                  // 0-255 - 1 byte
sbyte sb = 5;                // -128-127 - 1 byte
// ----------------------------------------------------------------
short s = 5;                 // -32768-32767 - 2 byte 
ushort us = 5;               // 0-65535 - 2 byte
// ----------------------------------------------------------------
Int16 i16 = 2;               // 2 byte
int i = 2;                   // 4 byte
Int32 i32 = 2;               // 4 byte
Int64 i64 = 2;               // 8 byte
uint ui = 2;                 // 4 byte
// ----------------------------------------------------------------
long l = 4;                  // 8 byte
// ----------------------------------------------------------------
// Reel sayılar
float f = 5;                 // 4 byte
double d = 5;                // 8 byte
decimal dc = 5;              // 16 byte
// ----------------------------------------------------------------
char c = 'A';                // 2 byte
string str = "abc";          // sınırsız
// ----------------------------------------------------------------
bool b1 = true;
bool b2 = false;
// ----------------------------------------------------------------
DateTime dt = DateTime.Now;
Console.WriteLine(dt);
// ----------------------------------------------------------------
// Tüm değişken türleri aslında bir object'tir.
object o1 = "x";
object o2 = 'A';
object o3 = 1;
object o4 = 4.3;
// ----------------------------------------------------------------
// String ifadeler
string str1 = String.Empty; // string için boş değer ifade eder.
str1 = "Erhan";
string ad = "Erhan";
string soyad = "Balkan";
string tamisim = ad + " " + soyad;
// ----------------------------------------------------------------
// Integer ifadeler
int integer1 = 3;
int integer2 = 5;
int integer3 = integer1 + integer2;
// ----------------------------------------------------------------
// Boolean ifadeler
bool bool1 = 18 < 2; // false döner
// ----------------------------------------------------------------
// Değişken Dönüşümleri
string string1 = "20";
int int1 = 20;
string yeniDeger = string1 + int1.ToString(); // int1'i string'e dönüştürür. çıktısı : 2020

int int2 = int1 + Convert.ToInt32(string1); // çıktısı : 40

int int12 = int1 + int.Parse(string1); // çıktısı : 40
// ----------------------------------------------------------------
// Datetime
string datetime = DateTime.Now.ToString("dd.MM.yyyy");   // çıktısı : 13.12.2022
string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");  // çıktısı : 13/12/2022
string hour = DateTime.Now.ToString("HH:mm");            // çıktısı : 13:11


