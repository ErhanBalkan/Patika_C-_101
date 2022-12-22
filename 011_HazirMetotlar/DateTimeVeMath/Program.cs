using System;
// Günün tarihi
System.Console.WriteLine(DateTime.Now); 
System.Console.WriteLine(DateTime.Now.Date);
System.Console.WriteLine(DateTime.Now.Day); 
System.Console.WriteLine(DateTime.Now.Month); 
System.Console.WriteLine(DateTime.Now.Year);
System.Console.WriteLine(DateTime.Now.Hour);
System.Console.WriteLine(DateTime.Now.Minute);
System.Console.WriteLine(DateTime.Now.Second);

// Haftanın gününü string olarak getirir
System.Console.WriteLine(DateTime.Now.DayOfWeek);
// Yılın kaçıncı gününde olduğumuzu döner
System.Console.WriteLine(DateTime.Now.DayOfYear); 
// Saturday, April 24, 2021
System.Console.WriteLine(DateTime.Now.ToLongDateString());
// 4/24/2021
System.Console.WriteLine(DateTime.Now.ToShortDateString());

System.Console.WriteLine(DateTime.Now.AddDays(2));
System.Console.WriteLine(DateTime.Now.AddHours(2));
System.Console.WriteLine(DateTime.Now.AddSeconds(20));
System.Console.WriteLine(DateTime.Now.AddMonths(1));
System.Console.WriteLine(DateTime.Now.AddYears(10));
System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

// Datetime Format
System.Console.WriteLine(DateTime.Now.ToString("dd")); // 24
System.Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
System.Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

System.Console.WriteLine(DateTime.Now.ToString("MM")); // 04
System.Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
System.Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

System.Console.WriteLine(DateTime.Now.ToString("yy")); // 21
System.Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// ----------------------------------------------------------------
// Math
// -------------
// Mutlak değer
System.Console.WriteLine(Math.Abs(-25));
// Sinüs - cosinüs - tanjant alma
System.Console.WriteLine(Math.Sin(10));
System.Console.WriteLine(Math.Cos(10));
System.Console.WriteLine(Math.Tan(10));
// Yuvarlama
System.Console.WriteLine(Math.Ceiling(22.3)); // Bir üst tamsayıya yuvarlar > 23
System.Console.WriteLine(Math.Round(22.3)); // Nereye yakınsa oraya yuvarlar > 22
System.Console.WriteLine(Math.Floor(22.7)); // Bir alt tamsayıya yuvarlar > 22
// minimum-maximum
System.Console.WriteLine(Math.Min(2,5));
System.Console.WriteLine(Math.Max(2,5));
// üs alma
System.Console.WriteLine(Math.Pow(3,4)); // 3 üzeri 4
// karekök
System.Console.WriteLine(Math.Sqrt(9));
// Logaritmasını alma
System.Console.WriteLine(Math.Log(9));



