using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Dongusu
            // Koşul parantezi içerisindeki değer true olduğu sürece yaşam alanını çalıştırır.

            int sayı = 5;
            while (sayı >= 0)
            {
                Console.WriteLine("çalıştı");
            }
            Console.WriteLine("Döngü alanı dışı");
            #endregion

            #region 1-10 arası sayıları konsola yazdırma
            int sayi = 0;

            while (sayi <= 10)
            {
                Console.WriteLine(sayi);
                sayi++; //sayi = sayi +1; --- sayi+= 1;
            }

            #endregion

            #region Hacking

            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.WriteLine("?x?é!'3+%&");
            }
            #endregion

            #region 0-100 arası çift sayılar

            int sayi = 0;

            while (sayi <= 100)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
                sayi++;
            }
            #endregion

            #region Kullanıcıdan alınan veri ile 0-100 arası çift sayılar
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi <= 100)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
                sayi++;
            }

            #endregion

            #region 0-100 arasında 4'e bölünebilen kaç sayı vardır?
            int sayi = 0;
            int adet = 0;

            while (sayi <= 100)
            {
                if (sayi % 4 == 0)
                {
                    adet++;
                }
                sayi++;
            }
            Console.WriteLine(adet);
            #endregion

            #region 0-100 arasında 4'e bölünebilen kaç sayı var ve toplamları ne?
            int sayi = 0;
            int adet = 0;
            int toplam = 0;

            while (sayi <= 100)
            {
                if (sayi % 4 == 0)
                {
                    toplam += sayi;
                    adet++;
                }
                sayi++;
            }
            Console.WriteLine("Adet = " + adet);
            Console.WriteLine("Toplam = " + toplam);
            #endregion

            #region Çarpım tablosunun 3'ler basamağını yazdırınız?

            int carpan = 1;

            while (carpan <= 10)
            {
                Console.WriteLine("3 x " + carpan + " = " + (3 * carpan));
                carpan++;
            }
            #endregion

            #region Çarpım tablosunun kullanıcıdan alınan taban değerini yazdırınız?

            Console.WriteLine("Lütfen taban değeri giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());

            int carpan = 1;

            while (carpan <= 10)
            {
                Console.WriteLine(taban + " x " + carpan + " = " + (taban * carpan));
                carpan++;
            }
            #endregion

            #region Tüm çarpım tablosunu yazınız?
            int taban = 1;

            while (taban <= 10)
            {
                int carpan = 1;

                while (carpan <= 10)
                {
                    Console.WriteLine(taban + " x " + carpan + " = " + (taban * carpan));
                    carpan++;
                }
                taban++;
            }
            #endregion

        }
    }
}
