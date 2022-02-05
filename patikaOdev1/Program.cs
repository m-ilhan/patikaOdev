using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.WriteLine("Lütfen pozitif bir sayi giriniz:");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int[] sayilar = new int[n];
                Console.WriteLine("Lütfen {0} adet sayı giriniz", n);
                for (int i = 0; i < n; i++)
                {
                    int m = int.Parse(Console.ReadLine());
                    sayilar[i] = m;
                }
                Console.WriteLine("Girilen Çift Sayılar");
                foreach (var sayi in sayilar)
                {
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız tekrar deneyiniz.");
                Console.ReadLine();
            }

        }
    }
}
