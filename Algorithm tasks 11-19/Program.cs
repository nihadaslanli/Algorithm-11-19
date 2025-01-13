#region task1,3
//string s =Console.ReadLine();
//bool isPalindrom = true;
//for (int i = 0; i < s.Length; i++)
//{
//    if (s[i] != s[s.Length - 1 - i])
//    {
//        Console.WriteLine("Palindrom deyil");
//          isPalindrom = false;
//        break;
//    }

//}
////if (isPalindrom)
//    Console.WriteLine("Palindromdur");
#endregion
#region task3
//int san =int.Parse(Console.ReadLine());

//int day = san / (24 * 60 * 60);
//int hour = (san % (24 * 60 * 60)) / (60 * 60);
//int minute = san % (60 * 60) / 60;
//int second = san % 60;
//Console.WriteLine($"{san}={day}:{hour}:{minute}:{second}");
#endregion
#region task4 
//double x1, x2, y1, y2;
//x1= double.Parse(Console.ReadLine());
//x2= double.Parse(Console.ReadLine());
//y1= double.Parse(Console.ReadLine());
//y2= double.Parse(Console.ReadLine()); 

//double distance=Math.Sqrt(Math.Pow(x1-x2 , 2) + Math.Pow(y1 - y2,2)); 
#endregion
#region task5 
//int number= int.Parse(Console.ReadLine());
//int reverse = 0;
//while (number > 0)
//{
//    reverse= reverse*100+number%100;
//    number /= 100;
//}
//while (reverse > 0)
//{
//    Console.Write(reverse%100+" ");
//    reverse /= 100;
//}
#endregion
#region task6
//Console.Write("Doguldugunuz gun:");

//int gun=int.Parse(Console.ReadLine());
//Console.Write("Doguldugunuz ay:");
//int ay = int.Parse(Console.ReadLine());
//Console.Write("Doguldugunuz il:");
//int il = int.Parse(Console.ReadLine());

//int gun1 = 14;
//int ay1 = 1;
//int il1 = 2025;

//if(ay1>ay) Console.WriteLine("Yas: "+(il1+il));
//else if(ay1 == ay){
//    if(gun1>gun) Console.WriteLine("Yas: "+(il1-il));
//    else Console.WriteLine("Yas: "+(il1-il));

//}
//else Console.WriteLine("Yas: "+(il1-il));
#endregion
#region task8
//Console.Write("n natural ededini daxil edin: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int beraberBolenlerinSayi = 0;

//for (int m = 1; m <= n; m++)
//{
//     if (n % m == n / m)
//    {
//        beraberBolenlerinSayi++;
//    }
//   }
//Console.WriteLine($"{n} ededinin bereber bölenlerinin sayı: {beraberBolenlerinSayi}");
#endregion
#region task9
//const int toplamAyak = 64;
//const int qazAyak = 2;
//const int dovsanAyak = 4;

//Console.WriteLine("Qazların ve dovşanların mümkün kombinasyonları:");

//for (int qaz = 0; qaz <= toplamAyak / qazAyak; qaz++)
//{
//    int dovsan = (toplamAyak - (qaz * qazAyak)) / dovsanAyak;

//    if (qaz * qazAyak + dovsan * dovsanAyak == toplamAyak)
//    {
//        Console.WriteLine($"Qaz: {qaz}, Dovşan: {dovsan}");
//    }
//}
#endregion
