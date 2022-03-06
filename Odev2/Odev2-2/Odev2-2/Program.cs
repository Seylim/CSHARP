using System;

namespace Odev2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = SayiAl();
            int enKucukToplam = EnKucukToplam(sayilar);
            int enBuyukToplam = EnBuyukToplam(sayilar);
            float enKucukOrtalama = Ortalama(enKucukToplam);
            float enBuyukOrtalama = Ortalama(enBuyukToplam);

            Console.WriteLine("En Küçük 3 Sayının Toplamı: {0},     Ortalaması: {1}",enKucukToplam, enKucukOrtalama);
            Console.WriteLine();
            Console.WriteLine("En Büyük 3 Sayının Toplamı: {0},     Ortalaması: {1}", enBuyukToplam, enBuyukOrtalama);
        }

        static int[] SayiAl()
        {
            int sayac = 20, index = 0;
            int[] sayilar = new int[sayac];
            while (sayac != 0)
            {
                Console.Write("Bir sayı giriniz: ");
                bool success = int.TryParse(Console.ReadLine(), out int sayi);
                if (success)
                {
                    sayilar[index] = sayi;
                    index++;
                }
                sayac--;
            }
            return sayilar;
        }

        static int EnKucukToplam(int[] sayilar)
        {
            int toplam = 0;
            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        static int EnBuyukToplam(int[] sayilar)
        {
            int toplam = 0;
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        static float Ortalama(int toplam)
        {
            return (float)toplam / 3f;
        }
    }
}
