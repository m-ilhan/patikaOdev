using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaOdev3
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz");
            int n = int.Parse(Console.ReadLine());
            if (n>0)
            {
                string[] kelimeler = new string[n];
                Console.WriteLine("Lütfen {0} adet kelime giriniz",n);
                for (int i = 0; i < n; i++)
                {
                    string x = Convert.ToString (Console.ReadLine());
                    kelimeler[i] = x;
                }
                Console.WriteLine("Kelimelerin Tersten Sıralanışı");
                Array.Reverse(kelimeler);
                foreach (var kelime in kelimeler)
                {
                    Console.WriteLine(kelime);

                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yanlış Giriş Yaptınız");
            }
        }
    }
}
