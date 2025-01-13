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
