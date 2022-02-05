using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaOdev2
{
    class Program
    {
        static void Main(string[] args)
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


        {
            Console.WriteLine("Lütfen 2 tane pozitif tam sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz", n);
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                sayilar[i] = y;
            }
            Console.WriteLine("Tam bölen veya eşit olan sayılar");
            foreach (var sayi in sayilar)
            {
                if (m % sayi == 0 || sayi == m)
                {
                    Console.WriteLine(sayi);
                }
            }
            Console.ReadLine();
        }
    }
}
