using System;

namespace Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 
            Console.Write("Bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            int[] sayilar = new int[sayac];
            for (int i = 0; i < sayac; i++)
            {
                Console.Write("Sayı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            CiftSayiBul(sayilar);

            //2.
            Console.Write("Sayı giriniz: ");
            int sayac2 = int.Parse(Console.ReadLine());
            Console.Write("Sayı giriniz: ");
            int bolen = int.Parse(Console.ReadLine());
            int[] sayilar2 = new int[sayac2];
            for (int i = 0;i < sayac2; i++)
            {
                Console.Write("Sayı giriniz: ");
                sayilar2[i] = int.Parse(Console.ReadLine());
            }

            BolunenSayiBul(sayilar2, bolen);

            //3.
            Console.Write("Sayı giriniz: ");
            int sayac3 = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[sayac3];
            for(int i = 0; i < sayac3; i++)
            {
                Console.Write("Kelime giriniz: ");
                kelimeler[i] = Console.ReadLine();
            }

            //4.
            Console.Write("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();
            int kelimeSayisi = KelimeSayisi(cumle);
            int harfSayisi = HarfSayisi(cumle);
            Console.WriteLine("Kelime Sayısı = {0}, Harf Sayısı = {1}",kelimeSayisi, harfSayisi);
        }

        public static void CiftSayiBul(int[] dizi)
        {
            foreach (int i in dizi)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void BolunenSayiBul(int[] dizi, int sayi)
        {
            foreach (int item in dizi)
            {
                if(item % sayi == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void KelimeleriTerstenSirala(string[] dizi)
        {
            Array.Reverse(dizi);
            foreach(var kelime in dizi)
            {
                Console.WriteLine(kelime);
            }
        }

        public static int KelimeSayisi(string cumle)
        {
            int toplam = 0;
            string[] kelimeler = cumle.Split(' ');
            foreach(var item in kelimeler)
            {
                toplam++;
            }
            return toplam;
        }

        public static int HarfSayisi(string cumle)
        {
            int toplam = 0;
            string[] kelimeler = cumle.Split(" ");
            foreach(var item in kelimeler)
            {
                for(int i = 0; i < item.Length; i++)
                {
                    toplam++;
                }
            }
            return toplam;
        }
    }
}
